using System.Windows.Forms;
using FlashCards.Models;
using FlashCards.Pages.TestPage;

namespace FlashCards
{
    public partial class MainForm : Form
    {
        // data
        private const int minValueForTestPage = 4;
        private const int minValueForLearnPage = 2;
        
        private CardsSet cardsSet;
        private bool isGoBackToSetsList;
        private bool isCardSetDeleted;

        private bool isToolTipShown;
        private string activeToolTip;
        private Button activePageButton;

        // getters setters
        public CardsSet CardsSet { get { return cardsSet; } }
        public bool IsGoBackToSetsList { get { return isGoBackToSetsList; } }
        public bool IsCardSetDeleted { get { return isCardSetDeleted; } }

        // constructor
        public MainForm(string cardSetName)
        {
            InitializeComponent();
            
            activePageButton = btnMainPage;
            btnGoBack.BackgroundImage = Properties.Resources.arrowLeft;
            cardsSet = new CardsSet(cardSetName);
            mainPage1.BringToFront();
            mainPage1.MainForm = this;
            mainPage1.CardsSet = cardsSet;
            learnPage1.CardsSet = cardsSet;
            testPage1.CardsSet = cardsSet;

            UpdateDisplay();
        }

        // code copied from https://stackoverflow.com/a/34007030/17384975
        // prevents buttons from being focused by arrow keys press
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
            activePageButton = btnMainPage;
            UpdateNavButtonsColors();
        }
        private void btnLearnPage_Click(object sender, EventArgs e)
        {
            learnPage1.BringToFront();
            activePageButton = btnLearnPage;
            UpdateNavButtonsColors();
        }
        private void btnTestPage_Click(object sender, EventArgs e)
        {
            TestSettings ts = new TestSettings(cardsSet);
            ts.ShowDialog();

            if (ts.IsFormSubmitted) // if the user doesn't close the test settings form
            {
                testPage1.TimeInSeconds = ts.TimeInMinutes * 60;
                testPage1.GenerateTest(
                    ts.NumOfQuestions, 
                    ts.ToStarCorrectAnswers, 
                    ts.UseOnlyUnstarredCards);

                testPage1.BringToFront();
                activePageButton = btnTestPage;
                UpdateNavButtonsColors();
            }
        }
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            isGoBackToSetsList = true;
            Close();
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {   // sets tooltips for disabled buttons
            if (cardsSet.Cards.Count >= minValueForTestPage) return; // if both buttons are enabled the functions isn't going to run

            Control ctrl = GetChildAtPoint(e.Location);
            if (ctrl == btnLearnPage && !isToolTipShown && !btnLearnPage.Enabled)
                SetToolTipToButton(btnLearnPage, "Card set should consist of " + minValueForLearnPage + " or more cards to access Learn page");
            else if (ctrl == btnTestPage && !isToolTipShown && !btnTestPage.Enabled)
                SetToolTipToButton(btnTestPage, "Card set should consist of " + minValueForTestPage + " or more cards to access Test page");
            else if (ctrl is not Button && isToolTipShown)
                HideToolTipOnButton();
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
        private void UpdateNavButtonsColors()
        {
            btnMainPage.BackColor = SystemColors.Control;
            btnLearnPage.BackColor = SystemColors.Control;
            btnTestPage.BackColor = SystemColors.Control;
            activePageButton.BackColor = Color.PaleTurquoise;
        }
        public void UpdateDisplay()
        {
            btnTestPage.Enabled = cardsSet.Cards.Count >= minValueForTestPage;
            btnLearnPage.Enabled = cardsSet.Cards.Count >= minValueForLearnPage;
            UpdateNavButtonsColors();
        }
        public void SetToolTipToButton(Button btn, string text)
        {
            ttipNavButton.Show(text, btn, btn.Width / 3, btn.Height / 4);
            isToolTipShown = true;
            activeToolTip = btn.Name;
        }
        private void HideToolTipOnButton()
        {
            if (activeToolTip == "") return;

            if (activeToolTip == btnLearnPage.Name)
                ttipNavButton.Hide(btnLearnPage);
            else if (activeToolTip == btnTestPage.Name)
                ttipNavButton.Hide(btnTestPage);

            isToolTipShown = false;
            activeToolTip = "";
        }
    }
}