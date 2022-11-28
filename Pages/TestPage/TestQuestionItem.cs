using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlashCards.Models;

namespace FlashCards.TestPage
{
    public partial class TestQuestionItem : UserControl
    {
        // data
        private TestPage testPage;
        private TestQuestion testQuestion;
        private bool isTestSubmited;

        // getters setters
        public TestPage TestPage { set { testPage = value; } }
        public TestQuestion TestQuestion
        {
            get { return testQuestion; }
            set
            {
                if (value == null) return;
                testQuestion = value;
                UpdateTestQuestionItem();
            }
        }
        public bool IsTestSubmited { set { isTestSubmited = value; } }
        // constructor
        public TestQuestionItem()
        {
            InitializeComponent();
        }

        // event functions
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            int buttonIndex = 0;
            if (sender == btnAnswer2) buttonIndex = 1;
            else if (sender == btnAnswer3) buttonIndex = 2;
            else if (sender == btnAnswer4) buttonIndex = 3;

            HandleAnswerButtonClick(buttonIndex);
        }

        // member functions
        private void UpdateTestQuestionItem()
        {
            lblTerm.Text = testQuestion.CardItem.Term;
            btnAnswer1.Text = testQuestion.PossibleAnswers[0];
            btnAnswer2.Text = testQuestion.PossibleAnswers[1];
            btnAnswer3.Text = testQuestion.PossibleAnswers[2];
            btnAnswer4.Text = testQuestion.PossibleAnswers[3];

            btnAnswer1.BackColor = SystemColors.ButtonFace;
            btnAnswer2.BackColor = SystemColors.ButtonFace;
            btnAnswer3.BackColor = SystemColors.ButtonFace;
            btnAnswer4.BackColor = SystemColors.ButtonFace;

            if (isTestSubmited)
            {
                if (testQuestion.CorrectAnswerIndex == 0) btnAnswer1.BackColor = Color.LightGreen;
                else if (testQuestion.CorrectAnswerIndex == 1) btnAnswer2.BackColor = Color.LightGreen;
                else if (testQuestion.CorrectAnswerIndex == 2) btnAnswer3.BackColor = Color.LightGreen;
                else if (testQuestion.CorrectAnswerIndex == 3) btnAnswer4.BackColor = Color.LightGreen;
                
                if (testQuestion.IsAnswered && !testQuestion.IsCorrect)
                {
                    if (testQuestion.AnswerIndex == 0) btnAnswer1.BackColor = Color.PaleVioletRed;
                    else if (testQuestion.AnswerIndex == 1) btnAnswer2.BackColor = Color.PaleVioletRed;
                    else if (testQuestion.AnswerIndex == 2) btnAnswer3.BackColor = Color.PaleVioletRed;
                    else if (testQuestion.AnswerIndex == 3) btnAnswer4.BackColor = Color.PaleVioletRed;
                }
            }
            else
            {
                if (testQuestion.IsAnswered)
                {
                    if (testQuestion.AnswerIndex == 0) btnAnswer1.BackColor = Color.LightBlue;
                    else if (testQuestion.AnswerIndex == 1) btnAnswer2.BackColor = Color.LightBlue;
                    else if (testQuestion.AnswerIndex == 2) btnAnswer3.BackColor = Color.LightBlue;
                    else if (testQuestion.AnswerIndex == 3) btnAnswer4.BackColor = Color.LightBlue;
                }
            }
        }
        private void HandleAnswerButtonClick(int buttonIndex)
        {
            testQuestion.AnswerIndex = buttonIndex;
            UpdateTestQuestionItem();
        }
    }
}
