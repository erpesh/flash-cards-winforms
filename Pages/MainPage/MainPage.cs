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
        // data
        private const int maxTextLength = 100;
        private const int minTextLength = 3;
        private MainForm mainForm;
        private CardsSet cardsSet;
        private bool isToolTipShown;

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

        // event functions
        private void MainPage_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (CheckIfUserEnteredSeparator())
            {
                lblError.Text = "Don't use '" + cardsSet.Separator + "' symbol";
                return;
            }
            else lblError.Text = "";

            var card = new CardItem(txtTerm.Text, txtDefinition.Text);
            cardsSet.AddCard(card);

            CardListItem cardListItem = new CardListItem(this, cardsSet, card);
            cardsPanel.Controls.Add(cardListItem);

            txtTerm.Text = "";
            txtDefinition.Text = "";
            MainForm.UpdateDisplay();
        }
        private void MainPage_ControlRemoved(object sender, ControlEventArgs e)
        {
            mainForm.UpdateLearnPage();
            mainForm.UpdateDisplay();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mainForm.DeleteCardSet();
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButton();
        }
        private void MainPage_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctrl = GetChildAtPoint(e.Location);
            if (ctrl == btnAdd && !isToolTipShown && !btnAdd.Enabled)
            {
                isToolTipShown = true;
                string text = string.Format("Term and definition should be {0}-{1} characters long", minTextLength, maxTextLength);
                ttipAddButton.Show(text, btnAdd, btnAdd.Width / 3, btnAdd.Height / 4);
            }
            else if (ctrl != btnAdd && isToolTipShown)
            {
                ttipAddButton.Hide(btnAdd);
                isToolTipShown = false;
            }
        }

        // member functions
        private void UpdateDisplay()
        {
            lblCardSetName.Text = cardsSet.CardSetName;

            cardsPanel.Controls.Clear();
            foreach (CardItem card in cardsSet.Cards)
            {
                CardListItem cardListItem = new CardListItem(this, cardsSet, card);
                cardsPanel.Controls.Add(cardListItem);
            }
        }
        private void UpdateAddButton()
        {
            bool termCondition = txtTerm.Text.Length <= maxTextLength 
                && txtTerm.Text.Length >= minTextLength;
            bool definitionCondition = txtDefinition.Text.Length < maxTextLength 
                && txtDefinition.Text.Length >= minTextLength;
            btnAdd.Enabled = termCondition && definitionCondition;
        }
        private bool CheckIfUserEnteredSeparator()
        {
            return txtTerm.Text.Contains(cardsSet.Separator) ||
                txtDefinition.Text.Contains(cardsSet.Separator);
        }
    }
}
