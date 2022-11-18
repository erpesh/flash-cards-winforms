using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards.LearnPage
{
    public partial class LearnPage : UserControl
    {
        public LearnPage()
        {
            InitializeComponent();
        }
        public void handleKeyDown(PreviewKeyDownEventArgs e)
        {
            lblText.Text = e.KeyValue.ToString();
        }
    }
}
