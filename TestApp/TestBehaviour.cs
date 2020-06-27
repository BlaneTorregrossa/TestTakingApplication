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
        public bool InReview;
        public float TestScore;
        public QuestionBehaviour[] Questions = new QuestionBehaviour[99];

        public TestBehaviour()
        {
            for (int i = 0; i < 99; i++)
            {
                Questions[i] = new QuestionBehaviour();
            }
        }

        public void MissingInfoPopUp(PopupForm puf, Form pf, string title, string text)
        {
            //  Popup window
            if (pf != null)
            {
                puf.PrevForm = pf;
                puf.Location = pf.Location;
            }
            puf.StartPosition = FormStartPosition.CenterScreen;
            puf.WarningTitle = title;
            puf.WarningText = text;
            puf.ShowDialog();
            puf.Activate();

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

        public bool QuestionCheck(Form pf)
        {
            var frm = new PopupForm();
            for (int i = 0; i < QuestionSize; i++)
            {
                if (Questions[i] == null)
                {
                    MissingInfoPopUp(frm, pf, "Caution", "There is an issue with question " + Questions[i].QuestionNum + " . Please Go back and fix this issue before continuing.");
                    return false;
                }
                else if (Questions[i].questionType != QuestionType.None && Questions[i].QuestionText != null)
                {
                    if (Questions[i].questionType == QuestionType.TrueFalse && Questions[i].QuestionNum == QuestionSize - 1)
                        return true;
                    else if (Questions[i].questionType == QuestionType.FillInTheBlank)
                    {
                        for (int j = 0; j < Questions[i].AnswersAvalible; j++)
                        {
                            if (Questions[i].FITBAnswers[j] == null)
                            {
                                MissingInfoPopUp(frm, pf, "Caution", "There is an issue with question " + Questions[i].QuestionNum + " . Please Go back and fix this issue before continuing.");
                                return false;
                            }
                        }
                        if (Questions[i].QuestionNum == QuestionSize - 1)
                            return true;
                    }
                    else if (Questions[i].questionType == QuestionType.MultipleChoice && Questions[i].MCAnswer > -1)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (Questions[i].MCChoices[k] == "" || Questions[i].MCChoices[k] == null)
                            {
                                MissingInfoPopUp(frm, pf, "Caution", "There is an issue with question " + Questions[i].QuestionNum + " . Please Go back and fix this issue before continuing.");
                                return false;
                            }
                        }
                        if (Questions[i].QuestionNum == QuestionSize - 1)
                            return true;
                    }
                }
            }
            MissingInfoPopUp(frm, pf, "Caution", "There is an issue with one of the questions in the test. We could not determine which specific question. Please go back and fix this issue before continuing.");
            return false;
        }

        public bool CheckTestReq()
        {
            bool titleSpotted = false,
                timeLimitSpotted = false,
                maxQuestionsSpotted = false;

            if (TestTitle != null)
                titleSpotted = true;
            if (MaxTime > 0)
                timeLimitSpotted = true;
            if (QuestionSize > 0)
                maxQuestionsSpotted = true;

            if (titleSpotted == true && timeLimitSpotted == true && maxQuestionsSpotted == true)
                return true;
            else
                return false;
        }

        public bool QuestionChangeCheck(QuestionBehaviour qb)
        {
            if (qb.questionType == QuestionType.TrueFalse && qb.TFAnswer != true ||
                qb.questionType == QuestionType.TrueFalse && qb.TFAnswer == false)
                return false;
            else if (qb.questionType == QuestionType.FillInTheBlank && qb.FITBAnswers == null ||
                qb.questionType == QuestionType.FillInTheBlank && qb.FITBRequirment > 0)
                return false;
            else if (qb.questionType == QuestionType.MultipleChoice && qb.MCAnswer > -1 ||
                qb.questionType == QuestionType.MultipleChoice && qb.MCChoices == null)
                return false;
            else if (qb.questionType == QuestionType.None)
                return false;
            return true;
        }

        public void TestReview()
        {
            if (InReview == true)
            {
                for (int i = 0; i < QuestionSize; i++)
                {
                    if (Questions[i].questionType == QuestionType.TrueFalse)
                        TrueFalseReview(Questions[i]);
                    if (Questions[i].questionType == QuestionType.FillInTheBlank)
                        FillInTheBlankReview(Questions[i]);
                    if (Questions[i].questionType == QuestionType.MultipleChoice)
                        MultipleChoiceReview(Questions[i]);

                    TestScore += Questions[i].Score / QuestionSize;
                }
            }
            return;
        }

        public void TrueFalseReview(QuestionBehaviour q)
        {
            if (q.TFUserChoice == q.TFAnswer)
                q.Score = 1;    //  100 percent of the question is correct
            else
                q.Score = 0;    //  0 percent of the question is correct
        }

        public void FillInTheBlankReview(QuestionBehaviour q)
        {
            int count = 0;  //  Count for answers given by user that aren't blank or null

            for (int i = 0; i < q.FITBUserChoices.Length; i++)
            {
                if (q.FITBUserChoices[i] != null)
                    count++;
            }

            for (int j = 0; j < count; j++)
            {
                for (int k = 0; k < count; k++)
                {
                    if (q.FITBUserChoices[j] == q.FITBAnswers[k] && q.FITBUserChoices[j] != null)
                    {
                        q.Score += 1 / (float)q.FITBRequirment;    //  Score added is a percent based on the amount of answers required (ex: 1 / 4 = 0.25f)
                    }
                }
            }

            if (q.Score > 1)
                q.Score = 1;
        }

        public void MultipleChoiceReview(QuestionBehaviour q)
        {
            if (q.MCUserChoice == q.MCAnswer)
                q.Score = 1;    //  100 percent of the question is correct
            else
                q.Score = 0;    //  0 percent of the question is correct
        }
    }
}
