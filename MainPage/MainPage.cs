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
        private CardsSet _cardsSet = new CardsSet();
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
            foreach (CardItem card in _cardsSet.cards)
            {
                CardListItem cardListItem = new CardListItem();
                cardListItem.Card = card;
                cardListItem.removeCard = _cardsSet.RemoveCard;
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
    }
}
