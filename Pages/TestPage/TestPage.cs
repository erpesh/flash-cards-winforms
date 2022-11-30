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
using FlashCards.Pages.TestPage;

namespace FlashCards.TestPage
{
    public partial class TestPage : UserControl
    {
        // data
        private CardsSet cardsSet;
        private CardsTest cardsTest;
        private int activeQuestionIndex;
        private bool isTestSubmited;
        private int timeInSeconds;

        // getters setters
        public CardsSet CardsSet { set { cardsSet = value; } }
        public int TimeInSeconds
        {
            set
            {
                timeInSeconds = value;
                lblTime.Text = TimeToString();
            }
        }

        // constructor
        public TestPage()
        {
            InitializeComponent();
        }

        // event functions
        private void btnPrevQuestion_Click(object sender, EventArgs e)
        {
            UpdateQuestion(false);
            NavigationButtonsUpdate();
        }
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            UpdateQuestion(true);
            NavigationButtonsUpdate();
        }
        private void btnSubmitTest_Click(object sender, EventArgs e)
        {
            SubmitTest();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeInSeconds == 0) SubmitTest();

            string timeString = TimeToString();
            timeInSeconds--;
            lblTime.Text = timeString;
        }

        // member functions
        private void Reset()
        {
            cardsTest = null;
            activeQuestionIndex = 0;
            isTestSubmited = false;
            testQuestionItem.IsTestSubmited = false;
        }
        public void GenerateTest(int numOfQuestions, bool toStarCorrectAnswers, bool useOnlyStarredCards)
        {
            Reset();
            cardsTest = new CardsTest(cardsSet, numOfQuestions, toStarCorrectAnswers, useOnlyStarredCards);

            lstQuestions.Items.Clear();
            for(int i = 1; i < cardsTest.TestQuestions.Count + 1; i++)
            {
                string formatedNumber = String.Format("   {0}     ", i > 9 ? i : i + " ");
                lstQuestions.Items.Add(formatedNumber);
            }

            testQuestionItem.TestQuestion = cardsTest.TestQuestions[activeQuestionIndex];
            SelectListItem();
            StartTimer();
        }
        private void SelectListItem()
        {
            foreach (ListViewItem item in lstQuestions.Items)
            {
                item.Selected = false;
            }
            if (lstQuestions.Items.Count > 0 && activeQuestionIndex >= 0) 
                lstQuestions.Items[activeQuestionIndex].Selected = true;
        }
        private void QuestionsList_IndexChange(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedItems.Count == 0) return;
            activeQuestionIndex = int.Parse(lstQuestions.SelectedItems[0].Text.Trim()) - 1;
            testQuestionItem.TestQuestion = cardsTest.TestQuestions[activeQuestionIndex];
            NavigationButtonsUpdate();
        }
        public void UpdateQuestion(bool isNext)
        {
            if (isNext) activeQuestionIndex++;
            else activeQuestionIndex--;

            testQuestionItem.TestQuestion = cardsTest.TestQuestions[activeQuestionIndex];
            SelectListItem();
        }
        private void NavigationButtonsUpdate()
        {
            btnPrevQuestion.Visible = activeQuestionIndex != 0;
            btnNextQuestion.Visible = activeQuestionIndex != cardsTest.TestQuestions.Count - 1;
            btnSubmitTest.Visible = !isTestSubmited && activeQuestionIndex == cardsTest.TestQuestions.Count - 1;
        }
        private void OpenResultsWindow()
        {
            TestResults tr = new TestResults();
            int numberOfCorrectAnswers = cardsTest.GetNumberOfCorrectAnswers();
            int numberOfIncorrectAnswers = cardsTest.TestQuestions.Count - numberOfCorrectAnswers;
            tr.SetTestResults(numberOfCorrectAnswers, numberOfIncorrectAnswers);
            tr.ShowDialog();
        }
        private void SubmitTest()
        {
            timer.Stop();
            OpenResultsWindow();

            cardsTest.SubmitTest();
            isTestSubmited = true;
            testQuestionItem.IsTestSubmited = true;
            activeQuestionIndex = 0;
            SelectListItem();
        }
        private void StartTimer()
        {
            if (timeInSeconds != 0) timer.Start();
            else
            {
                lblTimerTitle.Visible = false;
                lblTime.Visible = false;
            }
        }
        private string TimeToString()
        {
            int seconds = timeInSeconds % 60;
            int minutes = timeInSeconds / 60;
            string timeString = string.Format("{0:D2}:{1:D2}", minutes, seconds);
            return timeString;
        }
    }
}
