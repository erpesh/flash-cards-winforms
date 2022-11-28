﻿using System;
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
    public partial class TestPage : UserControl
    {
        // attributes
        private CardsSet cardsSet;
        private CardsTest cardsTest;
        private int activeQuestionIndex;

        // getters setters
        public CardsSet CardsSet 
        { 
            set 
            { 
                cardsSet = value;
                cardsTest = null;
                activeQuestionIndex = 0;
            } 
        }

        // constructor
        public TestPage()
        {
            InitializeComponent();

            testQuestionItem.TestPage = this;
        }

        // methods
        public bool IsTestGenerated() { return cardsTest != null; }
        public void GenerateTest()
        {
            lstQuestions.Items.Clear();
            cardsTest = new CardsTest(cardsSet);

            for(int i = 1; i < cardsTest.TestQuestions.Count + 1; i++)
            {
                string formatedNumber = String.Format("   {0}     ", i > 9 ? i : i + " ");
                lstQuestions.Items.Add(formatedNumber);
            }

            testQuestionItem.TestQuestion = cardsTest.TestQuestions[activeQuestionIndex];
            SelectListItem();
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
            btnSubmitTest.Visible = activeQuestionIndex == cardsTest.TestQuestions.Count - 1;
        }
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
            activeQuestionIndex = -1;
            cardsTest.SubmitTest();
            SelectListItem();
            lblQuestionsList.Visible = false;
            lstQuestions.Visible = false;
            testQuestionItem.Visible = false;
            btnPrevQuestion.Visible = false;
            btnSubmitTest.Visible = false;
        }
    }
}