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
    public partial class TestReviewForm : Form
    {
        public TestBehaviour CurrentTest;
        public QuestionBehaviour CurrentQuestion;

        public TestReviewForm()
        {
            InitializeComponent();
        }

        //  Loading of test review form and showing score and related information for the first question of the test being graded
        private void TestReviewForm_Load(object sender, EventArgs e)
        {
            this.Text = "Review";
            CurrentQuestion = CurrentTest.Questions[0];
            UpdateInformation();
        }

        //  Move from current question to the next one
        private void NextButton_Click(object sender, EventArgs e)
        {
            CorrectAnswerTextBox.Text = "";
            GivenAnswerTextBox.Text = "";
            CurrentQuestion = CurrentTest.Questions[CurrentQuestion.QuestionNum + 1];
            UpdateInformation();
        }

        //  Move from current question to the previous one
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            CorrectAnswerTextBox.Text = "";
            GivenAnswerTextBox.Text = "";
            CurrentQuestion = CurrentTest.Questions[CurrentQuestion.QuestionNum - 1];
            UpdateInformation();
        }

        //  Return to the starting form
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new Form1
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.ShowDialog();
            frm.Activate();
            this.Close();
        }

        //  Update form to present information of current selected question
        private void UpdateInformation()
        {
            QuestionNumberLabel.Text = "Question # " + (CurrentQuestion.QuestionNum + 1);
            QuestionTextBox.Text = CurrentQuestion.QuestionText;
            QuestionScoreTextBox.Text = CurrentQuestion.Score.ToString();
            TestScoreTextBox.Text = CurrentTest.TestScore.ToString();

            if (CurrentQuestion.questionType == QuestionType.TrueFalse)
            {
                CorrectAnswerTextBox.Text = CurrentQuestion.TFAnswer.ToString();
                GivenAnswerTextBox.Text = CurrentQuestion.TFUserChoice.ToString();
            }

            else if (CurrentQuestion.questionType == QuestionType.FillInTheBlank)
            {
                for (int i = 0; i < CurrentQuestion.FITBAnswers.Length; i++)
                    CorrectAnswerTextBox.Text += CurrentQuestion.FITBAnswers[i] + " || ";

                for (int j = 0; j < CurrentQuestion.FITBUserChoices.Length; j++)
                    GivenAnswerTextBox.Text += CurrentQuestion.FITBUserChoices[j] + " || ";
            }

            else if (CurrentQuestion.questionType == QuestionType.MultipleChoice)
            {
                CorrectAnswerTextBox.Text = CurrentQuestion.MCChoices[CurrentQuestion.MCAnswer];
                if (CurrentQuestion.MCUserChoice < 0)
                    GivenAnswerTextBox.Text = "No answer given.";
                else
                    GivenAnswerTextBox.Text = CurrentQuestion.MCChoices[CurrentQuestion.MCUserChoice];
            }

            if (CurrentQuestion.QuestionNum <= 0)
            {
                NextButton.Enabled = true;
                PreviousButton.Enabled = false;
            }
            else if (CurrentQuestion.QuestionNum >= CurrentTest.QuestionSize - 1)
            {
                NextButton.Enabled = false;
                PreviousButton.Enabled = true;
            }
            else
            {
                NextButton.Enabled = true;
                PreviousButton.Enabled = true;
            }
        }
    }
}
