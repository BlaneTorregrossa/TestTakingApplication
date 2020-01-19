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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //  Have a confirmation box appear with this.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //  Displays disclamer window in the same position as this window and hides this form window.
        private void DisclaimerButton_Click(object sender, EventArgs e)
        {
            var frm = new DisclaimerForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void SelectedTestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteTestButton_Click(object sender, EventArgs e)
        {

        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateTestButton_Click(object sender, EventArgs e)
        {
            var frm = new TestSettingsForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
