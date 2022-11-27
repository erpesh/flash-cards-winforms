using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards.TestPage
{
    public partial class TestQuestionItem : UserControl
    {
        // attributes
        private enum ButtonIndex
        {
            First = 0, 
            Second = 1, 
            Third = 2, 
            Fourth = 3,
        }
        private TestPage testPage;
        private TestQuestion testQuestion;

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

        // constructor
        public TestQuestionItem()
        {
            InitializeComponent();
        }

        //methods
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

            if (testQuestion.IsAnswered)
            {
                if (testQuestion.AnswerIndex == 0) btnAnswer1.BackColor = Color.LightGreen;
                else if (testQuestion.AnswerIndex == 1) btnAnswer2.BackColor = Color.LightGreen;
                else if (testQuestion.AnswerIndex == 2) btnAnswer3.BackColor = Color.LightGreen;
                else if (testQuestion.AnswerIndex == 3) btnAnswer4.BackColor = Color.LightGreen;
            }
        }
        private void HandleAnswerButtonClick(ButtonIndex buttonIndex)
        {
            testQuestion.AnswerIndex = (int)buttonIndex;
            UpdateTestQuestionItem();
        }
        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            HandleAnswerButtonClick(ButtonIndex.First);
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            HandleAnswerButtonClick(ButtonIndex.Second);
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            HandleAnswerButtonClick(ButtonIndex.Third);
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            HandleAnswerButtonClick(ButtonIndex.Fourth);
        }
    }
}
