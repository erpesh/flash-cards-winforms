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
    public partial class TestResults : Form
    {
        public TestResults()
        {
            InitializeComponent();
        }
        public void SetTestResults(int numOfCorrectAns, int numOfIncorrectAns)
        {
            lblCorrect.Text += numOfCorrectAns;
            lblIncorrect.Text += numOfIncorrectAns;
            lblResult.Text += numOfCorrectAns * 100 / (numOfCorrectAns + numOfIncorrectAns) + "%";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
