using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public enum QuestionType
    {
        None = 0,
        TrueFalse = 1,
        FillInTheBlank = 2,
        MultipleChoice = 3
    }

    public class QuestionBehaviour
    {
        public string TestPath;
        public QuestionType questionType;
        public string QuestionText;
        public int QuestionNum;
        public bool TFAnswer;
        public int AnswersAvalible;
        public string[] FITBAnswers = new string[10];
        public int FITBRequirment;
        public string[] MCChoices = new string[4];
        public int MCAnswer;

        public void MissingInfoPopUp(PopupForm puf, NewTestForm ntf, string title, string text, bool close)
        {
            //  Popup window
            if (ntf != null)
            {
                ntf.Hide(); ;
                puf.PrevForm = ntf;
                puf.Location = ntf.Location;
                puf.StartPosition = FormStartPosition.CenterScreen;
                puf.WarningTitle = title;
                puf.WarningText = text;
                puf.ShowDialog();
                puf.Activate();
                ntf.Close();
            }

            return;
        }

        public bool CheckTestReq()
        {
            string[] stream = File.ReadAllLines(TestPath);
            bool titleSpotted = false,
                timeLimitSpotted = false,
                maxQuestionsSpotted = false;

            foreach (string line in stream)
            {

                if (line.Contains("TITLE"))
                    titleSpotted = true;
                else if (line.Contains("TIMELIMIT"))
                    timeLimitSpotted = true;
                else if (line.Contains("MAXQUESTIONS"))
                    maxQuestionsSpotted = true;

                if (titleSpotted == true && timeLimitSpotted == true && maxQuestionsSpotted == true)
                    return true;
            }
            return false;
        }

        public void CreateQuestion(int ql)
        {
            using (StreamWriter sw = File.AppendText(TestPath))
            {
                sw.WriteLine("QuestionNum = " + QuestionNum);
                sw.WriteLine("Type = " + questionType);
                sw.WriteLine("Question = " + QuestionText);

                if (questionType == QuestionType.TrueFalse)
                {
                    sw.WriteLine("Answer = " + TFAnswer);
                }
                else if (questionType == QuestionType.FillInTheBlank)
                {
                    sw.WriteLine("AnswersAvalible = " + AnswersAvalible);
                    sw.WriteLine("AnswersRequired = " + FITBRequirment);
                    sw.Write("Answers = ");
                    for (int i = 0; i < AnswersAvalible; i++)
                    {
                        if (i == AnswersAvalible - 1)
                            sw.WriteLine("[" + FITBAnswers[i] + "] ");
                        else
                            sw.Write("[" + FITBAnswers[i] + "] ");
                    }
                }
                else if (questionType == QuestionType.MultipleChoice)
                {
                    sw.Write("Answers = ");
                    for (int i = 0; i < MCChoices.Length; i++)
                    {
                        if (i == MCChoices.Length - 1)
                            sw.WriteLine("[" + MCChoices[i] + "] ");
                        else
                            sw.Write("[" + MCChoices[i] + "] ");
                    }
                    sw.WriteLine("CorrectChoice = " + MCAnswer);
                }

                sw.WriteLine("[*ENDQUESTION*]");
                sw.WriteLine("");

                if (QuestionNum >= ql - 1)
                    sw.WriteLine("[*ENDTEST*]");

                return;
            }
        }

    }
}
