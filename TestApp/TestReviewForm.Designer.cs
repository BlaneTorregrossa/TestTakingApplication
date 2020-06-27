namespace TestApp
{
    partial class TestReviewForm
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
            this.QuestionNumberLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.GivenAnswerLabel = new System.Windows.Forms.Label();
            this.CorrectAnswerLabel = new System.Windows.Forms.Label();
            this.CorrectAnswerTextBox = new System.Windows.Forms.TextBox();
            this.GivenAnswerTextBox = new System.Windows.Forms.TextBox();
            this.QuestionScoreLabel = new System.Windows.Forms.Label();
            this.QuestionScoreTextBox = new System.Windows.Forms.TextBox();
            this.TestScoreLabel = new System.Windows.Forms.Label();
            this.TestScoreTextBox = new System.Windows.Forms.TextBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionNumberLabel
            // 
            this.QuestionNumberLabel.AutoSize = true;
            this.QuestionNumberLabel.Location = new System.Drawing.Point(13, 13);
            this.QuestionNumberLabel.Name = "QuestionNumberLabel";
            this.QuestionNumberLabel.Size = new System.Drawing.Size(59, 13);
            this.QuestionNumberLabel.TabIndex = 0;
            this.QuestionNumberLabel.Text = "Question #";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(12, 29);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(12, 58);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 2;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.AutoSize = true;
            this.QuestionTextLabel.Location = new System.Drawing.Point(243, 13);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(49, 13);
            this.QuestionTextLabel.TabIndex = 3;
            this.QuestionTextLabel.Text = "Question";
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(246, 29);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.ReadOnly = true;
            this.QuestionTextBox.Size = new System.Drawing.Size(686, 89);
            this.QuestionTextBox.TabIndex = 4;
            // 
            // GivenAnswerLabel
            // 
            this.GivenAnswerLabel.AutoSize = true;
            this.GivenAnswerLabel.Location = new System.Drawing.Point(12, 153);
            this.GivenAnswerLabel.Name = "GivenAnswerLabel";
            this.GivenAnswerLabel.Size = new System.Drawing.Size(84, 13);
            this.GivenAnswerLabel.TabIndex = 5;
            this.GivenAnswerLabel.Text = "Given Answer(s)";
            // 
            // CorrectAnswerLabel
            // 
            this.CorrectAnswerLabel.AutoSize = true;
            this.CorrectAnswerLabel.Location = new System.Drawing.Point(476, 153);
            this.CorrectAnswerLabel.Name = "CorrectAnswerLabel";
            this.CorrectAnswerLabel.Size = new System.Drawing.Size(90, 13);
            this.CorrectAnswerLabel.TabIndex = 6;
            this.CorrectAnswerLabel.Text = "Correct Answer(s)";
            // 
            // CorrectAnswerTextBox
            // 
            this.CorrectAnswerTextBox.Location = new System.Drawing.Point(479, 169);
            this.CorrectAnswerTextBox.Multiline = true;
            this.CorrectAnswerTextBox.Name = "CorrectAnswerTextBox";
            this.CorrectAnswerTextBox.ReadOnly = true;
            this.CorrectAnswerTextBox.Size = new System.Drawing.Size(453, 91);
            this.CorrectAnswerTextBox.TabIndex = 7;
            // 
            // GivenAnswerTextBox
            // 
            this.GivenAnswerTextBox.Location = new System.Drawing.Point(12, 169);
            this.GivenAnswerTextBox.Multiline = true;
            this.GivenAnswerTextBox.Name = "GivenAnswerTextBox";
            this.GivenAnswerTextBox.ReadOnly = true;
            this.GivenAnswerTextBox.Size = new System.Drawing.Size(439, 91);
            this.GivenAnswerTextBox.TabIndex = 8;
            // 
            // QuestionScoreLabel
            // 
            this.QuestionScoreLabel.AutoSize = true;
            this.QuestionScoreLabel.Location = new System.Drawing.Point(107, 55);
            this.QuestionScoreLabel.Name = "QuestionScoreLabel";
            this.QuestionScoreLabel.Size = new System.Drawing.Size(80, 13);
            this.QuestionScoreLabel.TabIndex = 9;
            this.QuestionScoreLabel.Text = "Question Score";
            // 
            // QuestionScoreTextBox
            // 
            this.QuestionScoreTextBox.Location = new System.Drawing.Point(110, 74);
            this.QuestionScoreTextBox.Name = "QuestionScoreTextBox";
            this.QuestionScoreTextBox.ReadOnly = true;
            this.QuestionScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuestionScoreTextBox.TabIndex = 10;
            // 
            // TestScoreLabel
            // 
            this.TestScoreLabel.AutoSize = true;
            this.TestScoreLabel.Location = new System.Drawing.Point(107, 16);
            this.TestScoreLabel.Name = "TestScoreLabel";
            this.TestScoreLabel.Size = new System.Drawing.Size(59, 13);
            this.TestScoreLabel.TabIndex = 11;
            this.TestScoreLabel.Text = "Test Score";
            // 
            // TestScoreTextBox
            // 
            this.TestScoreTextBox.Location = new System.Drawing.Point(110, 32);
            this.TestScoreTextBox.Name = "TestScoreTextBox";
            this.TestScoreTextBox.ReadOnly = true;
            this.TestScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.TestScoreTextBox.TabIndex = 12;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(12, 114);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(198, 23);
            this.ReturnButton.TabIndex = 13;
            this.ReturnButton.Text = "Return to Starting Window";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // TestReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 287);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.TestScoreTextBox);
            this.Controls.Add(this.TestScoreLabel);
            this.Controls.Add(this.QuestionScoreTextBox);
            this.Controls.Add(this.QuestionScoreLabel);
            this.Controls.Add(this.GivenAnswerTextBox);
            this.Controls.Add(this.CorrectAnswerTextBox);
            this.Controls.Add(this.CorrectAnswerLabel);
            this.Controls.Add(this.GivenAnswerLabel);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.QuestionTextLabel);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.QuestionNumberLabel);
            this.Name = "TestReviewForm";
            this.Text = "TestReviewForm";
            this.Load += new System.EventHandler(this.TestReviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionNumberLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Label QuestionTextLabel;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Label GivenAnswerLabel;
        private System.Windows.Forms.Label CorrectAnswerLabel;
        private System.Windows.Forms.TextBox CorrectAnswerTextBox;
        private System.Windows.Forms.TextBox GivenAnswerTextBox;
        private System.Windows.Forms.Label QuestionScoreLabel;
        private System.Windows.Forms.TextBox QuestionScoreTextBox;
        private System.Windows.Forms.Label TestScoreLabel;
        private System.Windows.Forms.TextBox TestScoreTextBox;
        private System.Windows.Forms.Button ReturnButton;
    }
}