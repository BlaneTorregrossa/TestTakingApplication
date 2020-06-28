using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{

    //  Types of question
    public enum QuestionType
    {
        None = 0,
        TrueFalse = 1,
        FillInTheBlank = 2,
        MultipleChoice = 3
    }

    public class QuestionBehaviour
    {
        public string TestPath; //  Test this question is associated with
        public QuestionType questionType;   //  Type of question
        public string QuestionText; //  Question text
        public int QuestionNum; //  Question number for test
        public bool TFAnswer;   //  Answer for question if it's a True/False question
        public bool TFUserChoice;   //  User Given choice for question if it's a True/False question
        public int AnswersAvalible; //  Answers avalible (interger count) for Fill in the Blank question
        public string[] FITBAnswers = new string[10];   //  Answers for Fill in the Blank questions
        public int FITBRequirment;  //  Required amount of answers for Fill in the Blank questions
        public string[] FITBUserChoices = new string[10];   //  The answers the user gives for Fill in the Blank questions
        public string[] MCChoices = new string[4];  //  Choices for multiple choice questions
        public int MCAnswer;    //  Multiple choice question answer for the question
        public int MCUserChoice;    //  User choice for multiple choice questions
        public bool Entered;    //  If answer was entered on question
        public float Score; //  Score for individual question

        public QuestionBehaviour()
        {
            Entered = false;
            Score = 0;
            MCUserChoice = -1;
            for (int i = 0; i < 9; i++)
            {
                FITBUserChoices[i] = null;
            }
        }
    }
}
