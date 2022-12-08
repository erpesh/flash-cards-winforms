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

            timeInSeconds--;
            string timeString = TimeToString();
            lblTime.Text = timeString;
        }
        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // changing testQuestionItem on changing of selected item in the listBox
            activeQuestionIndex = int.Parse(lstQuestions.GetItemText(lstQuestions.SelectedItem).Trim()) - 1;
            testQuestionItem.TestQuestion = cardsTest.TestQuestions[activeQuestionIndex];
            NavigationButtonsUpdate();
        }

        // member functions
        private void Reset()
        {
            cardsTest = null;
            activeQuestionIndex = 0;
            isTestSubmited = false;
            testQuestionItem.IsTestSubmited = false;

            timer.Stop();
        }
        public void GenerateTest(int numOfQuestions, bool toStarCorrectAnswers, bool useOnlyUnstarredCards)
        {
            Reset();
            cardsTest = new CardsTest(cardsSet, numOfQuestions, toStarCorrectAnswers, useOnlyUnstarredCards);

            // updating listbox
            lstQuestions.Items.Clear();
            for(int i = 1; i < cardsTest.TestQuestions.Count + 1; i++)
            {
                lstQuestions.Items.Add(i);
            }

            testQuestionItem.TestQuestion = cardsTest.TestQuestions[activeQuestionIndex];
            SelectListItem();
            StartTimer();
        }
        private void SelectListItem()
        {
            if (lstQuestions.Items.Count > 0 && activeQuestionIndex >= 0)
                lstQuestions.SelectedIndex = activeQuestionIndex;
        }
        public void UpdateQuestion(bool isNext)
        {
            if (isNext) activeQuestionIndex++;
            else activeQuestionIndex--;

            testQuestionItem.TestQuestion = cardsTest.TestQuestions[activeQuestionIndex];
            SelectListItem();
        }
        private void NavigationButtonsUpdate()
        { // changing buttons visibility
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
            lblTimerTitle.Visible = timeInSeconds != 0;
            lblTime.Visible = timeInSeconds != 0;
            if (timeInSeconds != 0) timer.Start();
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
