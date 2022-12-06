using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlashCards.Models;

namespace FlashCards.LearnPage
{
    public partial class LearnPage : UserControl
    {
        // data
        private const int newFontTextLength = 80;
        private CardsSet cardsSet;
        private int activeCardIndex;
        private bool isActiveSideIsTerm = true;
        private Image blackStar, yellowStar;
        
        // getters setters
        public CardsSet CardsSet
        {
            set 
            { 
                cardsSet = value;
                UpdateCardDisplay();
            }
        }
        // constructor
        public LearnPage()
        {
            InitializeComponent();

            blackStar = Properties.Resources.starIconBlack;
            yellowStar = Properties.Resources.starIconYellow;
            pbLeft.Image = Properties.Resources.chevronLeft;
            pbRight.Image = Properties.Resources.chevronRight;
            pbInfo.Image = Properties.Resources.infoIcon;
        }

        // event functions
        private void LearnPage_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 32) SwitchCardSide();
            else if (e.KeyValue == 37) LeftPress();
            else if (e.KeyValue == 39) RightPress();
            else if (e.KeyValue == 13) ToggleCardStar();
        }
        private void Card_Click(object sender, EventArgs e)
        {
            SwitchCardSide();
        }
        private void pctrStar_Click(object sender, EventArgs e)
        {
            ToggleCardStar();
        }
        private void Left_Click(object sender, EventArgs e)
        {
            LeftPress();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            RightPress();
        }
        private void pbInfo_Click(object sender, EventArgs e)
        {
            OpenGuideMessageBox();
        }

        // member functions
        private void SwitchCardSide()
        {
            isActiveSideIsTerm = !isActiveSideIsTerm;
            UpdateCardDisplay();
        }
        public void UpdateCardDisplay()
        {
            // when there is no cards left
            if (cardsSet.Cards.Count == 0)
            {
                lblText.Text = "";
                return;
            }
            // when the last card was active and got removed
            CardItem activeCard = cardsSet.Cards[activeCardIndex];
            if (activeCardIndex >= cardsSet.Cards.Count)
            {
                activeCardIndex = cardsSet.Cards.Count - 1;
            }
            if (isActiveSideIsTerm)
            {
                lblText.Text = activeCard.Term;
            }
            else
            {
                lblText.Text = activeCard.Definition;
            }
            // sets smaller font size ifr the text is too long
            if (lblText.Text.Length > newFontTextLength) lblText.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            // sets the star
            pctrStar.Image = activeCard.IsStarred ? yellowStar : blackStar;
            // sets card side title
            lblCardSide.Text = isActiveSideIsTerm ? "Term" : "Definition";
        }
        private void LeftPress()
        {
            if (activeCardIndex == 0)
            {
                activeCardIndex = cardsSet.Cards.Count - 1;
            }
            else activeCardIndex--;
            UpdateCardDisplay();
        }
        private void RightPress()
        {
            if (activeCardIndex == cardsSet.Cards.Count - 1)
            {
                activeCardIndex = 0;
            }
            else activeCardIndex++;
            UpdateCardDisplay();
        }

        private void ToggleCardStar()
        {
            cardsSet.Cards[activeCardIndex].IsStarred = !cardsSet.Cards[activeCardIndex].IsStarred;
            cardsSet.WriteToFile();
            UpdateCardDisplay();
        }
        private void OpenGuideMessageBox()
        {
            string guideText = "Left Arrow - previous card\n" +
                "Right Arrow - next card\n" +
                "Space - flip the card\n" +
                "Enter - star/unstar the card";
            MessageBox.Show(guideText);
        }
    }
}
