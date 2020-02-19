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
            //  This is really messy    *
            //  If Missing required information open a popup window
            if (TBInstance.QuestionSize < 1)
            {
                string Title = "Caution!";
                string Text = "You have not met the minimum question requirment." +
                    " Please set an amount of questions greater than 1 before proceeding.";
                var frm = new PopupForm();
                TBInstance.MissingInfoPopUp(frm, this, Title, Text);
            }
            else if (TBInstance.QuestionSize > 99)
            {
                string Title = "Caution!";
                string Text = "You have exceeded the maximum question limit." +
                    " Please set an amount of questions lower than 99 before proceeding.";
                var frm = new PopupForm();
                TBInstance.MissingInfoPopUp(frm, this, Title, Text);
            }
            else if (TBInstance.MaxTime < 0)
            {
                string Title = "Caution!";
                string Text = "You have not met the minimum time requirment. " +
                    "Please set the time limit to a number higher than 0 before proceeding.";
                var frm = new PopupForm();
                TBInstance.MissingInfoPopUp(frm, this, Title, Text);
            }
            else if (TBInstance.TestTitle == null)
            {
                string Title = "Caution!";
                string Text = "You have not given the test a proper title. " +
                    "Please give a title for the test before proceeding.";
                var frm = new PopupForm();
                TBInstance.MissingInfoPopUp(frm, this, Title, Text);
            }
            else if (TBInstance.TestTitle.Contains((char)92) ||
                TBInstance.TestTitle.Contains((char)47) ||
                TBInstance.TestTitle.Contains((char)58) ||
                TBInstance.TestTitle.Contains((char)42) ||
                TBInstance.TestTitle.Contains((char)63) ||
                TBInstance.TestTitle.Contains((char)34) ||
                TBInstance.TestTitle.Contains((char)58) ||
                TBInstance.TestTitle.Contains((char)60) ||
                TBInstance.TestTitle.Contains((char)62) ||
                TBInstance.TestTitle.Contains((char)124))
            {
                string Title = "Caution!";
                string Text = "Your test title contains a character that" +
                    " does not work for file names. Please remove any of the " +
                    "following characters if present:" + (char)92 + " / : * ? " +
                    (char)34 + " < > |";
                var frm = new PopupForm();
                TBInstance.MissingInfoPopUp(frm, this, Title, Text);
            }

            //  If there is no missing required information 
            //  then continue to the question creation window
            else
                TBInstance.OpenQuestionEditor(this);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //  Exit back to previous window
            TBInstance.Exit(this, null);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
