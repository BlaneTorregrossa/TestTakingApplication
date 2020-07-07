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

        //  Setting defaults for when this form Loads
        private void NewTestForm_Load(object sender, EventArgs e)
        {
            this.Text = "Question Creation";
            this.Tag = "Question";
            QuestionNumberNumericUpDown.Value = 1;
            QuestionTextTextBox.Text = null;
            FinishButton.Enabled = false;
            TrueFalseGroupBox.Enabled = false;
            FillInTheBlankAnswerGroupBox.Enabled = false;
            MultipleChoiceGroupBox.Enabled = false;
        }

        //  Set True False answer for question to be true when clicked
        private void TrueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.TFAnswer = true;
        }
        //  Set True False answer for question to be false when clicked
        private void FalseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.TFAnswer = false;
        }

        //  Set one of the avalible answers to what is in the text box
        private void QuestionOneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionOneTextBox.Text != "")
                QBInstance.FITBAnswers[0] = QuestionOneTextBox.Text;
        }

        //  Set one of the avalible answers to what is in the text box
        private void QuestionTwoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionTwoTextBox.Text != "")
                QBInstance.FITBAnswers[1] = QuestionTwoTextBox.Text;
        }

        //  Set one of the avalible answers to what is in the text box
        private void QuestionThreeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionThreeTextBox.Text != "")
                QBInstance.FITBAnswers[2] = QuestionThreeTextBox.Text;
        }

        //  Set one of the avalible answers to what is in the text box
        private void QuestionFourTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionFourTextBox.Text != "")
                QBInstance.FITBAnswers[3] = QuestionFourTextBox.Text;
        }

        //  Set one of the avalible answers to what is in the text box
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                QBInstance.FITBAnswers[4] = textBox2.Text;
        }

        //  Set one of the avalible answers to what is in the text box
        private void QuestionSixTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionSixTextBox.Text != "")
                QBInstance.FITBAnswers[5] = QuestionSixTextBox.Text;
        }

        //  Set one of the avalible answers to what is in the text box
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
                QBInstance.FITBAnswers[6] = textBox3.Text;
        }

        //  Set one of the avalible answers to what is in the text box
        private void QuestionEightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionEightTextBox.Text != "")
                QBInstance.FITBAnswers[7] = QuestionEightTextBox.Text;
        }

        //  Set one of the avalible answers to what is in the text box
        private void QuestionNineTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionNineTextBox.Text != "")
                QBInstance.FITBAnswers[8] = QuestionNineTextBox.Text;
        }

        //  Set one of the avalible answers to what is in the text box
        private void QuestionTenTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionTenTextBox.Text != "")
                QBInstance.FITBAnswers[9] = QuestionTenTextBox.Text;
        }

        //  Set one of the multiple choice answers text to be what is in the text box
        private void ChoiceATextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.MCChoices[0] = ChoiceATextBox.Text;
        }

        //  Set one of the multiple choice answers text to be what is in the text box
        private void ChoiceBTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.MCChoices[1] = ChoiceBTextBox.Text;
        }

        //  Set one of the multiple choice answers text to be what is in the text box
        private void ChoiceCTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.MCChoices[2] = ChoiceCTextBox.Text;
        }

        //  Set one of the multiple choice answers text to be what is in the text box
        private void ChoiceDTextBox_TextChanged(object sender, EventArgs e)
        {
            QBInstance.MCChoices[3] = ChoiceDTextBox.Text;
        }

        //  Set the correct answer to be A for the multiple choice question
        private void RadioButtonMultipleChoiceA_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.MCAnswer = 0;
        }

        //  Set the correct answer to be B for the multiple choice question
        private void RadioButtonMultipleChoiceB_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.MCAnswer = 1;
        }

        //  Set the correct answer to be C for the multiple choice question
        private void RadioButtonMultipleChoiceC_CheckedChanged(object sender, EventArgs e)
        {
            QBInstance.MCAnswer = 2;
        }

        //  Set the correct answer to be D for the multiple choice question
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

        //  Return back to Form1 on button click
        private void QuitButton_Click(object sender, EventArgs e)
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

        //  Change Avalible Answers for Fill in the blank question from 1 - 10
        private void AvalibleAnswersNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (AvalibleAnswersNumericUpDown.Value < 1)
                AvalibleAnswersNumericUpDown.Value = 1;
            else if (AvalibleAnswersNumericUpDown.Value > 10)
                AvalibleAnswersNumericUpDown.Value = 10;

            QBInstance.AnswersAvalible = Convert.ToInt32(AvalibleAnswersNumericUpDown.Value);
        }

        //  Change Answers Required for Fill in the blank question from 1 - Answers Avalible Value
        private void AnswersNeededNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (AnswersNeededNumericUpDown.Value < 0)
                AnswersNeededNumericUpDown.Value = 0;
            else if (AnswersNeededNumericUpDown.Value > AvalibleAnswersNumericUpDown.Value)
                AnswersNeededNumericUpDown.Value = AvalibleAnswersNumericUpDown.Value;

            if (QBInstance.FITBRequirment != 1)
                QBInstance.FITBRequirment = Convert.ToInt32(AnswersNeededNumericUpDown.Value);
        }

        //  Refresh current form elements' presentation to represent saved information for question current on Numeric Up Down each time Numeric Up Down is changed
        //  Numeric Up Down value cannot be higher than the Question Size given and no lower than 1
        private void QuestionNumberNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (QuestionNumberNumericUpDown.Value > TBInstance.QuestionSize)
                QuestionNumberNumericUpDown.Value--;
            if (QuestionNumberNumericUpDown.Value <= 0)
                QuestionNumberNumericUpDown.Value = 1;

            QBInstance = new QuestionBehaviour();
            QBInstance.QuestionNum = Convert.ToInt32(QuestionNumberNumericUpDown.Value) - 1;

            QuestionTextTextBox.Text = TBInstance.Questions[QBInstance.QuestionNum].QuestionText;
            QuestionTypeDomainUpDown.Text = TBInstance.Questions[QBInstance.QuestionNum].questionType.ToString();
            if (TBInstance.Questions[QBInstance.QuestionNum].TFAnswer == true)
                TrueRadioButton.Checked = true;
            else if (TBInstance.Questions[QBInstance.QuestionNum].TFAnswer == false)
                FalseRadioButton.Checked = true;

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

            if (TBInstance.Questions[QBInstance.QuestionNum].Entered == false)
            {
                TrueRadioButton.Checked = false;
                FalseRadioButton.Checked = false;
                RadioButtonMultipleChoiceA.Checked = false;
                RadioButtonMultipleChoiceB.Checked = false;
                RadioButtonMultipleChoiceC.Checked = false;
                RadioButtonMultipleChoiceD.Checked = false;
            }


        }

        //  Change Question Type from True False/Fill In The Blank/Multiple Choice and enable the proper form elements for that question type
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

        //  Update Question Text information each time the text changes
        private void QuestionTextTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuestionTextTextBox.Text != "")
                QBInstance.QuestionText = QuestionTextTextBox.Text;
        }

        //  When button is clicked take the newly created test and questions through checks before creating test files and adding the proper data to test file
        private void FinishButton_Click(object sender, EventArgs e)
        {
            //  Checks for questions and test
            if (TBInstance.QuestionCheck(this) == true && TBInstance.CheckTestReq() == true)
            {
                FileWriter fw = new FileWriter();
                fw.CreateTestFile(TBInstance);  //  Create Test file based on given test information
                for (int i = 0; i < TBInstance.QuestionSize; i++)
                {
                    fw.AddQuestionInfo(TBInstance.Questions[i], TBInstance.QuestionSize);   //  Add question to test file based on given question information
                }

                //  Open Form1 after test information is saved to file
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

        }

        //  Save entered information for the current selected question when button is clicked
        //  Once all questions have information saved the Finish button is enabled
        private void SaveButton_Click(object sender, EventArgs e)
        {
            QBInstance.Entered = true;
            QBInstance.TestPath = TBInstance.TestPath;
            TBInstance.Questions[QBInstance.QuestionNum] = QBInstance;

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
