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

        public void MissingInfoPopUp(PopupForm puf, TestSettingsForm tsf, NewTestForm qf)
        {
            //  Popup warning text
            if (QuestionSize < 1)
            {
                puf.WarningTitle = "Caution!";
                puf.WarningText = "You have not met the minimum question requirment." +
                    " Please set an amount of questions greater than 1 before proceeding.";
            }
            else if (QuestionSize > 99)
            {
                puf.WarningTitle = "Caution!";
                puf.WarningText = "You have exceeded the maximum question limit." +
                    " Please set an amount of questions lower than 99 before proceeding.";
            }
            else if (MaxTime <= 0)
            {
                puf.WarningTitle = "Caution!";
                puf.WarningText = "You have not met the minimum time requirment. " +
                    "Please set the time limit to a number higher than 0 before proceeding.";
            }
            else if (TestTitle == null)
            {
                puf.WarningText = "Caution!";
                puf.WarningText = "You have not given the test a proper title. " +
                    "Please give a title for the test before proceeding.";

            }

            //  Popup window
            if (tsf != null)
            {
                puf.PrevForm = tsf;
                puf.Location = tsf.Location;
                puf.StartPosition = FormStartPosition.CenterScreen;
                tsf.Hide();
                puf.FormClosed += (s, args) => tsf.Close();
                puf.Show();
            }

            return;
        }

        public void OpenQuestionEditor(TestSettingsForm tsf)
        {
            TestPath = "Tests/" + TestTitle + ".txt";
            using (FileStream fs = File.Create(TestPath))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(
                    "[*TESTINFO*] \n \nTITLE = " + TestTitle +
                    "\nTIMELIMIT = " + MaxTime + "\nQUESTIONS = " +
                    QuestionSize + "\n \n");
                fs.Write(info, 0, info.Length);
            }

            var frm = new NewTestForm();
            frm.Location = tsf.Location;
            frm.StartPosition = FormStartPosition.Manual;
            tsf.Hide();
            frm.FormClosed += (s, args) => tsf.Close();
            frm.Show();
        }

        public void Exit(TestSettingsForm tsf, NewTestForm qf)
        {
            var frm = new Form1();

            if (qf != null && tsf != null)
            {
                tsf.Location = qf.Location;
                qf.Hide();
                tsf.FormClosed += (s, args) => qf.Close();
            }

            else if (tsf != null && qf == null)
            {
                frm.Location = tsf.Location;
                tsf.Hide();
                frm.FormClosed += (s, args) => tsf.Close();
            }

            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();

        }

    }
}
