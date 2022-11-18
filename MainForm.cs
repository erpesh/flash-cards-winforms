using System.Windows.Forms;

namespace FlashCards
{
    public partial class MainForm : Form
    {
        private CardsSet _cardSet = new CardsSet();
        public MainForm()
        {
            InitializeComponent();

            mainPage1.CardsSet = _cardSet;
            learnPage1.CardsSet = _cardSet;
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
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            mainPage1.BringToFront();
        }

        private void btnLearnPage_Click(object sender, EventArgs e)
        {
            learnPage1.BringToFront();
        }
    }
}