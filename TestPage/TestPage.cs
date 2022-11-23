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
    public partial class TestPage : UserControl
    {
        private CardsSet cardsSet;
        private CardsTest cardsTest;
        private int activeQuestionIndex = 0;
        public CardsSet CardsSet { set { cardsSet = value; } }
        public TestPage()
        {
            InitializeComponent();

            testQuestionItem.TestPage = this;
        }
        public bool IsTestGenerated() { return cardsTest != null; }
        public void GenerateTest()
        {
            cardsTest = new CardsTest(cardsSet);
            for(int i = 0; i < cardsTest.TestQuestions.Count; i++)
            {
                string formatedNumber = String.Format("   {0}     ", i > 9 ? i : i + " ");
                lstQuestions.Items.Add(formatedNumber);
            }
            testQuestionItem.TestQuestion = cardsTest.TestQuestions[activeQuestionIndex];
        }
        private void QuestionsList_IndexChange(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedItems.Count == 0) return;
            activeQuestionIndex = int.Parse(lstQuestions.SelectedItems[0].Text.Trim());
            testQuestionItem.TestQuestion = cardsTest.TestQuestions[activeQuestionIndex];
        }
        public void SetNextQuestion()
        {
            activeQuestionIndex++;
            testQuestionItem.TestQuestion = cardsTest.TestQuestions[activeQuestionIndex];
        }
    }
}
