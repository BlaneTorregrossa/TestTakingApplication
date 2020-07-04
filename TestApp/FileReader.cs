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
        public List<FileInfo> testFiles;    //  List of test files
        public DirectoryInfo currentDirectory;  //  Current directory being used
        public TestBehaviour testInfo;  //  Test information
        public FileWriter fileWriter;   //  For error logging

        //  Checkes for needed information in test file
        private bool testInfoCheck = false;
        private bool titleCheck = false;
        private bool timeCheck = false;
        private bool questionAmountCheck = false;
        private int maxQuestionAmount = -1;

        //  Checks for needed information in test file for questions specifically
        private bool questionsStartCheck = false;
        private string questionType = "NULL";

        //  Needed information for questions
        private int questionNum = 0;
        private int answersAvalible = 0;
        private int answersRequired = 0;
        private int correctChoice = -1;

        //  Checkes for needed question related information in test file
        private bool questionNumCheck = false;
        private bool questionTypeCheck = false;
        private bool questionStatementCheck = false;
        private bool questionAnswerCheck = false;

        private bool saveInfo = false;  //  For taking the test

        public FileReader()
        {
            testFiles = new List<FileInfo>();
            testInfo = new TestBehaviour();
            fileWriter = new FileWriter();
        }

        //  Read the tests to determine what tests will appear in Form1 Dropdown
        public void ReadTestsDropDown(string folderPath, ComboBox dropdown)
        {
            currentDirectory = new DirectoryInfo(folderPath);   //  Sets current directory to given folder
            if (!currentDirectory.Exists)   //  Creates this folder if it does not exist
            {
                fileWriter.LogError("This Directory (" + currentDirectory.ToString() + ") does not exist. Will create a new folder");
                currentDirectory.Create();
            }

            foreach (FileInfo file in currentDirectory.GetFiles())
            {
                testInfo = new TestBehaviour();
                string extension = file.Extension;  //  get the file extension of the current file in directory
                if (extension == ".txt")
                {
                    //  If given file passes Checks then add the test to the dropdown menu and reset test checks
                    if (CheckTestFile(file.DirectoryName + "/" + file.Name) == true)
                    {
                        dropdown.Items.Add(file.DirectoryName + "/" + file.Name);   //  Add given file to dropdown menu
                        maxQuestionAmount = -1;
                        questionNum = 0;
                        testInfoCheck = false;
                        timeCheck = false;
                        titleCheck = false;
                    }
                    else
                        fileWriter.LogError("File " + file.Name + " does not meet requirements to be added to test list. Please check what the issue can be and then recreate your test.");
                }
                else
                    fileWriter.LogError("File " + file.Name + " is not of correct file type for tests. Please remove this file.");
            }
        }

        //  Check if test file meets needed requirments
        public bool CheckTestFile(string filePath)
        {
            maxQuestionAmount = TestInformationCheck(filePath); //  Check if test meets requirments with it's contents (besides questions) and set the max question amount
            questionAmountCheck = false;

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
                            //  Check Questions for the question number, question text and the type and assigns that information to the question behaviour instance
                            if (currentLine.Contains("QuestionNum = " + questionNum))
                            {
                                questionNumCheck = true;
                                testInfo.Questions[questionNum].QuestionNum = questionNum;
                            }

                            if (currentLine.Contains("Question = "))
                            {
                                questionStatementCheck = true;
                                testInfo.Questions[questionNum].QuestionText = currentLine.Remove(0, 11);
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
                                // if TrueFalseCheck is failed tell the user that something is wrong with the test file and exit application. Else increase question number counter.
                                if (TrueFalseCheck(currentLine, testInfo, questionNum) == false)
                                {
                                    fileWriter.LogError("Error with trying to read True/False question. Please check the test file: " + filePath);
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
                                    //  if FillInTheBlankCheck is failed tell the user that something is wrong with the test file and exit application.
                                    //  Else increase question number counter and reset the FITB answer strings.
                                    if (FillInTheBlankCheck(answersAvalible, answersRequired, answers, testInfo, questionNum) == false)
                                    {
                                        fileWriter.LogError("Error with trying to read Fill in the Blank question. Please check the test file: " + filePath);
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
                                    currentLine = currentLine.Remove(0, 15);    //  Remove CorrectChoice = from the string
                                    int.TryParse(currentLine, out correctChoice);   //  Parse int from line to correctChoice
                                    testInfo.Questions[questionNum].MCAnswer = correctChoice;   //  Set answer for current question
                                }

                                if (answers != "" && correctChoice > -1)
                                {
                                    // if MultipleChoiceCheck is failed tell the user that something is wrong with the test file and exit application.
                                    //  Else increase question number counter and reset answer string.
                                    if (MultipleChoiceCheck(answers, correctChoice, testInfo, questionNum) == false)
                                    {
                                        fileWriter.LogError("Error with trying to read Multiple Choice question. Please check the thest file: " + filePath);
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
                        fileWriter.LogError("Errors with counting the max questions on test");
                        return false;
                    }
                }
            }
            return false;
        }

        //  Check for test information not involving individual questions returning and interger of the MaxQuestionsNumber
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
                        //  Check file for Title, Time Limit and Max Questions amount
                        if (currentLine.Contains("Title = "))
                        {
                            titleCheck = true;
                            testInfo.TestTitle = currentLine.Remove(0, 8);  //  Remove Title = from line and assign TestTitle of test to what be what remains
                        }
                        if (currentLine.Contains("TimeLimit = "))
                        {
                            timeCheck = true;
                            currentLine = currentLine.Remove(0, 12);    //  Remove TimeLimit = from the line
                            int.TryParse(currentLine, out testInfo.MaxTime);    //  Parse out interger from line and assign MaxTime of test
                        }
                        if (currentLine.Contains("MaxQuestions = "))
                        {
                            currentLine = currentLine.Remove(0, 15);    //  Remove MaxQuestions = from the line
                            questionAmountCheck = true;
                            int.TryParse(currentLine, out maxQuestionAmount);   //  Parse out interger from line to what will be returned if all checks are met
                            int.TryParse(currentLine, out testInfo.QuestionSize);   //  Parse out interger from line to be saved as The amount of questions for the test
                        }
                        if (titleCheck == true && timeCheck == true && questionAmountCheck == true)
                        {
                            if (maxQuestionAmount > 99 || maxQuestionAmount < 1)
                            {
                                fileWriter.LogError("Max Questions for test file " + filePath + " is an unacceptable number." +
                                    " The value must be between 1 and 99");
                                return -1;
                            }
                            else
                                return maxQuestionAmount;   //  If every check is met return this
                        }
                    }
                }
            }
            return -1;  //  If not all checks are met return this
        }

        //  Check for True False questions and if those requirments are met
        public bool TrueFalseCheck(string line, TestBehaviour ti, int questionNum)
        {
            //  Check if line contains valid answer
            if (line.Contains("Answer = True") || line.Contains("Answer = False"))
            {
                questionAnswerCheck = true;
                if (questionNumCheck == true && questionTypeCheck == true &&
                    questionStatementCheck == true && questionAnswerCheck == true)
                {
                    //  Removes Answer = from line and if what remains is True or False then set that as answer for given True False question
                    if (line.Remove(0, 9) == "False")
                        ti.Questions[questionNum].TFAnswer = false;
                    else if (line.Remove(0, 9) == "True")
                        ti.Questions[questionNum].TFAnswer = true;

                    //  Resetting checks
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

        //  Check for Fill In The Blank questions and if those requirments are met
        public bool FillInTheBlankCheck(string answersAvalibleLine, string answersRequiredLine, string answersLine, TestBehaviour ti, int questionNum)
        {
            if (questionType == "FillInTheBlank")
            {
                if (answersAvalibleLine.Contains("AnswersAvalible = "))
                {
                    answersAvalibleLine = answersAvalibleLine.Remove(0, 18); // Removes AnswersAvalible = from line
                    int.TryParse(answersAvalibleLine, out answersAvalible); //  Parses interger from line and assigns empty interger to that value
                }
                if (answersRequiredLine.Contains("AnswersRequired = "))
                {
                    answersRequiredLine = answersRequiredLine.Remove(0, 18);    //  Removes AnswersRequired = from line
                    int.TryParse(answersRequiredLine, out answersRequired); //  Parses interger from line and assigns empty interger to that value
                    ti.Questions[questionNum].FITBRequirment = answersRequired; //  Assigns requirment value for the given question
                }

                //  Splits answers from dividing brackets in the string for the amount of answers that are avalible and add them to the current question information
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

                    //  If all went well reset the question requirments and return true
                    if (answersAvalible == passCounter)
                    {
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

        //  Check for Multiple Choice questions and if those requirments are met
        public bool MultipleChoiceCheck(string answersLine, int correctChoiceInt, TestBehaviour ti, int questionNum)
        {
            if (questionType == "MultipleChoice")
            {
                //  For the line that contains Answers = , split individual answers from brackets and add the output to the multiple choice array for the question
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

                    //  If pass counter equals 4 then return true and reset checks
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

        //  Checking test file but to have a test for the user to take.
        public TestBehaviour SaveInformation(string testPath)
        {
            currentDirectory = new DirectoryInfo(testPath);
            string extension = currentDirectory.Extension;
            if (extension == ".txt")
            {
                saveInfo = true;
                if (CheckTestFile(testPath) == true)
                {
                    saveInfo = false;
                    return testInfo;
                }
                else
                    fileWriter.LogError("File (" + testPath + ") does not meet requirements to be used as a test. Please check what the issue can be and then recreate your test.");
            }
            else
                fileWriter.LogError("File (" + testPath + ") is not of correct file type for tests. Please remove this file.");

            return testInfo;
        }

    }
}

