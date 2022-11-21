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
    public partial class CardListItem : UserControl
    {
        private MainPage mainPage;
        private CardItem card;
        private Action<CardItem> removeCard;
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
        public CardListItem()
        {
            InitializeComponent();
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            removeCard(card);
            this.Dispose();
        }
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
        private void Edit_Click(object sender, EventArgs e)
        {
            txtTerm.Select();
            SwitchReadOnly();
            SwitchButtons();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            mainPage.CardsSet.WriteToFile();
            mainPage.MainForm.UpdateLearnPage();
            SwitchReadOnly();
            SwitchButtons();
        }
        private void Term_Change(object sender, EventArgs e)
        {
            card.Term = txtTerm.Text;
        }

        private void Definition_Change(object sender, EventArgs e)
        {
            card.Definition = txtDefinition.Text;
        }
    }
}
