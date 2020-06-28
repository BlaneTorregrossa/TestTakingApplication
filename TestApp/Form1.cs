using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestApp
{
    public partial class Form1 : Form
    {
        FileReader StartingFileReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Simple Test Taker";
            StartingFileReader = new FileReader();
            string[] fileNames = null;
            this.Tag = "Start";
            fileNames = Directory.GetFiles("Tests");
            StartingFileReader.ReadTestsDropDown("Tests", SelectedTestComboBox);    //  Populate Combo Box with valid tests after passing checks to see if tests are valid
        }

        //  Exit application when clicked
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //  Displays disclaimer window in the same position as this window and hides this form window.
        private void DisclaimerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new DisclaimerForm
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.ShowDialog();
            frm.Activate();
            this.Close();
        }

        private void SelectedTestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //  Open Test Taking Form on button click when Combo Box has a valid selected test
        private void StartTestButton_Click(object sender, EventArgs e)
        {
            if (SelectedTestComboBox.Text != "")
            {
                this.Hide();
                var frm = new TestTakingForm
                {
                    CurrentTestInformation = new TestBehaviour(),
                    Location = this.Location,
                    StartPosition = FormStartPosition.Manual
                };
                frm.CurrentTestInformation.TestPath = SelectedTestComboBox.Text;
                frm.ShowDialog();
                frm.Activate();
                this.Close();
            }
        }

        //  Open Form for Test Settings to start creating a new test
        private void CreateTestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new TestSettingsForm
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.ShowDialog();
            frm.Activate();
            this.Close();
        }
    }
}
