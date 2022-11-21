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
        private MainForm mainForm;
        private CardsSet cardsSet;
        public MainForm MainForm
        {
            get { return mainForm; }
            set { mainForm = value; }
        }
        public CardsSet CardsSet
        {
            get { return cardsSet; }
            set { cardsSet = value; }
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
            foreach (CardItem card in cardsSet.Cards)
            {
                CardListItem cardListItem = new CardListItem();
                cardListItem.MainPage = this;
                cardListItem.Card = card;
                cardListItem.RemoveCard = cardsSet.RemoveCard;
                cardsPanel.Controls.Add(cardListItem);
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var card = new CardItem(txtTerm.Text, txtDefinition.Text);
            cardsSet.AddCard(card);

            CardListItem cardListItem = new CardListItem();
            cardListItem.MainPage = this;
            cardListItem.Card = card;
            cardListItem.RemoveCard = cardsSet.RemoveCard;
            cardsPanel.Controls.Add(cardListItem);

            txtTerm.Text = "";
            txtDefinition.Text = "";
            //DisplayCards();
        }
        private void MainPage_ControlRemoved(object sender, ControlEventArgs e)
        {
            mainForm.UpdateLearnPage();
        }
    }
}
