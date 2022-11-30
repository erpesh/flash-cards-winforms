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
        private void btnAnswer_Hover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text.Length > 20)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show(AddNewLinesToString(btn.Text), btn, 30000);
            }
        }

        // remove answer on click


        // member functions
        private void UpdateAnswerButton(Button btn, int index)
        {
            btn.Text = testQuestion.PossibleAnswers[index];
            btn.BackColor = SystemColors.ButtonFace;
        }
        private void UpdateTestQuestionItem()
        {
            lblTerm.Text = testQuestion.CardItem.Term;
            UpdateAnswerButton(btnAnswer1, 0);
            UpdateAnswerButton(btnAnswer2, 1);
            UpdateAnswerButton(btnAnswer3, 2);
            UpdateAnswerButton(btnAnswer4, 3);

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
        private string AddNewLinesToString(string str)
        {
            if (str.Length < 200) return str;
            var listOfSubstrings = Enumerable.Range(0, str.Length / 200)
                .Select(i => str.Substring(i * 200, 200));
            return string.Join("\n", listOfSubstrings);
        }
    }
}
