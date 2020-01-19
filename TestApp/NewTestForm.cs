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

        }

        private void QuestionTwoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuestionThreeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuestionFourTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuestionSixTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuestionEightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuestionNineTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuestionTenTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChoiceATextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChoiceBTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChoiceCTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChoiceDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonMultipleChoiceA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonMultipleChoiceB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonMultipleChoiceC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonMultipleChoiceD_CheckedChanged(object sender, EventArgs e)
        {

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

        private void ConsoleReadDebugButton_Click(object sender, EventArgs e)
        {

        }

        private void NewTestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
