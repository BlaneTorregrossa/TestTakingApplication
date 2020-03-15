using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class TestBehaviour
    {
        public string TestPath;
        public string TestTitle;
        public int MaxTime;
        public int RemainingTime;
        public int QuestionSize;
        public QuestionBehaviour[] Questions = new QuestionBehaviour[99];

        public TestBehaviour()
        {
            for (int i = 0; i < 99; i++)
            {
                Questions[i] = new QuestionBehaviour();
            }
        }

        public void MissingInfoPopUp(PopupForm puf, TestSettingsForm tsf, string title, string text)
        {
            //  Popup window
            if (tsf != null)
            {
                puf.PrevForm = tsf;
                puf.Location = tsf.Location;
                puf.StartPosition = FormStartPosition.CenterScreen;
                puf.WarningTitle = title;
                puf.WarningText = text;
                puf.ShowDialog();
                puf.Activate();
            }

            return;
        }

        public void OpenQuestionEditor(TestSettingsForm tsf)
        {
            TestPath = "Tests/" + TestTitle + ".txt";

            tsf.Hide();
            var frm = new NewTestForm();
            frm.QBInstance.TestPath = TestPath;
            frm.TBInstance = this;
            frm.Location = tsf.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.ShowDialog();
            frm.Activate();
            tsf.Close();

            return;
        }

        public bool QuestionCheck()
        {
            for (int i = 0; i < QuestionSize; i++)
            {
                if (Questions[i] == null)
                    return false;
                else if (Questions[i].questionType != QuestionType.None && Questions[i].QuestionText != null)
                {
                    if (Questions[i].questionType == QuestionType.TrueFalse && Questions[i].TFAnswer != null && Questions[i].QuestionNum == QuestionSize - 1)
                        return true;
                    else if (Questions[i].questionType == QuestionType.FillInTheBlank)
                    {
                        for (int j = 0; j < Questions[i].AnswersAvalible; j++)
                        {
                            if (Questions[i].FITBAnswers[j] == null)
                                return false;
                        }
                        if (Questions[i].QuestionNum == QuestionSize - 1)
                            return true;
                    }
                    else if (Questions[i].questionType == QuestionType.MultipleChoice && Questions[i].MCAnswer != null)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (Questions[i].MCChoices[k] == "" || Questions[i].MCChoices[k] == null)
                                return false;
                        }
                        if (Questions[i].QuestionNum == QuestionSize - 1)
                            return true;
                    }
                }
            }
            return false;
        }

        public bool CheckTestReq()
        {
            bool titleSpotted = false,
                timeLimitSpotted = false,
                maxQuestionsSpotted = false;

            if (TestTitle != null)
                titleSpotted = true;
            if (MaxTime != null)
                timeLimitSpotted = true;
            if (QuestionSize != null)
                maxQuestionsSpotted = true;

            if (titleSpotted == true && timeLimitSpotted == true && maxQuestionsSpotted == true)
                return true;
            else
                return false;
        }
    }
}
