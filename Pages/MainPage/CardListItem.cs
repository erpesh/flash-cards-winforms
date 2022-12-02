﻿using System;
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
        private CardItem card;
        private Action<CardItem> removeCard;

        // getters setters
        public MainPage MainPage
        {
            set { mainPage = value; }
        }
        public CardItem Card
        {
            set 
            { 
                card = value;
                txtTerm.Text = value.Term;
                txtDefinition.Text = value.Definition;
            }
        }
        public Action<CardItem> RemoveCard
        {
            set { removeCard = value; }
        }
        // constructor
        public CardListItem()
        {
            InitializeComponent();
        }
        // event functions
        private void Remove_Click(object sender, EventArgs e)
        {
            removeCard(card);
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
            card.Term = txtTerm.Text;
            card.Definition = txtDefinition.Text;

            mainPage.CardsSet.WriteToFile();
            mainPage.MainForm.UpdateLearnPage();
            SwitchReadOnly();
            SwitchButtons();
        }
        private void Term_Change(object sender, EventArgs e)
        {
            UpdateSaveButton(txtTerm);
        }

        private void Definition_Change(object sender, EventArgs e)
        {
            UpdateSaveButton(txtDefinition);
        }

        // member functions
        private void SwitchButtons()
        {
            btnEdit.Visible = !btnEdit.Visible;
            btnSave.Visible = !btnSave.Visible;
        }
        private void SwitchReadOnly()
        {
            txtTerm.ReadOnly = !txtTerm.ReadOnly;
            txtDefinition.ReadOnly = !txtDefinition.ReadOnly;
        }
        private void UpdateSaveButton(TextBox tb)
        {
            btnSave.Enabled = tb.Text.Length < 100;
        }
    }
}
