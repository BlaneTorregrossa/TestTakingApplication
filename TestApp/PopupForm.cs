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

        //  Return to the previous form
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrevForm.Activate();
            this.Close();
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WarningLabel_Click(object sender, EventArgs e)
        {

        }

        //  Form information set on load
        private void PopupForm_Load(object sender, EventArgs e)
        {
            this.Text = "Something went wrong!";
            this.Tag = "PopUp";
            WarningLabel.Text = WarningTitle;
            DescriptionTextBox.Text = WarningText;
        }
    }
}
