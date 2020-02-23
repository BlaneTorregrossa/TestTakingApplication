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
    public partial class NewTestForm : Form
    {
        public QuestionBehaviour QBInstance = new QuestionBehaviour();
        public TestBehaviour TBInstance;

        public NewTestForm()
        {
            InitializeComponent();
        }

        private void TrueFalseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.questionType = QuestionType.TrueFalse;
            TrueFalseGroupBox.Enabled = true;
            FillInTheBlankAnswerGroupBox.Enabled = false;
            MultipleChoiceGroupBox.Enabled = false;
        }

        private void FillInTheBlankRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.questionType = QuestionType.FillInTheBlank;
            TrueFalseGroupBox.Enabled = false;
            FillInTheBlankAnswerGroupBox.Enabled = true;
            MultipleChoiceGroupBox.Enabled = false;
        }

        private void MultipleChoiceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.questionType = QuestionType.MultipleChoice;
            TrueFalseGroupBox.Enabled = false;
            FillInTheBlankAnswerGroupBox.Enabled = false;
            MultipleChoiceGroupBox.Enabled = true;
        }

        private void TrueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.TFAnswer = true;
        }

        private void FalseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.TFAnswer = false;
        }

        private void QuestionOneTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.FITBAnswers[0] = QuestionOneTextBox.Text;
        }

        private void QuestionTwoTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.FITBAnswers[1] = QuestionTwoTextBox.Text;
        }

        private void QuestionThreeTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.FITBAnswers[2] = QuestionThreeTextBox.Text;
        }

        private void QuestionFourTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.FITBAnswers[3] = QuestionFourTextBox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            QBInstance.FITBAnswers[4] = textBox2.Text;
        }

        private void QuestionSixTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.FITBAnswers[5] = QuestionSixTextBox.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            QBInstance.FITBAnswers[6] = textBox3.Text;
        }

        private void QuestionEightTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.FITBAnswers[7] = QuestionEightTextBox.Text;
        }

        private void QuestionNineTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.FITBAnswers[8] = QuestionNineTextBox.Text;
        }

        private void QuestionTenTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.FITBAnswers[9] = QuestionTenTextBox.Text;
        }

        private void ChoiceATextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.MCChoices[0] = ChoiceATextBox.Text;
        }

        private void ChoiceBTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.MCChoices[1] = ChoiceBTextBox.Text;
        }

        private void ChoiceCTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.MCChoices[2] = ChoiceCTextBox.Text;
        }

        private void ChoiceDTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.MCChoices[3] = ChoiceDTextBox.Text;
        }

        private void RadioButtonMultipleChoiceA_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.MCAnswer = 0;
        }

        private void RadioButtonMultipleChoiceB_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.MCAnswer = 1;
        }

        private void RadioButtonMultipleChoiceC_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.MCAnswer = 2;
        }

        private void RadioButtonMultipleChoiceD_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.MCAnswer = 3;
        }

        private void QuestionTypeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void TrueFalseGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void FillInTheBlankAnswerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void MultipleChoiceGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void AnotherQuestionButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                string title = "Caution!";
                string text = "Missing question in textbox for question. Please fill this textbox" +
                    "before continuing!";
                PopupForm frm = new PopupForm();
                QBInstance.MissingInfoPopUp(frm, this, title, text, false);
            }
            else if (QBInstance.questionType == QuestionType.TrueFalse &&
                TrueRadioButton.Checked == false &&
                FalseRadioButton.Checked == false)
            {
                string title = "Caution!";
                string text = "Missing answer for given True/False question. Please give an answer" +
                    " before continuing.";
                PopupForm frm = new PopupForm();
                QBInstance.MissingInfoPopUp(frm, this, title, text, false);
            }
            else if (QBInstance.questionType == QuestionType.None)
            {
                string title = "Caution!";
                string text = "Missing given Question type for question. Please select the question " +
                    "type before continuing.";
                PopupForm frm = new PopupForm();
                QBInstance.MissingInfoPopUp(frm, this, title, text, false);
            }
            else if (QBInstance.questionType == QuestionType.MultipleChoice &&
                RadioButtonMultipleChoiceA.Checked == false &&
                RadioButtonMultipleChoiceB.Checked == false &&
                RadioButtonMultipleChoiceC.Checked == false &&
                RadioButtonMultipleChoiceD.Checked == false)
            {
                string title = "Caution!";
                string text = "Missing given anwser for multiple choice question. Please select the " +
                    "question's asnwer before continuing.";
                PopupForm frm = new PopupForm();
                QBInstance.MissingInfoPopUp(frm, this, title, text, false);
            }

            QBInstance.CreateQuestion(TBInstance.QuestionSize);
            QBInstance.QuestionNum++;
            textBox1.Text = null;
            TrueFalseRadioButton.Checked = false;
            FillInTheBlankRadioButton.Checked = false;
            MultipleChoiceRadioButton.Checked = false;
            TrueRadioButton.Checked = false;
            FalseRadioButton.Checked = false;
            AvalibleAnswersNumericUpDown.Value = 1;
            AnswersNeededNumericUpDown.Value = 1;
            QuestionOneTextBox.Text = null;
            QuestionTwoTextBox.Text = null;
            QuestionThreeTextBox.Text = null;
            QuestionFourTextBox.Text = null;
            textBox2.Text = null;
            QuestionSixTextBox.Text = null;
            textBox3.Text = null;
            QuestionEightTextBox.Text = null;
            QuestionNineTextBox.Text = null;
            QuestionTenTextBox.Text = null;
            ChoiceATextBox.Text = null;
            ChoiceBTextBox.Text = null;
            ChoiceCTextBox.Text = null;
            ChoiceDTextBox.Text = null;
            RadioButtonMultipleChoiceA.Checked = false;
            RadioButtonMultipleChoiceB.Checked = false;
            RadioButtonMultipleChoiceC.Checked = false;
            RadioButtonMultipleChoiceD.Checked = false;

            if (QBInstance.QuestionNum >= TBInstance.QuestionSize)
            {
                AnotherQuestionButton.Enabled = false;
                textBox1.Enabled = false;
                QuestionTypeGroupBox.Enabled = false;
                TrueFalseGroupBox.Enabled = false;
                FillInTheBlankAnswerGroupBox.Enabled = false;
                MultipleChoiceGroupBox.Enabled = false;
            }

        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            this.Hide();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.ShowDialog();
            frm.Activate();
            this.Close();
        }

        private void AvalibleAnswersNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (AvalibleAnswersNumericUpDown.Value < 1)
                AvalibleAnswersNumericUpDown.Value = 1;
            else if (AvalibleAnswersNumericUpDown.Value > 10)
                AvalibleAnswersNumericUpDown.Value = 10;

            QBInstance.AnswersAvalible = Convert.ToInt32(AvalibleAnswersNumericUpDown.Value);
        }

        private void AnswersNeededNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (AnswersNeededNumericUpDown.Value < 0)
                AnswersNeededNumericUpDown.Value = 0;
            else if (AnswersNeededNumericUpDown.Value > AvalibleAnswersNumericUpDown.Value)
                AnswersNeededNumericUpDown.Value = AvalibleAnswersNumericUpDown.Value;

            QBInstance.FITBRequirment = Convert.ToInt32(AnswersNeededNumericUpDown.Value);
        }

        private void NewTestForm_Load(object sender, EventArgs e)
        {
            this.Tag = "Question";
            TrueFalseGroupBox.Enabled = false;
            FillInTheBlankAnswerGroupBox.Enabled = false;
            MultipleChoiceGroupBox.Enabled = false;

            //  Cause Popup to inform that the file has not encountered required information
            if (QBInstance.CheckTestReq() == false)
            {
                string Title = "Caution!";
                string Text = "Missing required information in test file being used. " +
                    "Please check the file to see what is missing.";
                PopupForm frm = new PopupForm();
                QBInstance.MissingInfoPopUp(frm, this, Title, Text, true);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            QBInstance.QuestionText = textBox1.Text;
        }
    }
}
