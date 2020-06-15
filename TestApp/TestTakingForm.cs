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

        public TestTakingForm()
        {
            InitializeComponent();
        }

        private void TestTakingForm_Load(object sender, EventArgs e)
        {
            FileReaderInstance = new FileReader();
            CurrentTestInformation = FileReaderInstance.SaveInformation(CurrentTestInformation.TestPath);
        }
    }
}
