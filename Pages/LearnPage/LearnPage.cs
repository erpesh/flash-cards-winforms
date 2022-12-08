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

            // setting icons from resources
            blackStar = Properties.Resources.starIconBlack;
            yellowStar = Properties.Resources.starIconYellow;
            pbLeft.Image = Properties.Resources.chevronLeft;
            pbRight.Image = Properties.Resources.chevronRight;
            pbInfo.Image = Properties.Resources.infoIcon;
        }

        // event functions
        private void LearnPage_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Space) SwitchCardSide();
            else if (e.KeyData == Keys.Left) ToPreviousCard();
            else if (e.KeyData == Keys.Right) ToNextCard();
            else if (e.KeyData == Keys.Enter) ToggleCardStar();
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
            ToPreviousCard();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            ToNextCard();
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
            // setting card text depending on active side
            lblText.Text = isActiveSideIsTerm ? activeCard.Term : activeCard.Definition;
            lblCardSide.Text = isActiveSideIsTerm ? "Term" : "Definition";

            // sets smaller font size if the text is too long
            if (lblText.Text.Length > newFontTextLength) lblText.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            
            // sets the star image 
            pctrStar.Image = activeCard.IsStarred ? yellowStar : blackStar;

            // sets card side title
        }
        private void ToPreviousCard()
        {
            if (activeCardIndex == 0)
            {
                activeCardIndex = cardsSet.Cards.Count - 1;
            }
            else activeCardIndex--;
            UpdateCardDisplay();
        }
        private void ToNextCard()
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
