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
                lblTerm.Text = value.CardItem.Term;
                btnAnswer1.Text = value.PossibleAnswers[0];
                btnAnswer2.Text = value.PossibleAnswers[1];
                btnAnswer3.Text = value.PossibleAnswers[2];
                btnAnswer4.Text = value.PossibleAnswers[3];
            }
        }

        // constructor
        public TestQuestionItem()
        {
            InitializeComponent();
        }

        //methods
        private void HandleButtonClick(ButtonIndex buttonIndex)
        {
            testQuestion.SetAnswer((int)buttonIndex);
            testPage.SetNextQuestion();
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            HandleButtonClick(ButtonIndex.First);
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            HandleButtonClick(ButtonIndex.Second);
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            HandleButtonClick(ButtonIndex.Third);
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            HandleButtonClick(ButtonIndex.Fourth);
        }
    }
}
