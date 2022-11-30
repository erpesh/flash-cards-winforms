using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlashCards.Models;

namespace FlashCards.LearnPage
{
    public partial class LearnPage : UserControl
    {
        // data
        private CardsSet cardsSet;
        private int activeCardIndex = 0;
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

            //blackStar = Image.FromFile("icons/star-icon-black.png");
            //yellowStar = Image.FromFile("icons/star-icon-yellow.png");
            //btnLeft.BackgroundImage = Image.FromFile("icons/chevron-left.png");
            //btnRight.BackgroundImage = Image.FromFile("icons/chevron-right.png");
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
        }
        
        // event functions
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
        private void pctrStar_Click(object sender, EventArgs e)
        {
            cardsSet.Cards[activeCardIndex].IsStarred = !cardsSet.Cards[activeCardIndex].IsStarred;
            cardsSet.WriteToFile();
            UpdateCardDisplay();
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
            // sets smaller font size if text is too long
            if (lblText.Text.Length > 100) lblText.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            // set the star
            pctrStar.Image = activeCard.IsStarred ? yellowStar : blackStar;
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
    }
}
