using System.Windows.Forms;
using FlashCards.Models;
using FlashCards.Pages.TestPage;

namespace FlashCards
{
    public partial class MainForm : Form
    {
        // data
        private CardsSet cardsSet;
        private bool isGoBackToSetsList;
        private bool isCardSetDeleted;

        // getters setters
        public CardsSet CardsSet { get { return cardsSet; } }
        public bool IsGoBackToSetsList { get { return isGoBackToSetsList; } }
        public bool IsCardSetDeleted { get { return isCardSetDeleted; } }

        // constructor
        public MainForm(string cardSetName)
        {
            InitializeComponent();

            btnGoBack.BackgroundImage = Image.FromFile("icons/arrow-left.png");
            cardsSet = new CardsSet(cardSetName);
            mainPage1.BringToFront();
            mainPage1.MainForm = this;
            mainPage1.CardsSet = cardsSet;
            learnPage1.CardsSet = cardsSet;
            testPage1.CardsSet = cardsSet;
        }

        // code copied from https://stackoverflow.com/questions/34006951/prevent-button-from-being-focused-by-arrow-key-click
        // removes button focus on arrow keys pressing
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!msg.HWnd.Equals(Handle) &&
                (keyData == Keys.Left || keyData == Keys.Right ||
                 keyData == Keys.Up || keyData == Keys.Down))
                return true;
            return base.ProcessCmdKey(ref msg, keyData);
        }
        // event functions
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            mainPage1.BringToFront();
        }
        private void btnLearnPage_Click(object sender, EventArgs e)
        {
            learnPage1.BringToFront();
        }
        private void btnTestPage_Click(object sender, EventArgs e)
        {
            TestSettings ts = new TestSettings(cardsSet);
            ts.ShowDialog();

            if (ts.IsFormSubmitted)
            {
                testPage1.TimeInSeconds = ts.TimeInMinutes * 60;
                testPage1.GenerateTest(
                    ts.NumOfQuestions, 
                    ts.ToStarCorrectAnswers, 
                    ts.UseOnlyStarredCards);
                testPage1.BringToFront();
            }
        }
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            isGoBackToSetsList = true;
            Close();
        }

        // member functions
        public void UpdateLearnPage()
        {
            learnPage1.UpdateCardDisplay();
        }
        public void ResetTestPage()
        {
            testPage1.CardsSet = cardsSet;
        }
        public void DeleteCardSet()
        {
            isGoBackToSetsList = true;
            isCardSetDeleted = true;
            Close();
        }
    }
}