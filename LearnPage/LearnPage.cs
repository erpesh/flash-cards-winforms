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
        private CardsSet cardsSet;
        private int activeCardIndex = 0;
        private bool isActiveSideIsTerm = true;
        public CardsSet CardsSet
        {
            set 
            { 
                cardsSet = value;
                UpdateCardText();
            }
        }
        public LearnPage()
        {
            InitializeComponent();
        }
        private void SwitchCardSide()
        {
            isActiveSideIsTerm = !isActiveSideIsTerm;
            UpdateCardText();
        }
        public void UpdateCardText()
        {
            // when there is no cards left
            if (cardsSet.Cards.Count == 0)
            {
                lblText.Text = "";
                return;
            }
            // when the last card was active and got removed
            if (activeCardIndex >= cardsSet.Cards.Count)
            {
                activeCardIndex = cardsSet.Cards.Count - 1;
            }
            if (isActiveSideIsTerm)
            {
                lblText.Text = cardsSet.Cards[activeCardIndex].Term;
            }
            else
            {
                lblText.Text = cardsSet.Cards[activeCardIndex].Definition;
            }
        }
        private void LeftPress()
        {
            if (activeCardIndex == 0)
            {
                activeCardIndex = cardsSet.Cards.Count - 1;
            }
            else activeCardIndex--;
            UpdateCardText();
        }
        private void RightPress()
        {
            if (activeCardIndex == cardsSet.Cards.Count - 1)
            {
                activeCardIndex = 0;
            }
            else activeCardIndex++;
            UpdateCardText();
        }
        private void LearnPage_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 32)
            {
                SwitchCardSide();
            }
            else if (e.KeyValue == 37)
            {
                LeftPress();
            }
            else if (e.KeyValue == 39)
            {
                RightPress();
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            LeftPress();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            RightPress();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            SwitchCardSide();
        }
    }
}
