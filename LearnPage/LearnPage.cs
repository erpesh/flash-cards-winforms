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
        private CardsSet _cardsSet;
        private int _activeCardIndex = 0;
        private bool _isActiveSideIsTerm = true;
        public CardsSet CardsSet
        {
            set 
            { 
                _cardsSet = value;
                UpdateCardText();
            }
        }
        public LearnPage()
        {
            InitializeComponent();
        }
        private void SwitchCardSide()
        {
            _isActiveSideIsTerm = !_isActiveSideIsTerm;
            UpdateCardText();
        }
        public void UpdateCardText()
        {
            // when there is no cards left
            if (_cardsSet.Cards.Count == 0)
            {
                lblText.Text = "";
                return;
            }
            // when the last card was active and got removed
            if (_activeCardIndex >= _cardsSet.Cards.Count)
            {
                _activeCardIndex = _cardsSet.Cards.Count - 1;
            }
            if (_isActiveSideIsTerm)
            {
                lblText.Text = _cardsSet.Cards[_activeCardIndex].Term;
            }
            else
            {
                lblText.Text = _cardsSet.Cards[_activeCardIndex].Definition;
            }
        }
        private void LeftPress()
        {
            if (_activeCardIndex == 0)
            {
                _activeCardIndex = _cardsSet.Cards.Count - 1;
            }
            else _activeCardIndex--;
            UpdateCardText();
        }
        private void RightPress()
        {
            if (_activeCardIndex == _cardsSet.Cards.Count - 1)
            {
                _activeCardIndex = 0;
            }
            else _activeCardIndex++;
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
