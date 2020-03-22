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
            if (QuestionOneTextBox.Text != "")
                QBInstance.FITBAnswers[0] = QuestionOneTextBox.Text;
        }

        private void QuestionTwoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionTwoTextBox.Text != "")
                QBInstance.FITBAnswers[1] = QuestionTwoTextBox.Text;
        }

        private void QuestionThreeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionThreeTextBox.Text != "")
                QBInstance.FITBAnswers[2] = QuestionThreeTextBox.Text;
        }

        private void QuestionFourTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionFourTextBox.Text != "")
                QBInstance.FITBAnswers[3] = QuestionFourTextBox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                QBInstance.FITBAnswers[4] = textBox2.Text;
        }

        private void QuestionSixTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionSixTextBox.Text != "")
                QBInstance.FITBAnswers[5] = QuestionSixTextBox.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
                QBInstance.FITBAnswers[6] = textBox3.Text;
        }

        private void QuestionEightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionEightTextBox.Text != "")
                QBInstance.FITBAnswers[7] = QuestionEightTextBox.Text;
        }

        private void QuestionNineTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionNineTextBox.Text != "")
                QBInstance.FITBAnswers[8] = QuestionNineTextBox.Text;
        }

        private void QuestionTenTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionTenTextBox.Text != "")
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

        private void TrueFalseGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void FillInTheBlankAnswerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void MultipleChoiceGroupBox_Enter(object sender, EventArgs e)
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

            if (QBInstance.FITBRequirment != 1)
                QBInstance.FITBRequirment = Convert.ToInt32(AnswersNeededNumericUpDown.Value);
        }

        private void NewTestForm_Load(object sender, EventArgs e)
        {
            this.Tag = "Question";
            QuestionNumberNumericUpDown.Value = 1;
            QuestionTextTextBox.Text = null;
            FinishButton.Enabled = false;
            TrueFalseGroupBox.Enabled = false;
            FillInTheBlankAnswerGroupBox.Enabled = false;
            MultipleChoiceGroupBox.Enabled = false;
        }

        private void QuestionNumberNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (QuestionNumberNumericUpDown.Value > TBInstance.QuestionSize)
                QuestionNumberNumericUpDown.Value--;
            if (QuestionNumberNumericUpDown.Value <= 0)
                QuestionNumberNumericUpDown.Value = 1;

            QBInstance.QuestionNum = Decimal.ToInt32(QuestionNumberNumericUpDown.Value) - 1;

            QuestionTextTextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].QuestionText;
            QuestionTypeDomainUpDown.Text = TBInstance.Questions[QBInstance.QuestionNum].questionType.ToString();
            if (TBInstance.Questions[QBInstance.QuestionNum].TFAnswer == true)
                TrueRadioButton.Checked = true;
            else if (TBInstance.Questions[QBInstance.QuestionNum].TFAnswer == false)
                TrueRadioButton.Checked = true;
            if (TBInstance.Questions[QBInstance.QuestionNum].AnswersAvalible < 1)
                TBInstance.Questions[QBInstance.QuestionNum].AnswersAvalible = 1;
            AvalibleAnswersNumericUpDown.Value = TBInstance.Questions[QBInstance.QuestionNum].AnswersAvalible;
            if (TBInstance.Questions[QBInstance.QuestionNum].FITBRequirment < 1)
                TBInstance.Questions[QBInstance.QuestionNum].FITBRequirment = 1;
            AnswersNeededNumericUpDown.Value = TBInstance.Questions[QBInstance.QuestionNum].FITBRequirment;
            QuestionOneTextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].FITBAnswers[0];
            QuestionTwoTextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].FITBAnswers[1];
            QuestionThreeTextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].FITBAnswers[2];
            QuestionFourTextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].FITBAnswers[3];
            textBox2.Text = TBInstance.Questions[QBInstance.QuestionNum].FITBAnswers[4];
            QuestionSixTextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].FITBAnswers[5];
            textBox3.Text = TBInstance.Questions[QBInstance.QuestionNum].FITBAnswers[6];
            QuestionEightTextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].FITBAnswers[7];
            QuestionNineTextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].FITBAnswers[8];
            QuestionTenTextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].FITBAnswers[9];
            ChoiceATextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].MCChoices[0];
            ChoiceBTextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].MCChoices[1];
            ChoiceCTextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].MCChoices[2];
            ChoiceDTextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].MCChoices[3];
            if (TBInstance.Questions[QBInstance.QuestionNum].MCAnswer == 0)
                RadioButtonMultipleChoiceA.Checked = true;
            else if (TBInstance.Questions[QBInstance.QuestionNum].MCAnswer == 1)
                RadioButtonMultipleChoiceB.Checked = true;
            else if (TBInstance.Questions[QBInstance.QuestionNum].MCAnswer == 2)
                RadioButtonMultipleChoiceC.Checked = true;
            else if (TBInstance.Questions[QBInstance.QuestionNum].MCAnswer == 3)
                RadioButtonMultipleChoiceD.Checked = true;

        }

        private void QuestionTypeDomainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            if (TBInstance.QuestionChangeCheck(QBInstance) == false)
                QBInstance.Entered = false;
            if (QuestionTypeDomainUpDown.Text == "TrueFalse")
            {
                QBInstance.questionType = QuestionType.TrueFalse;
                TrueFalseGroupBox.Enabled = true;
                FillInTheBlankAnswerGroupBox.Enabled = false;
                MultipleChoiceGroupBox.Enabled = false;
            }
            else if (QuestionTypeDomainUpDown.Text == "FillInTheBlank")
            {
                QBInstance.questionType = QuestionType.FillInTheBlank;
                TrueFalseGroupBox.Enabled = false;
                FillInTheBlankAnswerGroupBox.Enabled = true;
                MultipleChoiceGroupBox.Enabled = false;
            }
            else if (QuestionTypeDomainUpDown.Text == "MultipleChoice")
            {
                QBInstance.questionType = QuestionType.MultipleChoice;
                TrueFalseGroupBox.Enabled = false;
                FillInTheBlankAnswerGroupBox.Enabled = false;
                MultipleChoiceGroupBox.Enabled = true;
            }
        }

        private void QuestionTextTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionTextTextBox.Text != "")
                QBInstance.QuestionText = QuestionTextTextBox.Text;
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (TBInstance.QuestionCheck() == true && TBInstance.CheckTestReq() == true)
            {
                //  Add additional checks before passing
                FileWriter fw = new FileWriter();
                fw.CreateTestFile(TBInstance);
                for (int i = 0; i < TBInstance.QuestionSize; i++)
                {
                    fw.AddQuestionInfo(TBInstance.Questions[i], TBInstance.QuestionSize);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            QBInstance.Entered = true;
            QBInstance.TestPath = TBInstance.TestPath;
            TBInstance.Questions[QBInstance.QuestionNum] = QBInstance;
            QBInstance = new QuestionBehaviour();


            for (int i = 0; i < TBInstance.QuestionSize; i++)
            {
                if (TBInstance.Questions[i].Entered != true)
                {
                    FinishButton.Enabled = false;
                    return;
                }
            }
            FinishButton.Enabled = true;
        }
    }
}
