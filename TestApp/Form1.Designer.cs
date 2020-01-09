namespace TestApp
{
    partial class Form1
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
            this.TestSelectionLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DisclaimerButton = new System.Windows.Forms.Button();
            this.SelectedTestComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteTestButton = new System.Windows.Forms.Button();
            this.StartTestButton = new System.Windows.Forms.Button();
            this.CreateTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestSelectionLabel
            // 
            this.TestSelectionLabel.AutoSize = true;
            this.TestSelectionLabel.Location = new System.Drawing.Point(12, 39);
            this.TestSelectionLabel.Name = "TestSelectionLabel";
            this.TestSelectionLabel.Size = new System.Drawing.Size(73, 13);
            this.TestSelectionLabel.TabIndex = 0;
            this.TestSelectionLabel.Text = "Selected Test";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(154, 98);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DisclaimerButton
            // 
            this.DisclaimerButton.Location = new System.Drawing.Point(235, 98);
            this.DisclaimerButton.Name = "DisclaimerButton";
            this.DisclaimerButton.Size = new System.Drawing.Size(75, 23);
            this.DisclaimerButton.TabIndex = 6;
            this.DisclaimerButton.Text = "Disclaimer";
            this.DisclaimerButton.UseVisualStyleBackColor = true;
            this.DisclaimerButton.Click += new System.EventHandler(this.DisclaimerButton_Click);
            // 
            // SelectedTestComboBox
            // 
            this.SelectedTestComboBox.FormattingEnabled = true;
            this.SelectedTestComboBox.Location = new System.Drawing.Point(91, 39);
            this.SelectedTestComboBox.Name = "SelectedTestComboBox";
            this.SelectedTestComboBox.Size = new System.Drawing.Size(219, 21);
            this.SelectedTestComboBox.TabIndex = 9;
            this.SelectedTestComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedTestComboBox_SelectedIndexChanged);
            // 
            // DeleteTestButton
            // 
            this.DeleteTestButton.Location = new System.Drawing.Point(73, 160);
            this.DeleteTestButton.Name = "DeleteTestButton";
            this.DeleteTestButton.Size = new System.Drawing.Size(237, 23);
            this.DeleteTestButton.TabIndex = 10;
            this.DeleteTestButton.Text = "DeleteSelectedTest";
            this.DeleteTestButton.UseVisualStyleBackColor = true;
            this.DeleteTestButton.Click += new System.EventHandler(this.DeleteTestButton_Click);
            // 
            // StartTestButton
            // 
            this.StartTestButton.Location = new System.Drawing.Point(73, 98);
            this.StartTestButton.Name = "StartTestButton";
            this.StartTestButton.Size = new System.Drawing.Size(75, 23);
            this.StartTestButton.TabIndex = 11;
            this.StartTestButton.Text = "Start Test";
            this.StartTestButton.UseVisualStyleBackColor = true;
            this.StartTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // CreateTestButton
            // 
            this.CreateTestButton.Location = new System.Drawing.Point(73, 127);
            this.CreateTestButton.Name = "CreateTestButton";
            this.CreateTestButton.Size = new System.Drawing.Size(237, 27);
            this.CreateTestButton.TabIndex = 12;
            this.CreateTestButton.Text = "Create Test";
            this.CreateTestButton.UseVisualStyleBackColor = true;
            this.CreateTestButton.Click += new System.EventHandler(this.CreateTestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 189);
            this.Controls.Add(this.CreateTestButton);
            this.Controls.Add(this.StartTestButton);
            this.Controls.Add(this.DeleteTestButton);
            this.Controls.Add(this.SelectedTestComboBox);
            this.Controls.Add(this.DisclaimerButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TestSelectionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestSelectionLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DisclaimerButton;
        private System.Windows.Forms.ComboBox SelectedTestComboBox;
        private System.Windows.Forms.Button DeleteTestButton;
        private System.Windows.Forms.Button StartTestButton;
        private System.Windows.Forms.Button CreateTestButton;
    }
}

