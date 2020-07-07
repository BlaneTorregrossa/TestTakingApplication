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
    public partial class TestTakingForm : Form
    {
        public TestBehaviour CurrentTestInformation;
        private QuestionBehaviour CurrentQuestion;
        private FileReader FileReaderInstance;
        private int timeLeft;
        private bool elementsCheck;

        public TestTakingForm()
        {
            InitializeComponent();
        }

        //  Setting what is enabled and disabled on load + 
        //  Setting current question to be the first in array +
        //  Starting timer
        private void TestTakingForm_Load(object sender, EventArgs e)
        {
            this.Text = CurrentTestInformation.TestTitle;
            CurrentTestInformation.InReview = false;
            TrueFalseGroupBox.Enabled = false;
            FillInTheBlankGroupBox.Enabled = false;
            MultipleChoiceGroupBox.Enabled = false;
            elementsCheck = false;
            FileReaderInstance = new FileReader();
            CurrentTestInformation = FileReaderInstance.SaveInformation(CurrentTestInformation.TestPath);
            RemainingTimeLabel.Text = "Time: Hours: Minutes: Seconds:";
            timeLeft = CurrentTestInformation.MaxTime;
            Timer.Start();
            CurrentQuestion = CurrentTestInformation.Questions[0];
        }

        private void RemainingTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void QuestionNumLabel_Click(object sender, EventArgs e)
        {

        }

        //  Timer updates and divides time by hours, minutes and seconds + Updates form on each tick
        //  If time remaining is <= 0 then disable everything except for the submit button
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                int hours, min, sec;

                timeLeft = timeLeft - 1;
                sec = timeLeft % 60;
                hours = timeLeft / 60 / 60;
                min = (timeLeft - ((hours * 60 * 60) + sec)) / 60;
                RemainingTimeLabel.Text = "Time: Hours: " + hours.ToString() +
                    " Minutes: " + min.ToString() + " Seconds: " + sec.ToString();

                UpdateTestInformation();
            }
            else
            {
                Timer.Stop();
                NextButton.Enabled = false;
                PreviousButton.Enabled = false;
                TrueFalseGroupBox.Enabled = false;
                MultipleChoiceGroupBox.Enabled = false;
                FillInTheBlankGroupBox.Enabled = false;
            }
        }

        //  Change current question to the next question and update the form
        private void NextButton_Click(object sender, EventArgs e)
        {
            CurrentQuestion = CurrentTestInformation.Questions[CurrentQuestion.QuestionNum + 1];
            elementsCheck = false;
            UpdateTestInformation();
            RefreshAnswerElements();
        }

        //  Change current question to the previous question and update the form
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            CurrentQuestion = CurrentTestInformation.Questions[CurrentQuestion.QuestionNum - 1];
            elementsCheck = false;
            UpdateTestInformation();
            RefreshAnswerElements();
        }

        //  Submit the test to be graded and then open the review form for the test
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            CurrentTestInformation.InReview = true;
            CurrentTestInformation.TestReview();
            this.Hide();
            var frm = new TestReviewForm
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual,
                CurrentTest = CurrentTestInformation
            };
            frm.ShowDialog();
            frm.Activate();
            this.Close();
        }

        //  Select true for true false question
        private void TrueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentQuestion.TFUserChoice = true;
            CurrentQuestion.Entered = true;
        }

        //  Select false for true false question
        private void FalseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentQuestion.TFUserChoice = false;
            CurrentQuestion.Entered = true;
        }

        //  Select A for Multiple choice question
        private void ARadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentQuestion.MCUserChoice = 0;
            CurrentQuestion.Entered = true;
        }

        //  Select B for Multiple choice question
        private void BRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentQuestion.MCUserChoice = 1;
            CurrentQuestion.Entered = true;
        }

        //  Select C for Multiple choice question
        private void CRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentQuestion.MCUserChoice = 2;
            CurrentQuestion.Entered = true;
        }

        //  Select D for Multiple choice question
        private void DRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentQuestion.MCUserChoice = 3;
            CurrentQuestion.Entered = true;
        }

        //  One of ten answers for Fill in the blank questions
         private void FITBTextBox1_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[0] = FITBTextBox1.Text;
            CurrentQuestion.Entered = true;
        }

        //  One of ten answers for Fill in the blank questions
        private void FITBTextBox2_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[1] = FITBTextBox2.Text;
            CurrentQuestion.Entered = true;
        }

        //  One of ten answers for Fill in the blank questions
        private void FITBTextBox3_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[2] = FITBTextBox3.Text;
            CurrentQuestion.Entered = true;
        }

        //  One of ten answers for Fill in the blank questions
        private void FITBTextBox4_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[3] = FITBTextBox4.Text;
            CurrentQuestion.Entered = true;
        }

        //  One of ten answers for Fill in the blank questions
        private void FITBTextBox5_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[4] = FITBTextBox5.Text;
            CurrentQuestion.Entered = true;
        }

        //  One of ten answers for Fill in the blank questions
        private void FITBTextBox6_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[5] = FITBTextBox6.Text;
            CurrentQuestion.Entered = true;
        }

        //  One of ten answers for Fill in the blank questions
        private void FITBTextBox7_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[6] = FITBTextBox7.Text;
            CurrentQuestion.Entered = true;
        }

        //  One of ten answers for Fill in the blank questions
        private void FITBTextBox8_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[7] = FITBTextBox8.Text;
            CurrentQuestion.Entered = true;
        }

        //  One of ten answers for Fill in the blank questions
        private void FITBTextBox9_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[8] = FITBTextBox9.Text;
            CurrentQuestion.Entered = true;
        }

        //  One of ten answers for Fill in the blank questions
        private void FITBTextBox10_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[9] = FITBTextBox10.Text;
            CurrentQuestion.Entered = true;
        }

        //  Updates form to match current question
        private void RefreshAnswerElements()
        {
            if (CurrentQuestion.Entered == false &&
                CurrentQuestion.questionType == QuestionType.TrueFalse ||
                CurrentQuestion.questionType != QuestionType.TrueFalse)
            {
                TrueRadioButton.Checked = false;
                FalseRadioButton.Checked = false;
            }
            else if (CurrentQuestion.TFUserChoice == true &&
                CurrentQuestion.questionType == QuestionType.TrueFalse)
            {
                TrueRadioButton.Checked = true;
                FalseRadioButton.Checked = false;
            }
            else if (CurrentQuestion.TFUserChoice == false &&
                CurrentQuestion.questionType == QuestionType.TrueFalse)
            {
                TrueRadioButton.Checked = false;
                FalseRadioButton.Checked = true;
            }

            if (CurrentQuestion.Entered == false &&
                CurrentQuestion.questionType == QuestionType.MultipleChoice ||
                CurrentQuestion.questionType != QuestionType.MultipleChoice)
            {
                ARadioButton.Checked = false;
                BRadioButton.Checked = false;
                CRadioButton.Checked = false;
                DRadioButton.Checked = false;
            }
            else if (CurrentQuestion.MCUserChoice == 0 &&
                CurrentQuestion.questionType == QuestionType.MultipleChoice)
            {
                ARadioButton.Checked = true;
                BRadioButton.Checked = false;
                CRadioButton.Checked = false;
                DRadioButton.Checked = false;
            }
            else if (CurrentQuestion.MCUserChoice == 1 &&
                CurrentQuestion.questionType == QuestionType.MultipleChoice)
            {
                ARadioButton.Checked = false;
                BRadioButton.Checked = true;
                CRadioButton.Checked = false;
                DRadioButton.Checked = false;
            }
            else if (CurrentQuestion.MCUserChoice == 2 &&
                CurrentQuestion.questionType == QuestionType.MultipleChoice)
            {
                ARadioButton.Checked = false;
                BRadioButton.Checked = false;
                CRadioButton.Checked = true;
                DRadioButton.Checked = false;
            }
            else if (CurrentQuestion.MCUserChoice == 3 &&
                CurrentQuestion.questionType == QuestionType.MultipleChoice)
            {
                ARadioButton.Checked = false;
                BRadioButton.Checked = false;
                CRadioButton.Checked = false;
                DRadioButton.Checked = true;
            }

            if (CurrentQuestion.Entered == false && CurrentQuestion.questionType == QuestionType.FillInTheBlank ||
                CurrentQuestion.questionType != QuestionType.FillInTheBlank)
            {
                FITBTextBox1.Text = "";
                FITBTextBox2.Text = "";
                FITBTextBox3.Text = "";
                FITBTextBox4.Text = "";
                FITBTextBox5.Text = "";
                FITBTextBox6.Text = "";
                FITBTextBox7.Text = "";
                FITBTextBox8.Text = "";
                FITBTextBox9.Text = "";
                FITBTextBox10.Text = "";
            }
            else if (CurrentQuestion.Entered == true &&
                CurrentQuestion.questionType == QuestionType.FillInTheBlank &&
                CurrentQuestion.FITBUserChoices != null)
            {
                FITBTextBox1.Text = CurrentQuestion.FITBUserChoices[0];
                FITBTextBox2.Text = CurrentQuestion.FITBUserChoices[1];
                FITBTextBox3.Text = CurrentQuestion.FITBUserChoices[2];
                FITBTextBox4.Text = CurrentQuestion.FITBUserChoices[3];
                FITBTextBox5.Text = CurrentQuestion.FITBUserChoices[4];
                FITBTextBox6.Text = CurrentQuestion.FITBUserChoices[5];
                FITBTextBox7.Text = CurrentQuestion.FITBUserChoices[6];
                FITBTextBox8.Text = CurrentQuestion.FITBUserChoices[7];
                FITBTextBox9.Text = CurrentQuestion.FITBUserChoices[8];
                FITBTextBox10.Text = CurrentQuestion.FITBUserChoices[9];
            }
        }

        //  Update test information based on current question
        private void UpdateTestInformation()
        {
            CurrentTestInformation.Questions[CurrentQuestion.QuestionNum].TFAnswer = CurrentQuestion.TFAnswer;
            CurrentTestInformation.Questions[CurrentQuestion.QuestionNum].FITBAnswers = CurrentQuestion.FITBAnswers;
            CurrentTestInformation.Questions[CurrentQuestion.QuestionNum].MCAnswer = CurrentQuestion.MCAnswer;
            CurrentTestInformation.Questions[CurrentQuestion.QuestionNum].TFUserChoice = CurrentQuestion.TFUserChoice;
            CurrentTestInformation.Questions[CurrentQuestion.QuestionNum].FITBUserChoices = CurrentQuestion.FITBUserChoices;
            CurrentTestInformation.Questions[CurrentQuestion.QuestionNum].MCUserChoice = CurrentQuestion.MCUserChoice;


            if (timeLeft > 0)
            {
                if (CurrentQuestion.questionType == QuestionType.TrueFalse)
                {
                    TrueFalseGroupBox.Enabled = true;
                    FillInTheBlankGroupBox.Enabled = false;
                    MultipleChoiceGroupBox.Enabled = false;
                }
                else if (CurrentQuestion.questionType == QuestionType.FillInTheBlank)
                {
                    TrueFalseGroupBox.Enabled = false;
                    FillInTheBlankGroupBox.Enabled = true;
                    MultipleChoiceGroupBox.Enabled = false;

                    if (elementsCheck == false)
                    {
                        FITBTextBox1.Enabled = false;
                        FITBTextBox2.Enabled = false;
                        FITBTextBox3.Enabled = false;
                        FITBTextBox4.Enabled = false;
                        FITBTextBox5.Enabled = false;
                        FITBTextBox6.Enabled = false;
                        FITBTextBox7.Enabled = false;
                        FITBTextBox8.Enabled = false;
                        FITBTextBox9.Enabled = false;
                        FITBTextBox10.Enabled = false;

                        if (CurrentQuestion.FITBRequirment >= 1)
                            FITBTextBox1.Enabled = true;
                        if (CurrentQuestion.FITBRequirment >= 2)
                            FITBTextBox2.Enabled = true;
                        if (CurrentQuestion.FITBRequirment >= 3)
                            FITBTextBox3.Enabled = true;
                        if (CurrentQuestion.FITBRequirment >= 4)
                            FITBTextBox4.Enabled = true;
                        if (CurrentQuestion.FITBRequirment >= 5)
                            FITBTextBox5.Enabled = true;
                        if (CurrentQuestion.FITBRequirment >= 6)
                            FITBTextBox6.Enabled = true;
                        if (CurrentQuestion.FITBRequirment >= 7)
                            FITBTextBox7.Enabled = true;
                        if (CurrentQuestion.FITBRequirment >= 8)
                            FITBTextBox8.Enabled = true;
                        if (CurrentQuestion.FITBRequirment >= 9)
                            FITBTextBox9.Enabled = true;
                        if (CurrentQuestion.FITBRequirment == 10)
                            FITBTextBox10.Enabled = true;

                        elementsCheck = true;
                    }

                }
                else if (CurrentQuestion.questionType == QuestionType.MultipleChoice)
                {
                    TrueFalseGroupBox.Enabled = false;
                    FillInTheBlankGroupBox.Enabled = false;
                    MultipleChoiceGroupBox.Enabled = true;
                    ARadioButton.Text = "A. " + CurrentQuestion.MCChoices[0];
                    BRadioButton.Text = "B. " + CurrentQuestion.MCChoices[1];
                    CRadioButton.Text = "C. " + CurrentQuestion.MCChoices[2];
                    DRadioButton.Text = "D. " + CurrentQuestion.MCChoices[3];
                }

                if (CurrentQuestion.QuestionNum <= 0)
                {
                    NextButton.Enabled = true;
                    PreviousButton.Enabled = false;
                }
                else if (CurrentQuestion.QuestionNum >= CurrentTestInformation.QuestionSize - 1)
                {
                    NextButton.Enabled = false;
                    PreviousButton.Enabled = true;
                }
                else
                {
                    NextButton.Enabled = true;
                    PreviousButton.Enabled = true;
                }

                var displayNum = CurrentQuestion.QuestionNum + 1;

                QuestionNumLabel.Text = "Question #" + displayNum.ToString();
                QuestionTextBox.Text = CurrentQuestion.QuestionText;
            }
        }

        private void QuestionTestInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
