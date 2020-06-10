using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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

        private bool questionsStartCheck = false;
        private string questionType = "NULL";

        private int questionNum = 0;
        private int answersAvalible = 0;
        private int answersRequired = 0;
        private int correctChoice = -1;

        private bool questionNumCheck = false;
        private bool questionTypeCheck = false;
        private bool questionStatementCheck = false;
        private bool questionAnswerCheck = false;

        public FileReader()
        {
            testFiles = new List<FileInfo>();
        }

        //  1 start
        public void ReadTestsDropDown(string folderPath, ComboBox dropdown)
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
                    //  2 call
                    if (CheckTestFile(file.DirectoryName + "/" + file.Name) == true)
                    {
                        dropdown.Items.Add(file.DirectoryName);
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

        //  TODO:   Reformat this
        //  2 
        public bool CheckTestFile(string filePath)
        {
            //  3 call
            maxQuestionAmount = TestInformationCheck(filePath);

            //  *** Stopped Here
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string currentLine = sr.ReadLine();
                    string answersAvalible = "", answersRequired = "", answers = "";

                    if (maxQuestionAmount > 0)
                    {
                        if (currentLine.Contains("[*QUESTIONS*]"))
                            questionsStartCheck = true;

                        if (questionsStartCheck == true)
                        {
                            //  Check Questions
                            if (currentLine.Contains("QuestionNum = " + questionNum))
                            {
                                questionNumCheck = true;
                                questionNum++;
                            }
                            if (currentLine.Contains("Question = "))
                                questionStatementCheck = true;

                            if (currentLine.Contains("Type = TrueFalse"))
                            {
                                questionTypeCheck = true;
                                questionType = "TrueFalse";
                            }

                            if (currentLine.Contains("Type = FillInTheBlank"))
                            {
                                questionTypeCheck = true;
                                questionType = "FillInTheBlank";
                            }

                            if (currentLine.Contains("Type = MultipleChoice"))
                            {
                                questionTypeCheck = true;
                                questionType = "MultipleChoice";
                            }

                            if (questionTypeCheck == true && questionType == "TrueFalse" &&
                                currentLine.Contains("Answer ="))
                            {
                                if (TrueFalseCheck(currentLine) == false)
                                {
                                    Console.WriteLine("Error with trying to read question. Please check the test file: " + filePath);
                                    Application.Exit();
                                }
                            }
                            //  *** TODO:   Left off here Need to make a check for multiple choice and fill in the blank questions
                            //  Not tested yet
                            else if (questionTypeCheck == true && questionType == "FillInTheBlank")
                            {
                                if (currentLine.Contains("AnswersAvalible ="))
                                    answersAvalible = currentLine;
                                if (currentLine.Contains("AnswersRequired ="))
                                    answersRequired = currentLine;
                                if (currentLine.Contains("Answers ="))
                                    answers = currentLine;

                                if (answersAvalible != "" && answersRequired != "" && answers != "")
                                    if (FillInTheBlankCheck(answersAvalible, answersAvalible, answers) == false)
                                    {
                                        Console.WriteLine("Error with trying to read question. Please check the test file: " + filePath);
                                        Application.Exit();
                                    }
                            }

                            if (questionNum >= maxQuestionAmount && currentLine.Contains("[*ENDTEST*]"))
                                return true;
                        }
                    }
                    else if (maxQuestionAmount <= 0)
                    {
                        Console.WriteLine("Errors with counting the max questions");
                        return false;
                    }

                    if (currentLine.Contains("[*ENDQUESTION*]"))
                    {
                        Console.WriteLine("Error finding question. Check to see if test file format is correct or if this file is misplaced.");
                        return false;
                    }
                }
            }

            return false;
        }

        //  3
        public int TestInformationCheck(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string currentLine = sr.ReadLine();

                    if (currentLine.Contains("[*TESTINFO*]"))
                        testInfoCheck = true;
                    if (testInfoCheck == true)
                    {
                        if (currentLine.Contains("TITLE = "))
                            titleCheck = true;
                        if (currentLine.Contains("TIMELIMIT = "))
                            timeCheck = true;
                        if (currentLine.Contains("MAXQUESTIONS = "))
                        {
                            //  This is awful
                            char[] t = new char[] { 'M', 'A', 'X', 'Q', 'U', 'E', 'S', 'T', 'I', 'O', 'N', 'S', ' ', '=', ' ' };
                            currentLine = currentLine.Trim(t);
                            questionAmountCheck = true;
                            int.TryParse(currentLine, out maxQuestionAmount);
                        }
                        if (titleCheck == true && timeCheck == true && questionAmountCheck == true)
                        {
                            if (maxQuestionAmount > 99 || maxQuestionAmount < 1)
                            {
                                Console.WriteLine("Max Questions for test file " + filePath + " is an unacceptable number." +
                                    " The value must be between 1 and 99");
                                return -1;
                            }
                            else
                                return maxQuestionAmount;
                        }
                    }
                }
            }
            return -1;
        }

        public bool TrueFalseCheck(string line)
        {
            if (line.Contains("Answer = True") || line.Contains("Answer = False"))
            {
                questionAnswerCheck = true;
                if (questionNumCheck == true && questionTypeCheck == true &&
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

        public bool FillInTheBlankCheck(string answersAvalibleLine, string answersRequiredLine, string answersLine)
        {
            if (questionType == "FillInTheBlanks")
            {
                if (answersAvalibleLine.Contains("AnswersAvalible = " + Enumerable.Range(1, 9)))
                    int.TryParse(answersAvalibleLine, out answersAvalible);
                if (answersRequiredLine.Contains("AnswersRequired = " + Enumerable.Range(1, 9)))
                    int.TryParse(answersRequiredLine, out answersRequired);

                if (answersAvalible > 0 && answersRequired > 0 && answersLine.Contains("Answers = "))
                {
                    string output = answersLine.Split('[', ']')[0];
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

    }
}

