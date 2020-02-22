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
    public partial class PopupForm : Form
    {
        public string WarningTitle;
        public string WarningText;
        public Form PrevForm;

        public PopupForm()
        {
            InitializeComponent();
        }

        //  **  Do a Check if a tag doesn't match listed one + minor rework
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (PrevForm.Tag == "Question")
            {
                PrevForm = new NewTestForm();
            }
            if (PrevForm.Tag == "Test")
            {
                PrevForm = new TestSettingsForm();
            }
            PrevForm.Location = this.Location;
            PrevForm.StartPosition = FormStartPosition.Manual;
            PrevForm.ShowDialog();
            PrevForm.Activate();
            this.Close();
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WarningLabel_Click(object sender, EventArgs e)
        {

        }

        private void PopupForm_Load(object sender, EventArgs e)
        {
            this.Tag = "PopUp";
            WarningLabel.Text = WarningTitle;
            DescriptionTextBox.Text = WarningText;
        }
    }
}
