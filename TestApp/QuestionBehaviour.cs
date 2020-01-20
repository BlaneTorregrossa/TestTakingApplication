using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public enum QuestionType
    {
        None = 0,
        TrueFalse = 1,
        FillInTheBlank = 2,
        MultipleChoice = 3
    }

    public class QuestionBehaviour
    {
        public QuestionType questionType;
        public string Question;
        public int QuestionNum;
        public bool TFAnswer;
        public int AnswersAvalible;
        public string[] FITBAnswers = new string[10];
        public int FITBRequirment;
        public string[] MCChoices = new string[4];
        public int MCAnswer;
    }
}
