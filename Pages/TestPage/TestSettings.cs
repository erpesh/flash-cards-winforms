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
        }
        
        // event functions
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            isFormSubmitted = true;
            toStarCorrectAnswers = cbStarCorrect.Checked;
            useOnlyStarredCards = cbUseStarred.Checked;
            numOfQuestions = (int)nudNumberOfQuestions.Value;
            timeInMinutes = cbUseTimer.Checked ? (int)nudTimeInMinutes.Value : 0;
            Close();
        }
        private void cbUseTimer_CheckedChanged(object sender, EventArgs e)
        {
            nudTimeInMinutes.Enabled = !nudTimeInMinutes.Enabled;
        }
        
        // member functions
        private void ManageControls()
        {
            int numOfStarredCards = cardsSet.GetNumberOfStarredCards();
            if (numOfStarredCards < 6)
            {
                cbUseStarred.Enabled = false;
            }
            else
            {
                cbUseStarred.Enabled = true;
                nudNumberOfQuestions.Maximum = numOfStarredCards;
            }
            if (!cbUseStarred.Enabled)
            {
                nudNumberOfQuestions.Maximum = cardsSet.Cards.Count;
            }
        }
    }
}
