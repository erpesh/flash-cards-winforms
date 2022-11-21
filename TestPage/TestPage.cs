using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards.TestPage
{
    public partial class TestPage : UserControl
    {
        private CardsSet cardsSet;
        public CardsSet CardsSet { set { cardsSet = value; } }
        public TestPage()
        {
            InitializeComponent();
        }
        public void GenerateTest()
        {
            var test = new CardsTest(cardsSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateTest();
        }
    }
}
