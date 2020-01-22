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
            if (TBInstance.QuestionSize < 1 || TBInstance.QuestionSize > 99 ||
                TBInstance.MaxTime < 0 || TBInstance.TestTitle == null)
            {
                var frm = new PopupForm();
                TBInstance.MissingInfoPopUp(frm, this, null);
            }

            else
                TBInstance.OpenQuestionEditor(this);
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
