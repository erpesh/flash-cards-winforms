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
        private int timeInMinutes;
        private bool isFormSubmitted;

        // getters setters
        public int NumOfQuestions { get { return numOfQuestions; } }
        public bool ToStarCorrectAnswers { get { return toStarCorrectAnswers; } }
        public bool UseOnlyStarredCards { get { return useOnlyStarredCards; } }
        public int TimeInMinutes { get { return timeInMinutes; } }
        public bool IsFormSubmitted { get { return isFormSubmitted; } }
        
        // constructor
        public TestSettings(CardsSet cardsSet)
        {
            InitializeComponent();
            this.cardsSet = cardsSet;
            ManageControls();

            numOfQuestions = (int)nudNumberOfQuestions.Minimum;
            timeInMinutes = (int)nudTimeInMinutes.Minimum;
        }
        
        // event functions
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            isFormSubmitted = true;
            Close();
        }
        private void nudNumberOfQuestions_ValueChanged(object sender, EventArgs e)
        {
            numOfQuestions = (int)nudNumberOfQuestions.Value;
        }
        private void cbStarCorrect_CheckedChanged(object sender, EventArgs e)
        {
            toStarCorrectAnswers = cbStarCorrect.Checked;
        }
        private void cbUseStarred_CheckedChanged(object sender, EventArgs e)
        {
            useOnlyStarredCards = cbUseStarred.Checked;
            ManageControls();
        }
        private void cbUseTimer_CheckedChanged(object sender, EventArgs e)
        {
            nudTimeInMinutes.Enabled = !nudTimeInMinutes.Enabled;
            timeInMinutes = cbUseTimer.Checked ? (int)nudTimeInMinutes.Value : 0;
        }


        private void nudTimeInMinutes_ValueChanged(object sender, EventArgs e)
        {
            timeInMinutes = (int)nudTimeInMinutes.Value;
        }
        
        // member functions
        private void ManageControls()
        {
            int numOfStarredCards = cardsSet.GetNumberOfStarredCards();
            if (numOfStarredCards < nudNumberOfQuestions.Minimum)
            {
                cbUseStarred.Enabled = false;
            }
            else
            {
                cbUseStarred.Enabled = true;
                nudNumberOfQuestions.Maximum = numOfStarredCards;
            }
            if (!cbUseStarred.Checked)
            {
                nudNumberOfQuestions.Maximum = cardsSet.Cards.Count;
            }
        }

    }
}
