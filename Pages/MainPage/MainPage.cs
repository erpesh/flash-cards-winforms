using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlashCards.Models;

namespace FlashCards.MainPage
{
    public partial class MainPage : UserControl
    {
        // attributes
        private MainForm mainForm;
        private CardsSet cardsSet;

        // getters setters
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

        // constructor
        public MainPage()
        {
            InitializeComponent();
        }

        // methods
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
        }
        private void MainPage_ControlRemoved(object sender, ControlEventArgs e)
        {
            mainForm.UpdateLearnPage();
            mainForm.ResetTestPage();
        }
    }
}
