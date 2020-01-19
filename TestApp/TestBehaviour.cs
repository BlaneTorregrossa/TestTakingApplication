using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class TestBehaviour
    {
        public string TestPath;
        public string TestTitle;
        public int MaxTime;
        public int RemainingTime;
        public int QuestionSize;
        public QuestionBehaviour[] Questions = new QuestionBehaviour[99];
    }
}
