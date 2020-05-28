using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class FileReader
    {
        public List<FileInfo> testFiles;
        public DirectoryInfo currentDirectory;

        private bool testInfoCheck = false;
        private bool titleCheck = false;
        private bool timeCheck = false;
        private bool questionAmountCheck = false;
        private int maxQuestionAmount = -1;

        //  And I hate this...
        private bool questionsStartCheck = false;
        private string questionType = "NULL";

        //  And this...
        private int questionNum = 1;
        private int answersAvalible = 0;
        private int answersRequired = 0;
        private int correctChoice = -1;

        //  Really hate this...
        private bool questionNumCheck = false;
        private bool questionTypeCheck = false;
        private bool questionStatementCheck = false;
        private bool questionAnswerCheck = false;

        public FileReader()
        {
            testFiles = new List<FileInfo>();
        }

        public void ReadTestsDropDown(string folderPath)
        {
            currentDirectory = new DirectoryInfo(folderPath);
            if (!currentDirectory.Exists)
            {
                Console.WriteLine("This Directory does not exist. Will create a new folder");
                currentDirectory.Create();
            }

            foreach (FileInfo file in currentDirectory.GetFiles())
            {
                string extension = file.Extension;
                if (extension == ".txt")
                {
                    if (CheckTestFile(file.DirectoryName) == true)
                    {
                        // TODO:    Add to drop down on Form1
                    }
                    else
                    {
                        Console.Write("File does not meet requirements to be added to test list. Please check what the issue can be and then recreate your test.");
                    }
                }
                else
                {
                    Console.WriteLine("File " + file.Name + " is not of correct file type for tests. Please remove this file.");
                }
            }
        }

        public int TestInfoCheck(string filePath)
        {

            using (StreamReader sr = new StreamReader(filePath))
            {
                if (sr.ReadLine().Contains("[*TESTINFO*]"))
                    testInfoCheck = true;
                if (testInfoCheck == true)
                {
                    if (sr.ReadLine().Contains("Title = "))
                        titleCheck = true;
                    if (sr.ReadLine().Contains("TimeLimit = "))
                        timeCheck = true;
                    if (sr.ReadLine().Contains("MaxQuestions = " + Enumerable.Range(1, 99)))
                    {
                        questionAmountCheck = true;
                        int.TryParse(sr.ReadLine(), out maxQuestionAmount);
                    }
                    if (titleCheck == true && timeCheck == true && questionAmountCheck == true)
                        return maxQuestionAmount;
                }
            }

            return -1;
        }

        public bool TrueFalseCheck(string line)
        {
            if (line.Contains("Answer = True") || line.Contains("Answer = False"))
            {
                questionAnswerCheck = true;
                if (line.Contains("[*ENDQUESTION*]") &&
                    questionNumCheck == true && questionTypeCheck == true &&
                    questionStatementCheck == true && questionAnswerCheck == true)
                {
                    questionNumCheck = false;
                    questionTypeCheck = false;
                    questionStatementCheck = false;
                    questionAnswerCheck = false;
                    questionType = "";

                    return true;
                }
            }

            return false;
        }

        public bool FillInTheBlankCheck(string line)
        {
            if (questionType == "FillInTheBlanks")
            {
                if (line.Contains("AnswersAvalible = " + Enumerable.Range(1, 9)))
                    int.TryParse(line, out answersAvalible);
                if (line.Contains("AnswersRequired = " + Enumerable.Range(1, 9)))
                    int.TryParse(line, out answersRequired);

                if (answersAvalible > 0 && answersRequired > 0 && line.Contains("Answers = "))
                {
                    string output = line.Split('[', ']')[0];
                    if (output != null)
                    {
                        Console.WriteLine("Fill in the blanks answers." + output);

                        answersAvalible = 0;
                        answersRequired = 0;
                        questionNumCheck = false;
                        questionTypeCheck = false;
                        questionStatementCheck = false;
                        questionAnswerCheck = false;
                        questionType = "";

                        return true;
                    }
                }
            }

            return false;
        }

        public bool MultipleChoiceCheck(string line)
        {
            if (questionType == "MultipleChoice")
            {
                if (line.Contains("CorrectChoice = " + Enumerable.Range(0, 3)))
                    int.TryParse(line, out correctChoice);

                if (correctChoice >= 0 && correctChoice <= 3 && line.Contains("Answers = "))
                {
                    string output = line.Split('[', ']')[0];
                    if (output != null)
                    {
                        correctChoice = -1;
                        questionNumCheck = false;
                        questionTypeCheck = false;
                        questionStatementCheck = false;
                        questionAnswerCheck = false;
                        questionType = "";

                        return true;
                    }
                }
            }

            return false;
        }

        //  TODO:   Change parameters so you can continue the function where you left off on the file
        public void QuestionCheck(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                if (sr.ReadLine().Contains("[*QUESTIONS*]"))
                    questionsStartCheck = true;

                if (questionsStartCheck == true)
                {
                    if (sr.ReadLine().Contains("QuestionNum = " + questionNum))
                    {
                        questionNumCheck = true;
                        questionNum++;
                    }
                    if (sr.ReadLine().Contains("Question = "))
                        questionStatementCheck = true;
                    if (sr.ReadLine().Contains("Type = TrueFalse"))
                    {
                        questionTypeCheck = true;
                        questionType = "TrueFalse";
                    }
                    if (sr.ReadLine().Contains("Type = FillInTheBlank"))
                    {
                        questionTypeCheck = true;
                        questionType = "FillInTheBlank";
                    }
                    if (sr.ReadLine().Contains("Type = MultipleChoice"))
                    {
                        questionTypeCheck = true;
                        questionType = "MultipleChoice";
                    }
                    if (questionTypeCheck == true)
                    {
                        //  Function for specific question checking
                        //  Left off here
                        if (questionType == "TrueFalse")
                            TrueFalseCheck(sr.ReadLine());

                        if (questionType == "FillInTheBlank")
                        {
                            FillInTheBlankCheck(sr.ReadLine());
                        }

                        if (questionType == "MultipleChoice")
                        {
                            MultipleChoiceCheck(sr.ReadLine());
                        }
                    }
                }

            }
            return;
        }

        //  TODO:   Reformat this
        public bool CheckTestFile(string filePath)
        {
            maxQuestionAmount = TestInfoCheck(filePath);

            using (StreamReader sr = new StreamReader(filePath))
            {
                if (maxQuestionAmount > 0)
                {
                    if (sr.ReadLine().Contains("[*QUESTIONS*]"))
                        questionsStartCheck = true;

                    if (questionsStartCheck == true)
                    {
                        //  Check Questions
                        if (sr.ReadLine().Contains("QuestionNum = " + questionNum))
                        {
                            questionNumCheck = true;
                            questionNum++;
                        }
                        if (sr.ReadLine().Contains("Question = "))
                            questionStatementCheck = true;

                        if (sr.ReadLine().Contains("Type = TrueFalse"))
                        {
                            questionTypeCheck = true;
                            questionType = "TrueFalse";
                        }

                        if (sr.ReadLine().Contains("Type = FillInTheBlank"))
                        {
                            questionTypeCheck = true;
                            questionType = "FillInTheBlank";
                        }

                        if (sr.ReadLine().Contains("Type = MultipleChoice"))
                        {
                            questionTypeCheck = true;
                            questionType = "MultipleChoice";
                        }

                        if (questionTypeCheck == true)
                        {

                            QuestionCheck(filePath);

                        }

                        if (questionNum >= maxQuestionAmount && sr.ReadLine().Contains("[*ENDTEST*]"))
                        {
                            return true;
                        }

                    }
                }
                else if (maxQuestionAmount <= 0)
                {
                    Console.WriteLine("Errors with counting the max questions");
                    return false;
                }

                if (sr.ReadLine().Contains("[*ENDQUESTION*]"))
                {
                    Console.WriteLine("Error finding question. Check to see if test file format is correct or if this file is misplaced.");
                    return false;
                }
            }

            return false;
        }
    }
}

