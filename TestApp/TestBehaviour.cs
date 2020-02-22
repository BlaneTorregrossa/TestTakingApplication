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

        public void MissingInfoPopUp(PopupForm puf, TestSettingsForm tsf, string title, string text)
        {
            //  Popup window
            if (tsf != null)
            {
                tsf.Hide();
                puf.PrevForm = tsf;
                puf.Location = tsf.Location;
                puf.StartPosition = FormStartPosition.CenterScreen;
                puf.WarningTitle = title;
                puf.WarningText = text;
                puf.ShowDialog();
                puf.Activate();
                tsf.Close();
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
                    "\nTIMELIMIT = " + MaxTime + "\nMAXQUESTIONS = " +
                    QuestionSize + "\n \n");
                fs.Write(info, 0, info.Length);
            }

            tsf.Hide();
            var frm = new NewTestForm();
            frm.QBInstance.TestPath = TestPath;
            frm.TBInstance = this;
            frm.Location = tsf.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.ShowDialog();
            frm.Activate();
            frm.Close();
        }

        public void Exit(TestSettingsForm tsf, NewTestForm qf)
        {
            var frm = new Form1();

            frm.StartPosition = FormStartPosition.Manual;
            frm.Activate();
            frm.ShowDialog();

            if (qf != null && tsf == null)
            {
                qf.Hide();
                frm.Location = qf.Location;
                qf.Close();
            }

            else if (tsf != null && qf == null)
            {
                tsf.Hide();
                frm.Location = tsf.Location;
                tsf.Close();
            }
        }

    }
}
