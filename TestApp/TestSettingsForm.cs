using System;
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
            //  If Missing required information open a popup window
            if (TBInstance.QuestionSize < 1 || TBInstance.QuestionSize > 99 ||
                TBInstance.MaxTime < 0 || TBInstance.TestTitle == null)
            {
                var frm = new PopupForm();
                TBInstance.MissingInfoPopUp(frm, this, null);
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
    }
}
