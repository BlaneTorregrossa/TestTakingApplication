﻿using System;
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
        public TestBehaviour testInfo;

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
                    if (CheckTestFile(file.DirectoryName + "/" + file.Name) == true)
                        dropdown.Items.Add(file.DirectoryName + "/" + file.Name);
                    else
                        Console.Write("File does not meet requirements to be added to test list. Please check what the issue can be and then recreate your test.");
                }
                else
                    Console.WriteLine("File " + file.Name + " is not of correct file type for tests. Please remove this file.");
            }
        }

        public bool CheckTestFile(string filePath)
        {
            maxQuestionAmount = TestInformationCheck(filePath);

            using (StreamReader sr = new StreamReader(filePath))
            {
                string answersAvalible = "", answersRequired = "", answers = "";

                while (!sr.EndOfStream)
                {
                    string currentLine = sr.ReadLine();

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
                                //  question is in here four times...
                                testInfo.Questions[questionNum].QuestionNum = questionNum;
                            }
                            if (currentLine.Contains("Question = "))
                            {
                                questionStatementCheck = true;
                                char[] t = new char[] { 'Q', 'u', 'e', 's', 't', 'i', 'o', 'n', ' ', '=', ' ' };
                                testInfo.Questions[questionNum].QuestionText = currentLine.Trim(t);
                            }

                            if (currentLine.Contains("Type = TrueFalse"))
                            {
                                questionTypeCheck = true;
                                questionType = "TrueFalse";
                                testInfo.Questions[questionNum].questionType = QuestionType.TrueFalse;
                            }

                            if (currentLine.Contains("Type = FillInTheBlank"))
                            {
                                questionTypeCheck = true;
                                questionType = "FillInTheBlank";
                                testInfo.Questions[questionNum].questionType = QuestionType.FillInTheBlank;
                            }

                            if (currentLine.Contains("Type = MultipleChoice"))
                            {
                                questionTypeCheck = true;
                                questionType = "MultipleChoice";
                                testInfo.Questions[questionNum].questionType = QuestionType.MultipleChoice;
                            }

                            if (questionTypeCheck == true && questionType == "TrueFalse" &&
                                currentLine.Contains("Answer ="))
                            {
                                if (TrueFalseCheck(currentLine, testInfo, questionNum) == false)
                                {
                                    Console.WriteLine("Error with trying to read question. Please check the test file: " + filePath);
                                    Application.Exit();
                                }
                                else
                                {
                                    questionNum++;
                                }
                            }

                            else if (questionTypeCheck == true && questionType == "FillInTheBlank")
                            {
                                if (currentLine.Contains("AnswersAvalible ="))
                                    answersAvalible = currentLine;
                                if (currentLine.Contains("AnswersRequired ="))
                                    answersRequired = currentLine;
                                if (currentLine.Contains("Answers ="))
                                    answers = currentLine;

                                if (answersAvalible != "" && answersRequired != "" && answers != "")
                                {
                                    if (FillInTheBlankCheck(answersAvalible, answersRequired, answers, testInfo, questionNum) == false)
                                    {
                                        Console.WriteLine("Error with trying to read question. Please check the test file: " + filePath);
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        answersAvalible = "";
                                        answersRequired = "";
                                        answers = "";
                                        questionNum++;
                                    }
                                }
                            }

                            else if (questionTypeCheck == true && questionType == "MultipleChoice")
                            {
                                if (currentLine.Contains("Answers ="))
                                    answers = currentLine;
                                if (currentLine.Contains("CorrectChoice ="))
                                {
                                    //  the use of this never ends
                                    char[] t = new char[] { 'C', 'o', 'r', 'r', 'e', 't', 'C', 'h', 'o', 'i', 'c', 'e', ' ', '=', ' ' };
                                    currentLine = currentLine.Trim(t);
                                    int.TryParse(currentLine, out correctChoice);
                                    testInfo.Questions[questionNum].MCAnswer = correctChoice;
                                }

                                if (answers != "" && correctChoice > -1)
                                {
                                    if (MultipleChoiceCheck(answers, correctChoice, testInfo, questionNum) == false)
                                    {
                                        Console.WriteLine("Error with trying to read question. Please check the thest file: " + filePath);
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        answers = "";
                                        questionNum++;
                                    }
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
                }
            }

            return false;
        }

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
                        {
                            titleCheck = true;
                            char[] t = new char[] { 'T', 'I', 'T', 'L', 'E', ' ', '=', ' ' };
                            testInfo.TestTitle = currentLine.Trim(t);
                        }
                        if (currentLine.Contains("TIMELIMIT = "))
                        {
                            timeCheck = true;
                            char[] t = new char[] { 'T', 'I', 'M', 'E', 'L', 'I', 'M', 'I', 'T', ' ', '=', ' ' };
                            currentLine = currentLine.Trim(t);
                            int.TryParse(currentLine, out testInfo.MaxTime);
                        }
                        if (currentLine.Contains("MAXQUESTIONS = "))
                        {
                            //  This is awful
                            char[] t = new char[] { 'M', 'A', 'X', 'Q', 'U', 'E', 'S', 'T', 'I', 'O', 'N', 'S', ' ', '=', ' ' };
                            currentLine = currentLine.Trim(t);
                            questionAmountCheck = true;
                            int.TryParse(currentLine, out maxQuestionAmount);
                            int.TryParse(currentLine, out testInfo.QuestionSize);
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

        public bool TrueFalseCheck(string line, TestBehaviour ti, int questionNum)
        {
            if (line.Contains("Answer = True") || line.Contains("Answer = False"))
            {
                questionAnswerCheck = true;
                if (questionNumCheck == true && questionTypeCheck == true &&
                    questionStatementCheck == true && questionAnswerCheck == true)
                {
                    char[] t = new char[] { 'A', 'n', 's', 'w', 'e', 'r', ' ', '=', ' ' };
                    if (line.Trim(t) == "False")
                        ti.Questions[questionNum].TFAnswer = false;
                    else if (line.Trim(t) == "True")
                        ti.Questions[questionNum].TFAnswer = true;

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

        public bool FillInTheBlankCheck(string answersAvalibleLine, string answersRequiredLine, string answersLine, TestBehaviour ti, int questionNum)
        {
            if (questionType == "FillInTheBlank")
            {
                if (answersAvalibleLine.Contains("AnswersAvalible = "))
                {
                    //  The return of what I hate
                    char[] t = new char[] { 'A', 'n', 's', 'w', 'e', 'r', 's', 'A', 'v', 'a', 'l', 'i', 'b', 'l', 'e', ' ', '=', ' ' };
                    answersAvalibleLine = answersAvalibleLine.Trim(t);
                    int.TryParse(answersAvalibleLine, out answersAvalible);
                }
                if (answersRequiredLine.Contains("AnswersRequired = "))
                {
                    //  The return of what I hate... again
                    char[] t = new char[] { 'A', 'n', 's', 'w', 'e', 'r', 's', 'R', 'e', 'q', 'u', 'i', 'r', 'e', 'd', ' ', '=', ' ' };
                    answersRequiredLine = answersRequiredLine.Trim(t);
                    int.TryParse(answersRequiredLine, out answersRequired);
                    ti.Questions[questionNum].FITBRequirment = answersRequired;
                }

                if (answersAvalible > 0 && answersRequired > 0 && answersLine.Contains("Answers = "))
                {
                    string output = null;
                    int passCounter = 0;
                    for (int i = 1; i < (answersAvalible * 2) + 1; i++)
                    {
                        output = answersLine.Split('[', ']')[i];
                        if (output != " " && output != "")
                        {
                            ti.Questions[questionNum].FITBAnswers[passCounter] = output;
                            passCounter++;
                        }
                    }

                    if (answersAvalible == passCounter)
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

        public bool MultipleChoiceCheck(string answersLine, int correctChoiceInt, TestBehaviour ti, int questionNum)
        {
            if (questionType == "MultipleChoice")
            {
                if (correctChoiceInt >= 0 && correctChoiceInt <= 3 && answersLine.Contains("Answers = "))
                {
                    string output = null;
                    int passCounter = 0;
                    for (int i = 1; i < 9; i++)
                    {
                        output = answersLine.Split('[', ']')[i];
                        if (output != " " && output != "")
                        {
                            ti.Questions[questionNum].MCChoices[passCounter] = output;
                            passCounter++;
                        }
                    }

                    if (passCounter == 4)
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

        public TestBehaviour SaveInformation(string testPath)
        {
            currentDirectory = new DirectoryInfo(testPath);
            if (!currentDirectory.Exists)
            {
                Console.WriteLine("This test does not exist.");
                return testInfo;
            }
            string extension = currentDirectory.Extension;
            if (extension == ".txt")
            {
                if (CheckTestFile(testPath) == true)
                    return testInfo;
                else
                    Console.Write("File does not meet requirements to be used as a test. Please check what the issue can be and then recreate your test.");
            }
            else
                Console.WriteLine("File " + testPath + " is not of correct file type for tests. Please remove this file.");

            return testInfo;
        }

    }
}

