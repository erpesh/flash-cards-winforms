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
        private TestQuestion testQuestion;
        private bool isTestSubmited;
        private List<Button> buttons;

        // getters setters
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

            buttons = new List<Button> { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };
        }

        // event functions
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                if (sender == buttons[i])
                {
                    HandleAnswerButtonClick(i);
                    return;
                }
            }
        }
        private void btnAnswer_Hover(object sender, EventArgs e)
        {   // sets tooltip for button it's value too long
            Button btn = sender as Button;
            if (btn.Text.Length > 20)
            {
                toolTip1.Show(btn.Text, btn, 30000);
            }
        }

        // member functions
        private void UpdateAnswerButtons()
        {   // sets text and resets background color for answer buttons
            for (int i = 0; i < testQuestion.NumberOfAnswers; i++)
            {
                buttons[i].Text = testQuestion.PossibleAnswers[i];
                buttons[i].BackColor = SystemColors.ButtonFace;
            }
        }
        private void UpdateTestQuestionItem()
        {
            lblTerm.Text = testQuestion.CardItem.Term;

            UpdateAnswerButtons();

            if (isTestSubmited)
            {
                // highlighting correct answer
                buttons[testQuestion.CorrectAnswerIndex].BackColor = Color.LightGreen;
                
                // highlighting incorrect answer
                if (testQuestion.IsAnswered && !testQuestion.IsCorrect)
                    buttons[testQuestion.AnswerIndex].BackColor = Color.PaleVioletRed;
            }
            else if (testQuestion.IsAnswered)
                // highlighting selected answer
                buttons[testQuestion.AnswerIndex].BackColor = Color.LightBlue;

            // update skipped text
            lblSkipped.Text = isTestSubmited && !testQuestion.IsAnswered ? "Skipped" : "";
        }
        private void HandleAnswerButtonClick(int buttonIndex)
        {
            if (buttonIndex == testQuestion.AnswerIndex) buttonIndex = -1;
            testQuestion.AnswerIndex = buttonIndex;
            UpdateTestQuestionItem();
        }
    }
}
