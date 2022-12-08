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
        private bool useOnlyUnstarredCards;
        private int timeInMinutes;
        private bool isFormSubmitted;

        // getters setters
        public int NumOfQuestions { get { return numOfQuestions; } }
        public bool ToStarCorrectAnswers { get { return toStarCorrectAnswers; } }
        public bool UseOnlyUnstarredCards { get { return useOnlyUnstarredCards; } }
        public int TimeInMinutes { get { return timeInMinutes; } }
        public bool IsFormSubmitted { get { return isFormSubmitted; } }
        
        // constructor
        public TestSettings(CardsSet cardsSet)
        {
            this.cardsSet = cardsSet;

            InitializeComponent();

            ManageControls();

            numOfQuestions = (int)nudNumberOfQuestions.Minimum;
            timeInMinutes = 0;
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
            useOnlyUnstarredCards = cbUseUnstarred.Checked;
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
            int numOfUnstarredCards = cardsSet.GetUnstarredCards().Count;
            if (numOfUnstarredCards < nudNumberOfQuestions.Minimum)
            {   // disabling useStarred checkbox is there is less then minimum
                cbUseUnstarred.Enabled = false;
            }
            else
            {   // enabling useStarred checkbox and sets maximum value to the number of unstarred cards
                cbUseUnstarred.Enabled = true;
                nudNumberOfQuestions.Maximum = numOfUnstarredCards;
            }
            if (!cbUseUnstarred.Checked)
            {   // sets maximum questions value to the number of all cards;
                nudNumberOfQuestions.Maximum = cardsSet.Cards.Count;
            }
        }
    }
}
