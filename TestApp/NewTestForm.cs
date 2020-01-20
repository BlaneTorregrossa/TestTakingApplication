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
    public partial class NewTestForm : Form
    {
        public QuestionBehaviour QBInstance = new QuestionBehaviour();

        public NewTestForm()
        {
            InitializeComponent();
            QBInstance.questionType = QuestionType.None;
        }

        private void TrueFalseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.questionType = QuestionType.TrueFalse;
        }

        private void FillInTheBlankRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.questionType = QuestionType.FillInTheBlank;
        }

        private void MultipleChoiceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.questionType = QuestionType.MultipleChoice;
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
            
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
             frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
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
            if (QBInstance.QuestionNum == null)
                QBInstance.QuestionNum = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            QBInstance.Question = textBox1.Text;
        }
    }
}
