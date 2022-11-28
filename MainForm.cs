using System.Windows.Forms;
using FlashCards.Models;

namespace FlashCards
{
    public partial class MainForm : Form
    {
        private CardsSet cardsSet = new CardsSet();
        public MainForm()
        {
            InitializeComponent();

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
        public void UpdateLearnPage()
        {
            learnPage1.UpdateCardText();
        }
        public void ResetTestPage()
        {
            testPage1.CardsSet = cardsSet;
        }
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
            testPage1.BringToFront();
            if (!testPage1.IsTestGenerated())
                testPage1.GenerateTest();
        }
    }
}