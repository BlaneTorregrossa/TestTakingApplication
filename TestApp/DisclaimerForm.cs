﻿using System;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void DisclaimerForm_Load(object sender, EventArgs e)
        {

        }
    }
}