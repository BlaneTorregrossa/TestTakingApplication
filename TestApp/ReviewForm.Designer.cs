namespace TestApp
{
    partial class ReviewForm
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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.QuestionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.QuestionTypeLabel = new System.Windows.Forms.Label();
            this.QuestionTypeTextBox = new System.Windows.Forms.TextBox();
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.QuestionTextTextBox = new System.Windows.Forms.TextBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(12, 41);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(49, 13);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "Question";
            // 
            // QuestionNumericUpDown
            // 
            this.QuestionNumericUpDown.Location = new System.Drawing.Point(12, 57);
            this.QuestionNumericUpDown.Name = "QuestionNumericUpDown";
            this.QuestionNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.QuestionNumericUpDown.TabIndex = 1;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(270, 397);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 2;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(432, 397);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(351, 397);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 4;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            // 
            // QuestionTypeLabel
            // 
            this.QuestionTypeLabel.AutoSize = true;
            this.QuestionTypeLabel.Location = new System.Drawing.Point(640, 41);
            this.QuestionTypeLabel.Name = "QuestionTypeLabel";
            this.QuestionTypeLabel.Size = new System.Drawing.Size(76, 13);
            this.QuestionTypeLabel.TabIndex = 6;
            this.QuestionTypeLabel.Text = "Question Type";
            // 
            // QuestionTypeTextBox
            // 
            this.QuestionTypeTextBox.Location = new System.Drawing.Point(633, 57);
            this.QuestionTypeTextBox.Name = "QuestionTypeTextBox";
            this.QuestionTypeTextBox.Size = new System.Drawing.Size(142, 20);
            this.QuestionTypeTextBox.TabIndex = 7;
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.AutoSize = true;
            this.QuestionTextLabel.Location = new System.Drawing.Point(12, 107);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(73, 13);
            this.QuestionTextLabel.TabIndex = 8;
            this.QuestionTextLabel.Text = "Question Text";
            // 
            // QuestionTextTextBox
            // 
            this.QuestionTextTextBox.Location = new System.Drawing.Point(12, 123);
            this.QuestionTextTextBox.Multiline = true;
            this.QuestionTextTextBox.Name = "QuestionTextTextBox";
            this.QuestionTextTextBox.Size = new System.Drawing.Size(763, 81);
            this.QuestionTextTextBox.TabIndex = 9;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(12, 225);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(42, 13);
            this.AnswerLabel.TabIndex = 10;
            this.AnswerLabel.Text = "Answer";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(12, 241);
            this.AnswerTextBox.Multiline = true;
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(763, 105);
            this.AnswerTextBox.TabIndex = 11;
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 432);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionTextTextBox);
            this.Controls.Add(this.QuestionTextLabel);
            this.Controls.Add(this.QuestionTypeTextBox);
            this.Controls.Add(this.QuestionTypeLabel);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.QuestionNumericUpDown);
            this.Controls.Add(this.QuestionLabel);
            this.Name = "ReviewForm";
            this.Text = "ReviewForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.NumericUpDown QuestionNumericUpDown;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label QuestionTypeLabel;
        private System.Windows.Forms.TextBox QuestionTypeTextBox;
        private System.Windows.Forms.Label QuestionTextLabel;
        private System.Windows.Forms.TextBox QuestionTextTextBox;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.TextBox AnswerTextBox;
    }
}