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
                        //  Add to drop down on Form1
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

        public bool CheckTestFile(string filePath)
        {

            //  I hate this...
            List<bool> questionConditions = new List<bool>();
            for (int i = 0; i < 99; i++)
                questionConditions.Add(new bool());

            //  And I hate this...
            bool testInfoCheck = false;
            bool titleCheck = false;
            bool timeCheck = false;
            bool questionAmountCheck = false;
            bool questionsStartCheck = false;
            string questionType = "NULL";

            //  And this...
            int questionNum = 1;

            //  Really hate this...
            bool questionNumCheck = false;
            bool questionTypeCheck = false;
            bool questionStatementCheck = false;
            bool questionAnswerCheck = false;

            //  This as well...
            bool testEndCheck = false;

            using (StreamReader sr = new StreamReader(filePath))
            {
                //  Break this up into seperate functions once finished in this endless if statement hell
                string line;
                if ((line = sr.ReadLine()) == "[*TESTINFO*]")
                    testInfoCheck = true;
                if (testInfoCheck == true)
                {
                    if (sr.ReadLine().Contains("Title = "))
                        titleCheck = true;
                    if (sr.ReadLine().Contains("TimeLimit = "))
                        timeCheck = true;
                    if (sr.ReadLine().Contains("MaxQuestions = "))
                        questionAmountCheck = true;

                    if (titleCheck == true &&
                        timeCheck == true &&
                        questionAmountCheck == true)
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
                                #endregion

                                #region FillInTheBlanks
                                int answersAvalible = 0;
                                int answersRequired = 0;
                                if (sr.ReadLine().Contains("AnswersAvalible = " + Enumerable.Range(1, 9)))
                                    int.TryParse(sr.ReadLine(), out answersAvalible);
                                if (sr.ReadLine().Contains("AnswersRequired = " + Enumerable.Range(1, 9)))
                                    int.TryParse(sr.ReadLine(), out answersRequired);

                                if (answersAvalible > 0 && answersRequired > 0)
                                {
                                    for (int i = 0; i < answersAvalible; i++)
                                    {
                                        //  Left off here
                                    }
                                }
                                #endregion

                            }
                        }
                    }
                }

            }

            return false;
        }
    }
}

