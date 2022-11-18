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
        private CardItem _card;
        private Action<CardItem> _removeCard;
        public CardItem Card
        {
            get { return _card; }
            set 
            { 
                _card = value;
                lblTerm.Text = value.Term;
                lblDefinition.Text = value.Definition;
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
    }
}
