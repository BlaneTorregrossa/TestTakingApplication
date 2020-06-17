namespace TestApp
{
    partial class TestTakingForm
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
            this.components = new System.ComponentModel.Container();
            this.RemainingTimeLabel = new System.Windows.Forms.Label();
            this.QuestionNumLabel = new System.Windows.Forms.Label();
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.QuestionTestInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.TrueFalseGroupBox = new System.Windows.Forms.GroupBox();
            this.FalseRadioButton = new System.Windows.Forms.RadioButton();
            this.TrueRadioButton = new System.Windows.Forms.RadioButton();
            this.MultipleChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.DRadioButton = new System.Windows.Forms.RadioButton();
            this.CRadioButton = new System.Windows.Forms.RadioButton();
            this.BRadioButton = new System.Windows.Forms.RadioButton();
            this.ARadioButton = new System.Windows.Forms.RadioButton();
            this.FillInTheBlankGroupBox = new System.Windows.Forms.GroupBox();
            this.FITBTextBox10 = new System.Windows.Forms.TextBox();
            this.FITBTextBox9 = new System.Windows.Forms.TextBox();
            this.FITBTextBox8 = new System.Windows.Forms.TextBox();
            this.FITBTextBox7 = new System.Windows.Forms.TextBox();
            this.FITBTextBox6 = new System.Windows.Forms.TextBox();
            this.FITBTextBox5 = new System.Windows.Forms.TextBox();
            this.FITBTextBox4 = new System.Windows.Forms.TextBox();
            this.FITBTextBox3 = new System.Windows.Forms.TextBox();
            this.FITBTextBox2 = new System.Windows.Forms.TextBox();
            this.FITBTextBox1 = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.QuestionTestInfoGroupBox.SuspendLayout();
            this.TrueFalseGroupBox.SuspendLayout();
            this.MultipleChoiceGroupBox.SuspendLayout();
            this.FillInTheBlankGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemainingTimeLabel
            // 
            this.RemainingTimeLabel.AutoSize = true;
            this.RemainingTimeLabel.Location = new System.Drawing.Point(7, 16);
            this.RemainingTimeLabel.Name = "RemainingTimeLabel";
            this.RemainingTimeLabel.Size = new System.Drawing.Size(83, 13);
            this.RemainingTimeLabel.TabIndex = 1;
            this.RemainingTimeLabel.Text = "Remaining Time";
            this.RemainingTimeLabel.Click += new System.EventHandler(this.RemainingTimeLabel_Click);
            // 
            // QuestionNumLabel
            // 
            this.QuestionNumLabel.AutoSize = true;
            this.QuestionNumLabel.Location = new System.Drawing.Point(6, 38);
            this.QuestionNumLabel.Name = "QuestionNumLabel";
            this.QuestionNumLabel.Size = new System.Drawing.Size(59, 13);
            this.QuestionNumLabel.TabIndex = 2;
            this.QuestionNumLabel.Text = "Question #";
            this.QuestionNumLabel.Click += new System.EventHandler(this.QuestionNumLabel_Click);
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.AutoSize = true;
            this.QuestionTextLabel.Location = new System.Drawing.Point(264, 16);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(49, 13);
            this.QuestionTextLabel.TabIndex = 4;
            this.QuestionTextLabel.Text = "Question";
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(200, 38);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(897, 67);
            this.QuestionTextBox.TabIndex = 5;
            // 
            // QuestionTestInfoGroupBox
            // 
            this.QuestionTestInfoGroupBox.Controls.Add(this.SubmitButton);
            this.QuestionTestInfoGroupBox.Controls.Add(this.PreviousButton);
            this.QuestionTestInfoGroupBox.Controls.Add(this.NextButton);
            this.QuestionTestInfoGroupBox.Controls.Add(this.QuestionTextBox);
            this.QuestionTestInfoGroupBox.Controls.Add(this.QuestionTextLabel);
            this.QuestionTestInfoGroupBox.Controls.Add(this.RemainingTimeLabel);
            this.QuestionTestInfoGroupBox.Controls.Add(this.QuestionNumLabel);
            this.QuestionTestInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.QuestionTestInfoGroupBox.Name = "QuestionTestInfoGroupBox";
            this.QuestionTestInfoGroupBox.Size = new System.Drawing.Size(1104, 118);
            this.QuestionTestInfoGroupBox.TabIndex = 6;
            this.QuestionTestInfoGroupBox.TabStop = false;
            this.QuestionTestInfoGroupBox.Text = "Question/Test Info";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(107, 64);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(6, 89);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 11;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(6, 64);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // TrueFalseGroupBox
            // 
            this.TrueFalseGroupBox.Controls.Add(this.FalseRadioButton);
            this.TrueFalseGroupBox.Controls.Add(this.TrueRadioButton);
            this.TrueFalseGroupBox.Location = new System.Drawing.Point(16, 137);
            this.TrueFalseGroupBox.Name = "TrueFalseGroupBox";
            this.TrueFalseGroupBox.Size = new System.Drawing.Size(109, 67);
            this.TrueFalseGroupBox.TabIndex = 7;
            this.TrueFalseGroupBox.TabStop = false;
            this.TrueFalseGroupBox.Text = "True False Answer";
            // 
            // FalseRadioButton
            // 
            this.FalseRadioButton.AutoSize = true;
            this.FalseRadioButton.Location = new System.Drawing.Point(3, 39);
            this.FalseRadioButton.Name = "FalseRadioButton";
            this.FalseRadioButton.Size = new System.Drawing.Size(50, 17);
            this.FalseRadioButton.TabIndex = 1;
            this.FalseRadioButton.TabStop = true;
            this.FalseRadioButton.Text = "False";
            this.FalseRadioButton.UseVisualStyleBackColor = true;
            // 
            // TrueRadioButton
            // 
            this.TrueRadioButton.AutoSize = true;
            this.TrueRadioButton.Location = new System.Drawing.Point(3, 16);
            this.TrueRadioButton.Name = "TrueRadioButton";
            this.TrueRadioButton.Size = new System.Drawing.Size(47, 17);
            this.TrueRadioButton.TabIndex = 0;
            this.TrueRadioButton.TabStop = true;
            this.TrueRadioButton.Text = "True";
            this.TrueRadioButton.UseVisualStyleBackColor = true;
            // 
            // MultipleChoiceGroupBox
            // 
            this.MultipleChoiceGroupBox.Controls.Add(this.DRadioButton);
            this.MultipleChoiceGroupBox.Controls.Add(this.CRadioButton);
            this.MultipleChoiceGroupBox.Controls.Add(this.BRadioButton);
            this.MultipleChoiceGroupBox.Controls.Add(this.ARadioButton);
            this.MultipleChoiceGroupBox.Location = new System.Drawing.Point(16, 210);
            this.MultipleChoiceGroupBox.Name = "MultipleChoiceGroupBox";
            this.MultipleChoiceGroupBox.Size = new System.Drawing.Size(424, 267);
            this.MultipleChoiceGroupBox.TabIndex = 8;
            this.MultipleChoiceGroupBox.TabStop = false;
            this.MultipleChoiceGroupBox.Text = "Multiple Choice Answer";
            // 
            // DRadioButton
            // 
            this.DRadioButton.AutoSize = true;
            this.DRadioButton.Location = new System.Drawing.Point(6, 194);
            this.DRadioButton.Name = "DRadioButton";
            this.DRadioButton.Size = new System.Drawing.Size(33, 17);
            this.DRadioButton.TabIndex = 3;
            this.DRadioButton.TabStop = true;
            this.DRadioButton.Text = "D";
            this.DRadioButton.UseVisualStyleBackColor = true;
            // 
            // CRadioButton
            // 
            this.CRadioButton.AutoSize = true;
            this.CRadioButton.Location = new System.Drawing.Point(6, 135);
            this.CRadioButton.Name = "CRadioButton";
            this.CRadioButton.Size = new System.Drawing.Size(32, 17);
            this.CRadioButton.TabIndex = 2;
            this.CRadioButton.TabStop = true;
            this.CRadioButton.Text = "C";
            this.CRadioButton.UseVisualStyleBackColor = true;
            // 
            // BRadioButton
            // 
            this.BRadioButton.AutoSize = true;
            this.BRadioButton.Location = new System.Drawing.Point(6, 75);
            this.BRadioButton.Name = "BRadioButton";
            this.BRadioButton.Size = new System.Drawing.Size(32, 17);
            this.BRadioButton.TabIndex = 1;
            this.BRadioButton.TabStop = true;
            this.BRadioButton.Text = "B";
            this.BRadioButton.UseVisualStyleBackColor = true;
            // 
            // ARadioButton
            // 
            this.ARadioButton.AutoSize = true;
            this.ARadioButton.Location = new System.Drawing.Point(6, 19);
            this.ARadioButton.Name = "ARadioButton";
            this.ARadioButton.Size = new System.Drawing.Size(32, 17);
            this.ARadioButton.TabIndex = 0;
            this.ARadioButton.TabStop = true;
            this.ARadioButton.Text = "A";
            this.ARadioButton.UseVisualStyleBackColor = true;
            // 
            // FillInTheBlankGroupBox
            // 
            this.FillInTheBlankGroupBox.Controls.Add(this.FITBTextBox10);
            this.FillInTheBlankGroupBox.Controls.Add(this.FITBTextBox9);
            this.FillInTheBlankGroupBox.Controls.Add(this.FITBTextBox8);
            this.FillInTheBlankGroupBox.Controls.Add(this.FITBTextBox7);
            this.FillInTheBlankGroupBox.Controls.Add(this.FITBTextBox6);
            this.FillInTheBlankGroupBox.Controls.Add(this.FITBTextBox5);
            this.FillInTheBlankGroupBox.Controls.Add(this.FITBTextBox4);
            this.FillInTheBlankGroupBox.Controls.Add(this.FITBTextBox3);
            this.FillInTheBlankGroupBox.Controls.Add(this.FITBTextBox2);
            this.FillInTheBlankGroupBox.Controls.Add(this.FITBTextBox1);
            this.FillInTheBlankGroupBox.Location = new System.Drawing.Point(446, 137);
            this.FillInTheBlankGroupBox.Name = "FillInTheBlankGroupBox";
            this.FillInTheBlankGroupBox.Size = new System.Drawing.Size(663, 284);
            this.FillInTheBlankGroupBox.TabIndex = 4;
            this.FillInTheBlankGroupBox.TabStop = false;
            this.FillInTheBlankGroupBox.Text = "Fill In The Blank Answers";
            // 
            // FITBTextBox10
            // 
            this.FITBTextBox10.Location = new System.Drawing.Point(7, 250);
            this.FITBTextBox10.Name = "FITBTextBox10";
            this.FITBTextBox10.Size = new System.Drawing.Size(650, 20);
            this.FITBTextBox10.TabIndex = 9;
            // 
            // FITBTextBox9
            // 
            this.FITBTextBox9.Location = new System.Drawing.Point(6, 224);
            this.FITBTextBox9.Name = "FITBTextBox9";
            this.FITBTextBox9.Size = new System.Drawing.Size(650, 20);
            this.FITBTextBox9.TabIndex = 8;
            // 
            // FITBTextBox8
            // 
            this.FITBTextBox8.Location = new System.Drawing.Point(6, 198);
            this.FITBTextBox8.Name = "FITBTextBox8";
            this.FITBTextBox8.Size = new System.Drawing.Size(650, 20);
            this.FITBTextBox8.TabIndex = 7;
            // 
            // FITBTextBox7
            // 
            this.FITBTextBox7.Location = new System.Drawing.Point(7, 172);
            this.FITBTextBox7.Name = "FITBTextBox7";
            this.FITBTextBox7.Size = new System.Drawing.Size(650, 20);
            this.FITBTextBox7.TabIndex = 6;
            // 
            // FITBTextBox6
            // 
            this.FITBTextBox6.Location = new System.Drawing.Point(6, 146);
            this.FITBTextBox6.Name = "FITBTextBox6";
            this.FITBTextBox6.Size = new System.Drawing.Size(650, 20);
            this.FITBTextBox6.TabIndex = 5;
            // 
            // FITBTextBox5
            // 
            this.FITBTextBox5.Location = new System.Drawing.Point(6, 120);
            this.FITBTextBox5.Name = "FITBTextBox5";
            this.FITBTextBox5.Size = new System.Drawing.Size(650, 20);
            this.FITBTextBox5.TabIndex = 4;
            // 
            // FITBTextBox4
            // 
            this.FITBTextBox4.Location = new System.Drawing.Point(6, 94);
            this.FITBTextBox4.Name = "FITBTextBox4";
            this.FITBTextBox4.Size = new System.Drawing.Size(650, 20);
            this.FITBTextBox4.TabIndex = 3;
            // 
            // FITBTextBox3
            // 
            this.FITBTextBox3.Location = new System.Drawing.Point(6, 68);
            this.FITBTextBox3.Name = "FITBTextBox3";
            this.FITBTextBox3.Size = new System.Drawing.Size(650, 20);
            this.FITBTextBox3.TabIndex = 2;
            // 
            // FITBTextBox2
            // 
            this.FITBTextBox2.Location = new System.Drawing.Point(6, 42);
            this.FITBTextBox2.Name = "FITBTextBox2";
            this.FITBTextBox2.Size = new System.Drawing.Size(650, 20);
            this.FITBTextBox2.TabIndex = 1;
            // 
            // FITBTextBox1
            // 
            this.FITBTextBox1.Location = new System.Drawing.Point(7, 16);
            this.FITBTextBox1.Name = "FITBTextBox1";
            this.FITBTextBox1.Size = new System.Drawing.Size(650, 20);
            this.FITBTextBox1.TabIndex = 0;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TestTakingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 483);
            this.Controls.Add(this.FillInTheBlankGroupBox);
            this.Controls.Add(this.MultipleChoiceGroupBox);
            this.Controls.Add(this.TrueFalseGroupBox);
            this.Controls.Add(this.QuestionTestInfoGroupBox);
            this.Name = "TestTakingForm";
            this.Text = "TestTakingForm";
            this.Load += new System.EventHandler(this.TestTakingForm_Load);
            this.QuestionTestInfoGroupBox.ResumeLayout(false);
            this.QuestionTestInfoGroupBox.PerformLayout();
            this.TrueFalseGroupBox.ResumeLayout(false);
            this.TrueFalseGroupBox.PerformLayout();
            this.MultipleChoiceGroupBox.ResumeLayout(false);
            this.MultipleChoiceGroupBox.PerformLayout();
            this.FillInTheBlankGroupBox.ResumeLayout(false);
            this.FillInTheBlankGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label RemainingTimeLabel;
        private System.Windows.Forms.Label QuestionNumLabel;
        private System.Windows.Forms.Label QuestionTextLabel;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.GroupBox QuestionTestInfoGroupBox;
        private System.Windows.Forms.GroupBox TrueFalseGroupBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.RadioButton FalseRadioButton;
        private System.Windows.Forms.RadioButton TrueRadioButton;
        private System.Windows.Forms.GroupBox MultipleChoiceGroupBox;
        private System.Windows.Forms.RadioButton DRadioButton;
        private System.Windows.Forms.RadioButton CRadioButton;
        private System.Windows.Forms.RadioButton BRadioButton;
        private System.Windows.Forms.RadioButton ARadioButton;
        private System.Windows.Forms.GroupBox FillInTheBlankGroupBox;
        private System.Windows.Forms.TextBox FITBTextBox10;
        private System.Windows.Forms.TextBox FITBTextBox9;
        private System.Windows.Forms.TextBox FITBTextBox8;
        private System.Windows.Forms.TextBox FITBTextBox7;
        private System.Windows.Forms.TextBox FITBTextBox6;
        private System.Windows.Forms.TextBox FITBTextBox5;
        private System.Windows.Forms.TextBox FITBTextBox4;
        private System.Windows.Forms.TextBox FITBTextBox3;
        private System.Windows.Forms.TextBox FITBTextBox2;
        private System.Windows.Forms.TextBox FITBTextBox1;
        private System.Windows.Forms.Timer Timer;
    }
}