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
            //cbUseStarred.Checked = false;
            //cbUseStarred.Enabled = !cbUseStarred.Enabled;
        }
        private void cbUseStarred_CheckedChanged(object sender, EventArgs e)
        {
            useOnlyUnstarredCards = cbUseStarred.Checked;
            //cbStarCorrect.Checked = false;
            //cbStarCorrect.Enabled = !cbStarCorrect.Enabled;
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
            {
                cbUseStarred.Enabled = false;
            }
            else
            {
                cbUseStarred.Enabled = true;
                nudNumberOfQuestions.Maximum = numOfUnstarredCards;
            }
            if (!cbUseStarred.Checked)
            {
                nudNumberOfQuestions.Maximum = cardsSet.Cards.Count;
            }
        }
    }
}
