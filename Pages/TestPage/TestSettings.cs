using FlashCards.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards.Pages.TestPage
{
    public partial class TestSettings : Form
    {
        // data
        private CardsSet cardsSet;
        private int numOfQuestions;
        private bool toStarCorrectAnswers;
        private bool useOnlyStarredCards;
        private bool isFormSubmitted;

        // getters setters
        public int NumOfQuestions { get { return numOfQuestions; } }
        public bool ToStarCorrectAnswers { get { return toStarCorrectAnswers; } }
        public bool UseOnlyStarredCards { get { return useOnlyStarredCards; } }
        public bool IsFormSubmitted { get { return isFormSubmitted; } }
        
        // constructor
        public TestSettings(CardsSet cardsSet)
        {
            InitializeComponent();
            this.cardsSet = cardsSet;
        }
        
        // event functions
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckNumOfQuestions())
            {
                isFormSubmitted = true;
                toStarCorrectAnswers = cbStarCorrect.Checked;
                useOnlyStarredCards = cbUseStarred.Checked;
                numOfQuestions = (int)nudNumberOfQuestions.Value;
                Close();
            }
        }
        
        // member functions
        private bool CheckNumOfQuestions()
        {
            if (nudNumberOfQuestions.Value <= 5)
            {
                lblError.Text = "Number of questions should be greater than 5";
                return false;
            }
            if (cbUseStarred.Checked)
            {
                int numOfStarredQuestions = cardsSet.GetStarredCards().Count;
                bool condition = nudNumberOfQuestions.Value <= numOfStarredQuestions;
                if (!condition) lblError.Text = "There are only " + numOfStarredQuestions + " starred cards"; ;
                return condition;
            }
            else
            {
                bool condition = nudNumberOfQuestions.Value <= cardsSet.Cards.Count;
                if (!condition) lblError.Text = "There are only " + cardsSet.Cards.Count + " cards";
                return condition;
            }
        }
    }
}
