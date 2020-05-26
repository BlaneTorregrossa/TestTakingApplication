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
        public void CreateTestFile(TestBehaviour tb)
        {
            using (StreamWriter sw = File.CreateText(tb.TestPath))
            {
                sw.WriteLine("[*TESTINFO*]");
                sw.WriteLine("Title = " + tb.TestTitle);
                sw.WriteLine("TimeLimit = " + tb.MaxTime);
                sw.WriteLine("MaxQuestions = " + tb.QuestionSize);
                sw.WriteLine("[*QUESTIONS*]");
            }
        }

        public void AddQuestionInfo(QuestionBehaviour qb, int ql)
        {
            using (StreamWriter sw = File.AppendText(qb.TestPath))
            {
                sw.WriteLine("QuestionNum = " + qb.QuestionNum);
                sw.WriteLine("Type = " + qb.questionType);
                sw.WriteLine("Question = " + qb.QuestionText);

                if (qb.questionType == QuestionType.TrueFalse)
                {
                    sw.WriteLine("Answer = " + qb.TFAnswer);
                }
                else if (qb.questionType == QuestionType.FillInTheBlank)
                {
                    sw.WriteLine("AnswersAvalible = " + qb.AnswersAvalible);
                    sw.WriteLine("AnswersRequired = " + qb.FITBRequirment);
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
                    sw.Write("Answers = ");
                    for (int i = 0; i < qb.MCChoices.Length; i++)
                    {
                        if (i == qb.MCChoices.Length - 1)
                            sw.WriteLine("[" + qb.MCChoices[i] + "] ");
                        else
                            sw.Write("[" + qb.MCChoices[i] + "] ");
                    }
                    sw.WriteLine("CorrectChoice = " + qb.MCAnswer);
                }
                sw.WriteLine("[*ENDQUESTION*]");
                sw.WriteLine("");
                if (qb.QuestionNum >= ql - 1)
                    sw.WriteLine("[*ENDTEST*]");
                return;
            }
        }
    }
}
