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
    public partial class CardListItem : UserControl
    {
        // data
        private MainPage mainPage;
        private CardsSet cardsSet;
        private CardItem card;

        // constructor
        public CardListItem(MainPage mainPage, CardsSet cardsSet, CardItem card)
        {
            this.mainPage = mainPage;
            this.cardsSet = cardsSet;
            this.card = card;

            InitializeComponent();

            // setting images from resources
            btnEdit.BackgroundImage = Properties.Resources.editIcon;
            btnRemove.BackgroundImage = Properties.Resources.removeIcon;
            btnSave.BackgroundImage = Properties.Resources.tickIcon;

            txtTerm.Text = card.Term;
            txtDefinition.Text = card.Definition;
        }
        // event functions
        private void Remove_Click(object sender, EventArgs e)
        {
            mainPage.CardsSet.RemoveCard(card);
            Dispose();
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            txtTerm.Select();
            SwitchReadOnly();
            SwitchButtons();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            // checks if user enters cardsSet separator
            if (mainPage.CheckIfUserEnteredSeparator(txtTerm, txtDefinition))
            {
                MessageBox.Show("Don't use " + cardsSet.Separator + "symbol");
                return;
            }

            card.Term = txtTerm.Text;
            card.Definition = txtDefinition.Text;

            mainPage.CardsSet.WriteToFile();
            mainPage.MainForm.UpdateLearnPage();
            SwitchReadOnly();
            SwitchButtons();
        }
        private void TextBox_Change(object sender, EventArgs e)
        {
            UpdateSaveButton();
        }

        // member functions
        private void SwitchButtons() // switching edit and save buttons
        {
            btnEdit.Visible = !btnEdit.Visible;
            btnSave.Visible = !btnSave.Visible;
        }
        private void SwitchReadOnly() // enabling / disabling textboxess
        {
            txtTerm.ReadOnly = !txtTerm.ReadOnly;
            txtDefinition.ReadOnly = !txtDefinition.ReadOnly;
        }
        private void UpdateSaveButton()
        {
            mainPage.UpdateAddButton(btnSave, txtTerm, txtDefinition);
        }

    }
}
