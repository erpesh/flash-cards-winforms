using System.Windows.Forms;

namespace FlashCards
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            mainPage1.BringToFront();
        }

        private void btnLearnPage_Click(object sender, EventArgs e)
        {
            learnPage1.BringToFront();
        }

        private void MainForm_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            learnPage1.handleKeyDown(e);
        }
    }
}