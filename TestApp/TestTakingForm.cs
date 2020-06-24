﻿using System;
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


        public TestTakingForm()
        {
            InitializeComponent();
        }

        private void TestTakingForm_Load(object sender, EventArgs e)

        {
            TrueFalseGroupBox.Enabled = false;
            FillInTheBlankGroupBox.Enabled = false;
            MultipleChoiceGroupBox.Enabled = false;
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            //  TODO:   Save chosen answers on each tick
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
                //  TODO:   Block out all buttons besides the submit button
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            CurrentQuestion = CurrentTestInformation.Questions[CurrentQuestion.QuestionNum + 1];
            UpdateTestInformation();
            RefreshAnswerElements();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            CurrentQuestion = CurrentTestInformation.Questions[CurrentQuestion.QuestionNum - 1];
            UpdateTestInformation();
            RefreshAnswerElements();
        }

        private void TrueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentQuestion.TFUserChoice = true;
            CurrentQuestion.Entered = true;
        }

        private void FalseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentQuestion.TFUserChoice = false;
            CurrentQuestion.Entered = true;
        }

        private void ARadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentQuestion.MCUserChoice = 0;
            CurrentQuestion.Entered = true;
        }

        private void BRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentQuestion.MCUserChoice = 1;
            CurrentQuestion.Entered = true;
        }

        private void CRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentQuestion.MCUserChoice = 2;
            CurrentQuestion.Entered = true;
        }

        private void DRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentQuestion.MCUserChoice = 3;
            CurrentQuestion.Entered = true;
        }

        private void FITBTextBox1_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[0] = FITBTextBox1.Text;
            CurrentQuestion.Entered = true;
        }

        private void FITBTextBox2_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[1] = FITBTextBox2.Text;
            CurrentQuestion.Entered = true;
        }

        private void FITBTextBox3_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[2] = FITBTextBox3.Text;
            CurrentQuestion.Entered = true;
        }

        private void FITBTextBox4_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[3] = FITBTextBox4.Text;
            CurrentQuestion.Entered = true;
        }

        private void FITBTextBox5_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[4] = FITBTextBox5.Text;
            CurrentQuestion.Entered = true;
        }

        private void FITBTextBox6_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[5] = FITBTextBox6.Text;
            CurrentQuestion.Entered = true;
        }

        private void FITBTextBox7_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[6] = FITBTextBox7.Text;
            CurrentQuestion.Entered = true;
        }

        private void FITBTextBox8_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[7] = FITBTextBox8.Text;
            CurrentQuestion.Entered = true;
        }

        private void FITBTextBox9_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[8] = FITBTextBox9.Text;
            CurrentQuestion.Entered = true;
        }

        private void FITBTextBox10_TextChanged(object sender, EventArgs e)
        {
            CurrentQuestion.FITBUserChoices[9] = FITBTextBox10.Text;
            CurrentQuestion.Entered = true;
        }

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

            //  Stopped here
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
    }
}
