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

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            var frm = PrevForm;
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WarningLabel_Click(object sender, EventArgs e)
        {

        }

        private void PopupForm_Load(object sender, EventArgs e)
        {
            WarningLabel.Text = WarningTitle;
            DescriptionTextBox.Text = WarningText;
        }
    }
}
