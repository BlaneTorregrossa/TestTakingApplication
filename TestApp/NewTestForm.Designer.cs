﻿namespace TestApp
{
    partial class NewTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTestForm));
            this.TrueFalseGroupBox = new System.Windows.Forms.GroupBox();
            this.FalseRadioButton = new System.Windows.Forms.RadioButton();
            this.TrueRadioButton = new System.Windows.Forms.RadioButton();
            this.FillInTheBlankAnswerGroupBox = new System.Windows.Forms.GroupBox();
            this.AnswersNeededNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AvalibleAnswersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.QuestionTenTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.QuestionNineTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.QuestionEightTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QuestionSixTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QuestionFourTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuestionThreeTextBox = new System.Windows.Forms.TextBox();
            this.QuestionTwoTextBox = new System.Windows.Forms.TextBox();
            this.QuestionOneTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Question2Label = new System.Windows.Forms.Label();
            this.Question1Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MultipleChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.ChoiceDTextBox = new System.Windows.Forms.TextBox();
            this.ChoiceCTextBox = new System.Windows.Forms.TextBox();
            this.ChoiceBTextBox = new System.Windows.Forms.TextBox();
            this.ChoiceATextBox = new System.Windows.Forms.TextBox();
            this.ChoiceDLabel = new System.Windows.Forms.Label();
            this.ChoiceCLabel = new System.Windows.Forms.Label();
            this.ChoiceBLabel = new System.Windows.Forms.Label();
            this.ChoiceALabel = new System.Windows.Forms.Label();
            this.CorrectAnswerGroupBox = new System.Windows.Forms.GroupBox();
            this.RadioButtonMultipleChoiceD = new System.Windows.Forms.RadioButton();
            this.RadioButtonMultipleChoiceC = new System.Windows.Forms.RadioButton();
            this.RadioButtonMultipleChoiceB = new System.Windows.Forms.RadioButton();
            this.RadioButtonMultipleChoiceA = new System.Windows.Forms.RadioButton();
            this.QuitButton = new System.Windows.Forms.Button();
            this.AnswersGroupBox = new System.Windows.Forms.GroupBox();
            this.QuestionNumberLabel = new System.Windows.Forms.Label();
            this.QuestionNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.QuestionTypeLabel = new System.Windows.Forms.Label();
            this.QuestionTypeDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.QuestionTextTextBox = new System.Windows.Forms.TextBox();
            this.FinishButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TrueFalseGroupBox.SuspendLayout();
            this.FillInTheBlankAnswerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersNeededNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvalibleAnswersNumericUpDown)).BeginInit();
            this.MultipleChoiceGroupBox.SuspendLayout();
            this.CorrectAnswerGroupBox.SuspendLayout();
            this.AnswersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionNumberNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TrueFalseGroupBox
            // 
            this.TrueFalseGroupBox.Controls.Add(this.FalseRadioButton);
            this.TrueFalseGroupBox.Controls.Add(this.TrueRadioButton);
            this.TrueFalseGroupBox.Location = new System.Drawing.Point(6, 19);
            this.TrueFalseGroupBox.Name = "TrueFalseGroupBox";
            this.TrueFalseGroupBox.Size = new System.Drawing.Size(121, 68);
            this.TrueFalseGroupBox.TabIndex = 6;
            this.TrueFalseGroupBox.TabStop = false;
            this.TrueFalseGroupBox.Text = "True/False Answer";
            this.TrueFalseGroupBox.Enter += new System.EventHandler(this.TrueFalseGroupBox_Enter);
            // 
            // FalseRadioButton
            // 
            this.FalseRadioButton.AutoSize = true;
            this.FalseRadioButton.Location = new System.Drawing.Point(6, 42);
            this.FalseRadioButton.Name = "FalseRadioButton";
            this.FalseRadioButton.Size = new System.Drawing.Size(50, 17);
            this.FalseRadioButton.TabIndex = 1;
            this.FalseRadioButton.TabStop = true;
            this.FalseRadioButton.Text = "False";
            this.FalseRadioButton.UseVisualStyleBackColor = true;
            this.FalseRadioButton.CheckedChanged += new System.EventHandler(this.FalseRadioButton_CheckedChanged);
            // 
            // TrueRadioButton
            // 
            this.TrueRadioButton.AutoSize = true;
            this.TrueRadioButton.Location = new System.Drawing.Point(6, 19);
            this.TrueRadioButton.Name = "TrueRadioButton";
            this.TrueRadioButton.Size = new System.Drawing.Size(47, 17);
            this.TrueRadioButton.TabIndex = 0;
            this.TrueRadioButton.TabStop = true;
            this.TrueRadioButton.Text = "True";
            this.TrueRadioButton.UseVisualStyleBackColor = true;
            this.TrueRadioButton.CheckedChanged += new System.EventHandler(this.TrueRadioButton_CheckedChanged);
            // 
            // FillInTheBlankAnswerGroupBox
            // 
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.AnswersNeededNumericUpDown);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.AvalibleAnswersNumericUpDown);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.label10);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.QuestionTenTextBox);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.label9);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.QuestionNineTextBox);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.label8);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.QuestionEightTextBox);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.label7);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.textBox3);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.label6);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.QuestionSixTextBox);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.label5);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.textBox2);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.label4);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.QuestionFourTextBox);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.label3);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.QuestionThreeTextBox);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.QuestionTwoTextBox);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.QuestionOneTextBox);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.label2);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.Question2Label);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.Question1Label);
            this.FillInTheBlankAnswerGroupBox.Controls.Add(this.label1);
            this.FillInTheBlankAnswerGroupBox.Location = new System.Drawing.Point(6, 93);
            this.FillInTheBlankAnswerGroupBox.Name = "FillInTheBlankAnswerGroupBox";
            this.FillInTheBlankAnswerGroupBox.Size = new System.Drawing.Size(456, 280);
            this.FillInTheBlankAnswerGroupBox.TabIndex = 2;
            this.FillInTheBlankAnswerGroupBox.TabStop = false;
            this.FillInTheBlankAnswerGroupBox.Text = "Fill in the Blank Answers";
            this.FillInTheBlankAnswerGroupBox.Enter += new System.EventHandler(this.FillInTheBlankAnswerGroupBox_Enter);
            // 
            // AnswersNeededNumericUpDown
            // 
            this.AnswersNeededNumericUpDown.Location = new System.Drawing.Point(356, 17);
            this.AnswersNeededNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AnswersNeededNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AnswersNeededNumericUpDown.Name = "AnswersNeededNumericUpDown";
            this.AnswersNeededNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.AnswersNeededNumericUpDown.TabIndex = 26;
            this.AnswersNeededNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AnswersNeededNumericUpDown.ValueChanged += new System.EventHandler(this.AnswersNeededNumericUpDown_ValueChanged);
            // 
            // AvalibleAnswersNumericUpDown
            // 
            this.AvalibleAnswersNumericUpDown.Location = new System.Drawing.Point(142, 17);
            this.AvalibleAnswersNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AvalibleAnswersNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AvalibleAnswersNumericUpDown.Name = "AvalibleAnswersNumericUpDown";
            this.AvalibleAnswersNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.AvalibleAnswersNumericUpDown.TabIndex = 25;
            this.AvalibleAnswersNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AvalibleAnswersNumericUpDown.ValueChanged += new System.EventHandler(this.AvalibleAnswersNumericUpDown_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "How many answers needed";
            // 
            // QuestionTenTextBox
            // 
            this.QuestionTenTextBox.Location = new System.Drawing.Point(29, 247);
            this.QuestionTenTextBox.Name = "QuestionTenTextBox";
            this.QuestionTenTextBox.Size = new System.Drawing.Size(421, 20);
            this.QuestionTenTextBox.TabIndex = 22;
            this.QuestionTenTextBox.TextChanged += new System.EventHandler(this.QuestionTenTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "#10";
            // 
            // QuestionNineTextBox
            // 
            this.QuestionNineTextBox.Location = new System.Drawing.Point(29, 224);
            this.QuestionNineTextBox.Name = "QuestionNineTextBox";
            this.QuestionNineTextBox.Size = new System.Drawing.Size(421, 20);
            this.QuestionNineTextBox.TabIndex = 20;
            this.QuestionNineTextBox.TextChanged += new System.EventHandler(this.QuestionNineTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "#9";
            // 
            // QuestionEightTextBox
            // 
            this.QuestionEightTextBox.Location = new System.Drawing.Point(29, 204);
            this.QuestionEightTextBox.Name = "QuestionEightTextBox";
            this.QuestionEightTextBox.Size = new System.Drawing.Size(421, 20);
            this.QuestionEightTextBox.TabIndex = 18;
            this.QuestionEightTextBox.TextChanged += new System.EventHandler(this.QuestionEightTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "#8";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(421, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "#7";
            // 
            // QuestionSixTextBox
            // 
            this.QuestionSixTextBox.Location = new System.Drawing.Point(29, 160);
            this.QuestionSixTextBox.Name = "QuestionSixTextBox";
            this.QuestionSixTextBox.Size = new System.Drawing.Size(421, 20);
            this.QuestionSixTextBox.TabIndex = 14;
            this.QuestionSixTextBox.TextChanged += new System.EventHandler(this.QuestionSixTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "#6";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(421, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "#5";
            // 
            // QuestionFourTextBox
            // 
            this.QuestionFourTextBox.Location = new System.Drawing.Point(29, 114);
            this.QuestionFourTextBox.Name = "QuestionFourTextBox";
            this.QuestionFourTextBox.Size = new System.Drawing.Size(421, 20);
            this.QuestionFourTextBox.TabIndex = 10;
            this.QuestionFourTextBox.TextChanged += new System.EventHandler(this.QuestionFourTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "#4";
            // 
            // QuestionThreeTextBox
            // 
            this.QuestionThreeTextBox.Location = new System.Drawing.Point(29, 91);
            this.QuestionThreeTextBox.Name = "QuestionThreeTextBox";
            this.QuestionThreeTextBox.Size = new System.Drawing.Size(421, 20);
            this.QuestionThreeTextBox.TabIndex = 8;
            this.QuestionThreeTextBox.TextChanged += new System.EventHandler(this.QuestionThreeTextBox_TextChanged);
            // 
            // QuestionTwoTextBox
            // 
            this.QuestionTwoTextBox.Location = new System.Drawing.Point(29, 68);
            this.QuestionTwoTextBox.Name = "QuestionTwoTextBox";
            this.QuestionTwoTextBox.Size = new System.Drawing.Size(421, 20);
            this.QuestionTwoTextBox.TabIndex = 7;
            this.QuestionTwoTextBox.TextChanged += new System.EventHandler(this.QuestionTwoTextBox_TextChanged);
            // 
            // QuestionOneTextBox
            // 
            this.QuestionOneTextBox.Location = new System.Drawing.Point(29, 45);
            this.QuestionOneTextBox.Name = "QuestionOneTextBox";
            this.QuestionOneTextBox.Size = new System.Drawing.Size(421, 20);
            this.QuestionOneTextBox.TabIndex = 6;
            this.QuestionOneTextBox.TextChanged += new System.EventHandler(this.QuestionOneTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "#3";
            // 
            // Question2Label
            // 
            this.Question2Label.AutoSize = true;
            this.Question2Label.Location = new System.Drawing.Point(3, 71);
            this.Question2Label.Name = "Question2Label";
            this.Question2Label.Size = new System.Drawing.Size(20, 13);
            this.Question2Label.TabIndex = 4;
            this.Question2Label.Text = "#2";
            // 
            // Question1Label
            // 
            this.Question1Label.AutoSize = true;
            this.Question1Label.Location = new System.Drawing.Point(3, 48);
            this.Question1Label.Name = "Question1Label";
            this.Question1Label.Size = new System.Drawing.Size(20, 13);
            this.Question1Label.TabIndex = 3;
            this.Question1Label.Text = "#1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Answers (1-10)";
            // 
            // MultipleChoiceGroupBox
            // 
            this.MultipleChoiceGroupBox.Controls.Add(this.ChoiceDTextBox);
            this.MultipleChoiceGroupBox.Controls.Add(this.ChoiceCTextBox);
            this.MultipleChoiceGroupBox.Controls.Add(this.ChoiceBTextBox);
            this.MultipleChoiceGroupBox.Controls.Add(this.ChoiceATextBox);
            this.MultipleChoiceGroupBox.Controls.Add(this.ChoiceDLabel);
            this.MultipleChoiceGroupBox.Controls.Add(this.ChoiceCLabel);
            this.MultipleChoiceGroupBox.Controls.Add(this.ChoiceBLabel);
            this.MultipleChoiceGroupBox.Controls.Add(this.ChoiceALabel);
            this.MultipleChoiceGroupBox.Controls.Add(this.CorrectAnswerGroupBox);
            this.MultipleChoiceGroupBox.Location = new System.Drawing.Point(467, 19);
            this.MultipleChoiceGroupBox.Name = "MultipleChoiceGroupBox";
            this.MultipleChoiceGroupBox.Size = new System.Drawing.Size(551, 412);
            this.MultipleChoiceGroupBox.TabIndex = 25;
            this.MultipleChoiceGroupBox.TabStop = false;
            this.MultipleChoiceGroupBox.Text = "Multiple Choice";
            this.MultipleChoiceGroupBox.Enter += new System.EventHandler(this.MultipleChoiceGroupBox_Enter);
            // 
            // ChoiceDTextBox
            // 
            this.ChoiceDTextBox.Location = new System.Drawing.Point(73, 222);
            this.ChoiceDTextBox.Multiline = true;
            this.ChoiceDTextBox.Name = "ChoiceDTextBox";
            this.ChoiceDTextBox.Size = new System.Drawing.Size(472, 56);
            this.ChoiceDTextBox.TabIndex = 11;
            this.ChoiceDTextBox.TextChanged += new System.EventHandler(this.ChoiceDTextBox_TextChanged);
            // 
            // ChoiceCTextBox
            // 
            this.ChoiceCTextBox.Location = new System.Drawing.Point(73, 152);
            this.ChoiceCTextBox.Multiline = true;
            this.ChoiceCTextBox.Name = "ChoiceCTextBox";
            this.ChoiceCTextBox.Size = new System.Drawing.Size(472, 60);
            this.ChoiceCTextBox.TabIndex = 10;
            this.ChoiceCTextBox.TextChanged += new System.EventHandler(this.ChoiceCTextBox_TextChanged);
            // 
            // ChoiceBTextBox
            // 
            this.ChoiceBTextBox.Location = new System.Drawing.Point(73, 84);
            this.ChoiceBTextBox.Multiline = true;
            this.ChoiceBTextBox.Name = "ChoiceBTextBox";
            this.ChoiceBTextBox.Size = new System.Drawing.Size(472, 58);
            this.ChoiceBTextBox.TabIndex = 9;
            this.ChoiceBTextBox.TextChanged += new System.EventHandler(this.ChoiceBTextBox_TextChanged);
            // 
            // ChoiceATextBox
            // 
            this.ChoiceATextBox.Location = new System.Drawing.Point(73, 22);
            this.ChoiceATextBox.Multiline = true;
            this.ChoiceATextBox.Name = "ChoiceATextBox";
            this.ChoiceATextBox.Size = new System.Drawing.Size(472, 52);
            this.ChoiceATextBox.TabIndex = 8;
            this.ChoiceATextBox.TextChanged += new System.EventHandler(this.ChoiceATextBox_TextChanged);
            // 
            // ChoiceDLabel
            // 
            this.ChoiceDLabel.AutoSize = true;
            this.ChoiceDLabel.Location = new System.Drawing.Point(6, 225);
            this.ChoiceDLabel.Name = "ChoiceDLabel";
            this.ChoiceDLabel.Size = new System.Drawing.Size(51, 13);
            this.ChoiceDLabel.TabIndex = 7;
            this.ChoiceDLabel.Text = "Choice D";
            // 
            // ChoiceCLabel
            // 
            this.ChoiceCLabel.AutoSize = true;
            this.ChoiceCLabel.Location = new System.Drawing.Point(6, 152);
            this.ChoiceCLabel.Name = "ChoiceCLabel";
            this.ChoiceCLabel.Size = new System.Drawing.Size(50, 13);
            this.ChoiceCLabel.TabIndex = 6;
            this.ChoiceCLabel.Text = "Choice C";
            // 
            // ChoiceBLabel
            // 
            this.ChoiceBLabel.AutoSize = true;
            this.ChoiceBLabel.Location = new System.Drawing.Point(6, 87);
            this.ChoiceBLabel.Name = "ChoiceBLabel";
            this.ChoiceBLabel.Size = new System.Drawing.Size(50, 13);
            this.ChoiceBLabel.TabIndex = 5;
            this.ChoiceBLabel.Text = "Choice B";
            // 
            // ChoiceALabel
            // 
            this.ChoiceALabel.AutoSize = true;
            this.ChoiceALabel.Location = new System.Drawing.Point(6, 25);
            this.ChoiceALabel.Name = "ChoiceALabel";
            this.ChoiceALabel.Size = new System.Drawing.Size(50, 13);
            this.ChoiceALabel.TabIndex = 4;
            this.ChoiceALabel.Text = "Choice A";
            // 
            // CorrectAnswerGroupBox
            // 
            this.CorrectAnswerGroupBox.Controls.Add(this.RadioButtonMultipleChoiceD);
            this.CorrectAnswerGroupBox.Controls.Add(this.RadioButtonMultipleChoiceC);
            this.CorrectAnswerGroupBox.Controls.Add(this.RadioButtonMultipleChoiceB);
            this.CorrectAnswerGroupBox.Controls.Add(this.RadioButtonMultipleChoiceA);
            this.CorrectAnswerGroupBox.Location = new System.Drawing.Point(0, 284);
            this.CorrectAnswerGroupBox.Name = "CorrectAnswerGroupBox";
            this.CorrectAnswerGroupBox.Size = new System.Drawing.Size(551, 121);
            this.CorrectAnswerGroupBox.TabIndex = 0;
            this.CorrectAnswerGroupBox.TabStop = false;
            this.CorrectAnswerGroupBox.Text = "Correct Answer";
            // 
            // RadioButtonMultipleChoiceD
            // 
            this.RadioButtonMultipleChoiceD.AutoSize = true;
            this.RadioButtonMultipleChoiceD.Location = new System.Drawing.Point(6, 88);
            this.RadioButtonMultipleChoiceD.Name = "RadioButtonMultipleChoiceD";
            this.RadioButtonMultipleChoiceD.Size = new System.Drawing.Size(33, 17);
            this.RadioButtonMultipleChoiceD.TabIndex = 3;
            this.RadioButtonMultipleChoiceD.TabStop = true;
            this.RadioButtonMultipleChoiceD.Text = "D";
            this.RadioButtonMultipleChoiceD.UseVisualStyleBackColor = true;
            this.RadioButtonMultipleChoiceD.CheckedChanged += new System.EventHandler(this.RadioButtonMultipleChoiceD_CheckedChanged);
            // 
            // RadioButtonMultipleChoiceC
            // 
            this.RadioButtonMultipleChoiceC.AutoSize = true;
            this.RadioButtonMultipleChoiceC.Location = new System.Drawing.Point(6, 65);
            this.RadioButtonMultipleChoiceC.Name = "RadioButtonMultipleChoiceC";
            this.RadioButtonMultipleChoiceC.Size = new System.Drawing.Size(32, 17);
            this.RadioButtonMultipleChoiceC.TabIndex = 2;
            this.RadioButtonMultipleChoiceC.TabStop = true;
            this.RadioButtonMultipleChoiceC.Text = "C";
            this.RadioButtonMultipleChoiceC.UseVisualStyleBackColor = true;
            this.RadioButtonMultipleChoiceC.CheckedChanged += new System.EventHandler(this.RadioButtonMultipleChoiceC_CheckedChanged);
            // 
            // RadioButtonMultipleChoiceB
            // 
            this.RadioButtonMultipleChoiceB.AutoSize = true;
            this.RadioButtonMultipleChoiceB.Location = new System.Drawing.Point(6, 42);
            this.RadioButtonMultipleChoiceB.Name = "RadioButtonMultipleChoiceB";
            this.RadioButtonMultipleChoiceB.Size = new System.Drawing.Size(32, 17);
            this.RadioButtonMultipleChoiceB.TabIndex = 1;
            this.RadioButtonMultipleChoiceB.TabStop = true;
            this.RadioButtonMultipleChoiceB.Text = "B";
            this.RadioButtonMultipleChoiceB.UseVisualStyleBackColor = true;
            this.RadioButtonMultipleChoiceB.CheckedChanged += new System.EventHandler(this.RadioButtonMultipleChoiceB_CheckedChanged);
            // 
            // RadioButtonMultipleChoiceA
            // 
            this.RadioButtonMultipleChoiceA.AutoSize = true;
            this.RadioButtonMultipleChoiceA.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonMultipleChoiceA.Name = "RadioButtonMultipleChoiceA";
            this.RadioButtonMultipleChoiceA.Size = new System.Drawing.Size(32, 17);
            this.RadioButtonMultipleChoiceA.TabIndex = 0;
            this.RadioButtonMultipleChoiceA.TabStop = true;
            this.RadioButtonMultipleChoiceA.Text = "A";
            this.RadioButtonMultipleChoiceA.UseVisualStyleBackColor = true;
            this.RadioButtonMultipleChoiceA.CheckedChanged += new System.EventHandler(this.RadioButtonMultipleChoiceA_CheckedChanged);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(1150, 256);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(74, 23);
            this.QuitButton.TabIndex = 27;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // AnswersGroupBox
            // 
            this.AnswersGroupBox.Controls.Add(this.TrueFalseGroupBox);
            this.AnswersGroupBox.Controls.Add(this.FillInTheBlankAnswerGroupBox);
            this.AnswersGroupBox.Controls.Add(this.MultipleChoiceGroupBox);
            this.AnswersGroupBox.Location = new System.Drawing.Point(12, 163);
            this.AnswersGroupBox.Name = "AnswersGroupBox";
            this.AnswersGroupBox.Size = new System.Drawing.Size(1024, 438);
            this.AnswersGroupBox.TabIndex = 28;
            this.AnswersGroupBox.TabStop = false;
            this.AnswersGroupBox.Text = "Answer(s)";
            // 
            // QuestionNumberLabel
            // 
            this.QuestionNumberLabel.AutoSize = true;
            this.QuestionNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.QuestionNumberLabel.Name = "QuestionNumberLabel";
            this.QuestionNumberLabel.Size = new System.Drawing.Size(89, 13);
            this.QuestionNumberLabel.TabIndex = 26;
            this.QuestionNumberLabel.Text = "Question Number";
            // 
            // QuestionNumberNumericUpDown
            // 
            this.QuestionNumberNumericUpDown.Location = new System.Drawing.Point(12, 25);
            this.QuestionNumberNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.QuestionNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuestionNumberNumericUpDown.Name = "QuestionNumberNumericUpDown";
            this.QuestionNumberNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.QuestionNumberNumericUpDown.TabIndex = 29;
            this.QuestionNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuestionNumberNumericUpDown.ValueChanged += new System.EventHandler(this.QuestionNumberNumericUpDown_ValueChanged);
            // 
            // QuestionTypeLabel
            // 
            this.QuestionTypeLabel.AutoSize = true;
            this.QuestionTypeLabel.Location = new System.Drawing.Point(12, 59);
            this.QuestionTypeLabel.Name = "QuestionTypeLabel";
            this.QuestionTypeLabel.Size = new System.Drawing.Size(76, 13);
            this.QuestionTypeLabel.TabIndex = 30;
            this.QuestionTypeLabel.Text = "Question Type";
            // 
            // QuestionTypeDomainUpDown
            // 
            this.QuestionTypeDomainUpDown.Items.Add("TrueFalse");
            this.QuestionTypeDomainUpDown.Items.Add("FillInTheBlank");
            this.QuestionTypeDomainUpDown.Items.Add("MultipleChoice");
            this.QuestionTypeDomainUpDown.Location = new System.Drawing.Point(12, 75);
            this.QuestionTypeDomainUpDown.Name = "QuestionTypeDomainUpDown";
            this.QuestionTypeDomainUpDown.ReadOnly = true;
            this.QuestionTypeDomainUpDown.Size = new System.Drawing.Size(120, 20);
            this.QuestionTypeDomainUpDown.TabIndex = 31;
            this.QuestionTypeDomainUpDown.SelectedItemChanged += new System.EventHandler(this.QuestionTypeDomainUpDown_SelectedItemChanged);
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.AutoSize = true;
            this.QuestionTextLabel.Location = new System.Drawing.Point(258, 9);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(73, 13);
            this.QuestionTextLabel.TabIndex = 32;
            this.QuestionTextLabel.Text = "Question Text";
            // 
            // QuestionTextTextBox
            // 
            this.QuestionTextTextBox.Location = new System.Drawing.Point(261, 25);
            this.QuestionTextTextBox.Multiline = true;
            this.QuestionTextTextBox.Name = "QuestionTextTextBox";
            this.QuestionTextTextBox.Size = new System.Drawing.Size(775, 119);
            this.QuestionTextTextBox.TabIndex = 33;
            this.QuestionTextTextBox.TextChanged += new System.EventHandler(this.QuestionTextTextBox_TextChanged);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(1149, 227);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 34;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1149, 198);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 35;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 613);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.QuestionTextTextBox);
            this.Controls.Add(this.QuestionTextLabel);
            this.Controls.Add(this.QuestionTypeDomainUpDown);
            this.Controls.Add(this.QuestionTypeLabel);
            this.Controls.Add(this.QuestionNumberNumericUpDown);
            this.Controls.Add(this.QuestionNumberLabel);
            this.Controls.Add(this.AnswersGroupBox);
            this.Controls.Add(this.QuitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewTestForm";
            this.Text = "Question Creation";
            this.Load += new System.EventHandler(this.NewTestForm_Load);
            this.TrueFalseGroupBox.ResumeLayout(false);
            this.TrueFalseGroupBox.PerformLayout();
            this.FillInTheBlankAnswerGroupBox.ResumeLayout(false);
            this.FillInTheBlankAnswerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersNeededNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvalibleAnswersNumericUpDown)).EndInit();
            this.MultipleChoiceGroupBox.ResumeLayout(false);
            this.MultipleChoiceGroupBox.PerformLayout();
            this.CorrectAnswerGroupBox.ResumeLayout(false);
            this.CorrectAnswerGroupBox.PerformLayout();
            this.AnswersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionNumberNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox TrueFalseGroupBox;
        private System.Windows.Forms.RadioButton FalseRadioButton;
        private System.Windows.Forms.RadioButton TrueRadioButton;
        private System.Windows.Forms.GroupBox FillInTheBlankAnswerGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuestionOneTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Question2Label;
        private System.Windows.Forms.Label Question1Label;
        private System.Windows.Forms.TextBox QuestionTwoTextBox;
        private System.Windows.Forms.TextBox QuestionFourTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuestionThreeTextBox;
        private System.Windows.Forms.TextBox QuestionSixTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox QuestionNineTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox QuestionEightTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox QuestionTenTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox MultipleChoiceGroupBox;
        private System.Windows.Forms.TextBox ChoiceDTextBox;
        private System.Windows.Forms.TextBox ChoiceCTextBox;
        private System.Windows.Forms.TextBox ChoiceBTextBox;
        private System.Windows.Forms.TextBox ChoiceATextBox;
        private System.Windows.Forms.Label ChoiceDLabel;
        private System.Windows.Forms.Label ChoiceCLabel;
        private System.Windows.Forms.Label ChoiceBLabel;
        private System.Windows.Forms.Label ChoiceALabel;
        private System.Windows.Forms.GroupBox CorrectAnswerGroupBox;
        private System.Windows.Forms.RadioButton RadioButtonMultipleChoiceD;
        private System.Windows.Forms.RadioButton RadioButtonMultipleChoiceC;
        private System.Windows.Forms.RadioButton RadioButtonMultipleChoiceB;
        private System.Windows.Forms.RadioButton RadioButtonMultipleChoiceA;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.NumericUpDown AvalibleAnswersNumericUpDown;
        private System.Windows.Forms.NumericUpDown AnswersNeededNumericUpDown;
        private System.Windows.Forms.GroupBox AnswersGroupBox;
        private System.Windows.Forms.Label QuestionNumberLabel;
        private System.Windows.Forms.NumericUpDown QuestionNumberNumericUpDown;
        private System.Windows.Forms.Label QuestionTypeLabel;
        private System.Windows.Forms.DomainUpDown QuestionTypeDomainUpDown;
        private System.Windows.Forms.Label QuestionTextLabel;
        private System.Windows.Forms.TextBox QuestionTextTextBox;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button SaveButton;
    }
}