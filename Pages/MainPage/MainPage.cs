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
        public int MaxTextLength { get { return maxTextLength; } }
        public int MinTextLength { get { return minTextLength; } }
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
            // if user uses separator
            if (CheckIfUserEnteredSeparator(txtTerm, txtDefinition))
            {
                lblError.Text = "Don't use '" + cardsSet.Separator + "' symbol";
                return;
            }
            else lblError.Text = "";

            // add card to cardsSet
            var card = new CardItem(txtTerm.Text, txtDefinition.Text);
            cardsSet.AddCard(card);
            // add card item to cardsPanel
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
            UpdateAddButton(btnAdd, txtTerm, txtDefinition);
        }
        private void MainPage_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctrl = GetChildAtPoint(e.Location);

            // setting tooltip on disabled button
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
        public void UpdateAddButton(Button btn, TextBox txtTerm, TextBox txtDefinition)
        { // checks corectness of term and definition lengths
            bool termCondition = txtTerm.Text.Length <= maxTextLength 
                && txtTerm.Text.Length >= minTextLength;
            bool definitionCondition = txtDefinition.Text.Length <= maxTextLength 
                && txtDefinition.Text.Length >= minTextLength;
            btn.Enabled = termCondition && definitionCondition;
        }
        public bool CheckIfUserEnteredSeparator(TextBox txtTerm, TextBox txtDefinition)
        {
            return txtTerm.Text.Contains(cardsSet.Separator) ||
                txtDefinition.Text.Contains(cardsSet.Separator);
        }
    }
}
