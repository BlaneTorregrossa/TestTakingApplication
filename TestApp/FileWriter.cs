using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class FileWriter
    {
        //  Creating Test File and adding test information excluding questions
        public void CreateTestFile(TestBehaviour tb)
        {
            using (StreamWriter sw = File.CreateText(tb.TestPath))
            {
                sw.WriteLine("[*TESTINFO*]");   //  Start of test information
                sw.WriteLine("Title = " + tb.TestTitle);    //  Test title
                sw.WriteLine("TimeLimit = " + tb.MaxTime);  //  Test time limit
                sw.WriteLine("MaxQuestions = " + tb.QuestionSize);  //  Test question amount
                sw.WriteLine("[*QUESTIONS*]");  //  Start of questions
            }
        }

        //  Creating and adding questions to test file
        public void AddQuestionInfo(QuestionBehaviour qb, int ql)
        {
            using (StreamWriter sw = File.AppendText(qb.TestPath))
            {
                sw.WriteLine("QuestionNum = " + qb.QuestionNum);    //  Question number
                sw.WriteLine("Type = " + qb.questionType);  //  Question type
                sw.WriteLine("Question = " + qb.QuestionText);  //  Question text

                if (qb.questionType == QuestionType.TrueFalse)
                {
                    sw.WriteLine("Answer = " + qb.TFAnswer);    //  Question True False answer
                }
                else if (qb.questionType == QuestionType.FillInTheBlank)
                {
                    sw.WriteLine("AnswersAvalible = " + qb.AnswersAvalible);    //  Answers avalible (interger amount) for fill in the blank question
                    sw.WriteLine("AnswersRequired = " + qb.FITBRequirment); //  Answers required (interger amount) for fill in the blank question
                    //  Answers for fill in the blank question
                    sw.Write("Answers = "); 
                    for (int i = 0; i < qb.AnswersAvalible; i++)
                    {
                        if (i == qb.AnswersAvalible - 1)
                            sw.WriteLine("[" + qb.FITBAnswers[i] + "] ");
                        else
                            sw.Write("[" + qb.FITBAnswers[i] + "] ");
                    }
                }
                else if (qb.questionType == QuestionType.MultipleChoice)
                {
                    //  Answers for multiple choice question
                    sw.Write("Answers = ");
                    for (int i = 0; i < qb.MCChoices.Length; i++)
                    {
                        if (i == qb.MCChoices.Length - 1)
                            sw.WriteLine("[" + qb.MCChoices[i] + "] ");
                        else
                            sw.Write("[" + qb.MCChoices[i] + "] ");
                    }
                    sw.WriteLine("CorrectChoice = " + qb.MCAnswer); //  Correct choice for multiple choice question
                }
                sw.WriteLine("[*ENDQUESTION*]");    //  End of a question
                sw.WriteLine("");   //  space on file for readability
                if (qb.QuestionNum >= ql - 1)
                    sw.WriteLine("[*ENDTEST*]");    //  End of the test
                return;
            }
        }
    }
}
