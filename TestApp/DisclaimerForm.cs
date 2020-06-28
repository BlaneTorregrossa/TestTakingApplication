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
    public partial class DisclaimerForm : Form
    {

        public DisclaimerForm()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new Form1
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.ShowDialog();
            frm.Activate();
            this.Close();
        }

        private void DisclaimerForm_Load(object sender, EventArgs e)
        {
            this.Text = "Disclaimer";
            this.Tag = "Disclaimer";
            textBox1.Text = "This program was made for personal use. " +
                "This is not recommended for secure test taking, as everything is very easy to manipulate. " +
                "This is for personal use to quiz/test oneself without having to self grade. " +
                "If you paid for this you have been scammed as this application is free. " +
                "Current Version is 1.0.0";
        }
    }
}
