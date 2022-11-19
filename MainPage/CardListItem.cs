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
        private MainPage _mainPage;
        private CardItem _card;
        private Action<CardItem> _removeCard;
        public MainPage MainPage
        {
            set { _mainPage = value; }
        }
        public CardItem Card
        {
            get { return _card; }
            set 
            { 
                _card = value;
                txtTerm.Text = value.Term;
                txtDefinition.Text = value.Definition;
            }
        }
        public Action<CardItem> RemoveCard
        {
            set { _removeCard = value; }
        }
        public CardListItem()
        {
            InitializeComponent();
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            _removeCard(_card);
            this.Dispose();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            txtTerm.Select();
            txtTerm.ReadOnly = false;
            txtDefinition.ReadOnly = false;
            btnEdit.Visible = false;
            btnSave.Visible = true;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            _mainPage.CardsSet.WriteToFile();
            _mainPage.UpdateLearnPage();
            btnEdit.Visible = true;
            btnSave.Visible = false;
        }
        private void Term_Change(object sender, EventArgs e)
        {
            _card.Term = txtTerm.Text;
        }

        private void Definition_Change(object sender, EventArgs e)
        {
            _card.Definition = txtDefinition.Text;
        }
    }
}
