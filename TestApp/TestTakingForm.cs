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
    public partial class TestTakingForm : Form
    {
        public TestBehaviour CurrentTestInformation;
        private FileReader FileReaderInstance;
        private int timeLeft;


        public TestTakingForm()
        {
            InitializeComponent();
        }

        private void TestTakingForm_Load(object sender, EventArgs e)

        {
            FileReaderInstance = new FileReader();
            CurrentTestInformation = FileReaderInstance.SaveInformation(CurrentTestInformation.TestPath);
            timeLeft = CurrentTestInformation.MaxTime;
            Timer.Start();
        }

        private void RemainingTimeLabel_Click(object sender, EventArgs e)
        {
        
        }

        private void QuestionNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                int hours, min, sec;

                timeLeft = timeLeft - 1;
                sec = timeLeft % 60;
                min = timeLeft / 60 / 60;
                hours = timeLeft / 60 / 60 / 24;
                RemainingTimeLabel.Text = "Time: Hours: " + hours.ToString() +
                    " Minutes: " + min.ToString() + " Seconds: " + sec.ToString();
            }
            else
            {
                Timer.Stop();
                //  TODO:   Block out all buttons besides the submit button
            }
        }
    }
}
