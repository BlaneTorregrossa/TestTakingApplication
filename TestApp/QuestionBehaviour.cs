﻿using System;
using System.IO;
using System.Windows.Forms;
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
        public string TestPath;
        public QuestionType questionType;
        public string QuestionText;
        public int QuestionNum;
        public bool TFAnswer;
        public int AnswersAvalible;
        public string[] FITBAnswers = new string[10];
        public int FITBRequirment;
        public string[] MCChoices = new string[4];
        public int MCAnswer;
        public bool Entered;

        public QuestionBehaviour()
        {
            Entered = false;
        }

        //  *** TODO:   Change this. What does it do that the other similar function cannot?
        public void MissingInfoPopUp(PopupForm puf, Form pf, string title, string text, bool close)
        {
            //  Popup window
            if (pf != null)
            {
                puf.PrevForm = pf;
                puf.Location = pf.Location;
            }
            puf.StartPosition = FormStartPosition.CenterScreen;
            puf.WarningTitle = title;
            puf.WarningText = text;
            puf.ShowDialog();
            puf.Activate();

            return;
        }
    }
}
