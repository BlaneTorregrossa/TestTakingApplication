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

            using (StreamReader sr = new StreamReader(filePath))
            {
                string answersAvalible = "", answersRequired = "", answers = "";
                int correctChoice = -1;

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
                                    if (FillInTheBlankCheck(answersAvalible, answersRequired, answers) == false)
                                    {
                                        Console.WriteLine("Error with trying to read question. Please check the test file: " + filePath);
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        answersAvalible = "";
                                        answersRequired = "";
                                        answers = "";
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
                                }

                                if (answers != "" && correctChoice > -1)
                                {
                                    if (MultipleChoiceCheck(answers, correctChoice) == false)
                                    {
                                        Console.WriteLine("Error with trying to read question. Please check the thest file: " + filePath);
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        answers = "";
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
                }

                if (answersAvalible > 0 && answersRequired > 0 && answersLine.Contains("Answers = "))
                {
                    string output = null;
                    int passCounter = 0;
                    for (int i = 1; i < (answersAvalible * 2) + 1; i++)
                    {
                        output = answersLine.Split('[', ']')[i];
                        if (output != " " && output != "")
                            passCounter++;
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

        public bool MultipleChoiceCheck(string answersLine, int correctChoiceInt)
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
                            passCounter++;
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

    }
}

