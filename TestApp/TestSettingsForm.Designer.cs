namespace TestApp
{
    partial class TestSettingsForm
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
            this.TestTitleTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.QuestionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TestTitleLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLimitNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TestTitleTextBox
            // 
            this.TestTitleTextBox.Location = new System.Drawing.Point(6, 29);
            this.TestTitleTextBox.Multiline = true;
            this.TestTitleTextBox.Name = "TestTitleTextBox";
            this.TestTitleTextBox.Size = new System.Drawing.Size(577, 33);
            this.TestTitleTextBox.TabIndex = 0;
            this.TestTitleTextBox.TextChanged += new System.EventHandler(this.TestTitleTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.ContinueButton);
            this.groupBox1.Controls.Add(this.QuestionsNumericUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TimeLimitNumericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TestTitleLabel);
            this.groupBox1.Controls.Add(this.TestTitleTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(6, 287);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(577, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(6, 254);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(577, 27);
            this.ContinueButton.TabIndex = 6;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // QuestionsNumericUpDown
            // 
            this.QuestionsNumericUpDown.Location = new System.Drawing.Point(66, 214);
            this.QuestionsNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.QuestionsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuestionsNumericUpDown.Name = "QuestionsNumericUpDown";
            this.QuestionsNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.QuestionsNumericUpDown.TabIndex = 5;
            this.QuestionsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuestionsNumericUpDown.ValueChanged += new System.EventHandler(this.QuestionsNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Questions";
            // 
            // TimeLimitNumericUpDown
            // 
            this.TimeLimitNumericUpDown.Location = new System.Drawing.Point(66, 127);
            this.TimeLimitNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.TimeLimitNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeLimitNumericUpDown.Name = "TimeLimitNumericUpDown";
            this.TimeLimitNumericUpDown.Size = new System.Drawing.Size(115, 20);
            this.TimeLimitNumericUpDown.TabIndex = 3;
            this.TimeLimitNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeLimitNumericUpDown.ValueChanged += new System.EventHandler(this.TimeLimitNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Limit";
            // 
            // TestTitleLabel
            // 
            this.TestTitleLabel.AutoSize = true;
            this.TestTitleLabel.Location = new System.Drawing.Point(276, 13);
            this.TestTitleLabel.Name = "TestTitleLabel";
            this.TestTitleLabel.Size = new System.Drawing.Size(51, 13);
            this.TestTitleLabel.TabIndex = 1;
            this.TestTitleLabel.Text = "Test Title";
            // 
            // TestSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 349);
            this.Controls.Add(this.groupBox1);
            this.Name = "TestSettingsForm";
            this.Text = "TestSettingsForm";
            this.Load += new System.EventHandler(this.TestSettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLimitNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TestTitleTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown QuestionsNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TimeLimitNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TestTitleLabel;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Button ExitButton;
    }
}