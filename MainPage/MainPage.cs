using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards.MainPage
{
    public partial class MainPage : UserControl
    {
        private CardsSet _cardsSet;
        public CardsSet CardsSet
        {
            get { return _cardsSet; }
            set { _cardsSet = value; }
        }
        public MainPage()
        {
            InitializeComponent();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            DisplayCards();
        }
        private void DisplayCards()
        {
            cardsPanel.Controls.Clear();
            foreach (CardItem card in _cardsSet.Cards)
            {
                CardListItem cardListItem = new CardListItem();
                cardListItem.MainPage = this;
                cardListItem.Card = card;
                cardListItem.RemoveCard = _cardsSet.RemoveCard;
                cardsPanel.Controls.Add(cardListItem);
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var card = new CardItem();
            card.Term = txtTerm.Text;
            card.Definition = txtDefinition.Text;
            _cardsSet.AddCard(card);
            txtTerm.Text = "";
            txtDefinition.Text = "";
            DisplayCards();
        }
        public void UpdateLearnPage()
        {
            var learnPage1 = Parent.Controls.Find("learnPage1", true).FirstOrDefault() as LearnPage.LearnPage;
            learnPage1.UpdateCardText();
        }
        private void MainPage_ControlRemoved(object sender, ControlEventArgs e)
        {
            lblDefinition.Enabled = true;
            UpdateLearnPage();
        }
    }
}
