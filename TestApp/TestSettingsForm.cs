using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{

    public partial class TestSettingsForm : Form
    {
        public TestBehaviour TBInstance = new TestBehaviour();

        public TestSettingsForm()
        {
            InitializeComponent();
        }

        private void TestTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            TBInstance.TestTitle = TestTitleTextBox.Text;
        }

        private void TimeLimitNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TBInstance.MaxTime = Convert.ToInt32(TimeLimitNumericUpDown.Value);
        }

        private void QuestionsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TBInstance.QuestionSize = Convert.ToInt32(QuestionsNumericUpDown.Value);
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (TBInstance.QuestionSize < 1)
            {
                var frm = new PopupForm();
                frm.WarningTitle = "Caution!";
                frm.WarningText = "You have not met the minimum question requirment. Please set amount of questions before proceeding.";
                frm.PrevForm = this;
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                this.Hide();
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
            }
            else if (TBInstance.QuestionSize > 99)
            {
                var frm = new PopupForm();
                frm.WarningTitle = "Caution!";
                frm.WarningText = "You have exceeded the maximum question limit. Please set a lower amount of questions before proceeding.";
                frm.PrevForm = this;
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                this.Hide();
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
            }

            else if (TBInstance.RemainingTime < 0)
            {
                var frm = new PopupForm();
                frm.WarningTitle = "Caution!";
                frm.WarningText = "You have not met the minimum time requirment. Please set the time limit before proceeding.";
                frm.PrevForm = this;
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                this.Hide();
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
            }

            else if (TBInstance.TestTitle == null)
            {
                var frm = new PopupForm();
                frm.WarningTitle = "Caution!";
                frm.WarningText = "You have not given the test a proper title. Please give a title for the test before proceeding.";
                frm.PrevForm = this;
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                this.Hide();
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
            }

            else
            {
                TBInstance.TestPath = "Tests/" + TBInstance.TestTitle + ".txt";
                using (FileStream fs = File.Create(TBInstance.TestPath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(
                        "[*TESTINFO*] \n \nTITLE = " + TBInstance.TestTitle +
                        "\nTIMELIMIT = " + TBInstance.MaxTime + "\nQUESTIONS = " +
                        TBInstance.QuestionSize + "\n \n");
                    fs.Write(info, 0, info.Length);
                }
                var frm = new NewTestForm();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                this.Hide();
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
