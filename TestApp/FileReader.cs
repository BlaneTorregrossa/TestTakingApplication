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
            bool testInfoCheck = false;
            bool titleCheck = false;
            bool timeCheck = false;
            bool questionAmountCheck = false;
            int maxQuestionAmount = -1;

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

        public bool QuestionCheck(string filePath)
        {
            //  And I hate this...
            bool questionsStartCheck = false;
            string questionType = "NULL";

            //  And this...
            int questionNum = 1;
            int answersAvalible = 0;
            int answersRequired = 0;
            int correctChoice = -1;

            //  Really hate this...
            bool questionNumCheck = false;
            bool questionTypeCheck = false;
            bool questionStatementCheck = false;
            bool questionAnswerCheck = false;

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
                    }
                }
                    
            }
            return false;
        }

        //  TODO:   Reformat this
        public bool CheckTestFile(string filePath)
        {

            //  I hate this...
            List<bool> questionConditions = new List<bool>();
            for (int i = 0; i < 99; i++)
                questionConditions.Add(new bool());

            //  And I hate this...
            int maxQuestionAmount = -1;
            bool questionsStartCheck = false;
            string questionType = "NULL";

            //  And this...
            int questionNum = 1;
            int answersAvalible = 0;
            int answersRequired = 0;
            int correctChoice = -1;

            //  Really hate this...
            bool questionNumCheck = false;
            bool questionTypeCheck = false;
            bool questionStatementCheck = false;
            bool questionAnswerCheck = false;

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

                            #region True False
                            if (questionType == "TrueFalse")
                            {
                                if (sr.ReadLine().Contains("Answer = True") ||
                                        sr.ReadLine().Contains("Answer = False"))
                                {
                                    questionAnswerCheck = true;
                                    if (sr.ReadLine().Contains("[*ENDQUESTION*]") &&
                                        questionNumCheck == true && questionTypeCheck == true &&
                                        questionStatementCheck == true && questionAnswerCheck == true)
                                    {
                                        questionNumCheck = false;
                                        questionTypeCheck = false;
                                        questionStatementCheck = false;
                                        questionAnswerCheck = false;
                                    }
                                }
                            }
                            #endregion

                            #region FillInTheBlanks
                            if (questionType == "FillInTheBlanks")
                            {
                                if (sr.ReadLine().Contains("AnswersAvalible = " + Enumerable.Range(1, 9)))
                                    int.TryParse(sr.ReadLine(), out answersAvalible);
                                if (sr.ReadLine().Contains("AnswersRequired = " + Enumerable.Range(1, 9)))
                                    int.TryParse(sr.ReadLine(), out answersRequired);

                                if (answersAvalible > 0 && answersRequired > 0 && sr.ReadLine().Contains("Answers = "))
                                {
                                    string output = sr.ReadLine().Split('[', ']')[0];
                                    if (output != null)
                                    {
                                        Console.WriteLine("Fill in the blanks answers." + output);

                                        answersAvalible = 0;
                                        answersRequired = 0;
                                        questionNumCheck = false;
                                        questionTypeCheck = false;
                                        questionStatementCheck = false;
                                        questionAnswerCheck = false;
                                    }
                                }
                            }
                            #endregion

                            #region MultipleChoice
                            if (questionType == "MultipleChoice")
                            {
                                if (sr.ReadLine().Contains("CorrectChoice = " + Enumerable.Range(0, 3)))
                                    int.TryParse(sr.ReadLine(), out correctChoice);

                                if (correctChoice >= 0 && correctChoice <= 3 && sr.ReadLine().Contains("Answers = "))
                                {
                                    string output = sr.ReadLine().Split('[', ']')[0];
                                    if (output != null)
                                    {
                                        correctChoice = -1;
                                        questionNumCheck = false;
                                        questionTypeCheck = false;
                                        questionStatementCheck = false;
                                        questionAnswerCheck = false;
                                    }
                                }
                            }
                            #endregion
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

