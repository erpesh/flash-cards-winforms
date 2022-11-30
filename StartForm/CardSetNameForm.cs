using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards.StartForm
{
    public partial class CardSetNameForm : Form
    {
        // data
        private List<string> cardSetsTitles;
        private bool isFormSubmited;

        // getters setters
        public bool IsFormSubmited { get { return isFormSubmited; } }
        public string GetCardSetName() { return tbCardSetName.Text; }
        
        // constructor
        public CardSetNameForm(List<string> cardSetsTitles)
        {
            InitializeComponent();
            this.cardSetsTitles = cardSetsTitles;
        }
        // event functions
        private void btnCreateCardSet_Click(object sender, EventArgs e)
        {
            if (cardSetsTitles.Contains(tbCardSetName.Text))
                lblError.Text = "This name already exists";
            else if (tbCardSetName.Text.Length < 4)
                lblError.Text = "This name is too short";
            else if (tbCardSetName.Text.Length > 25)
                lblError.Text = "This name is too long";
            else
            {
                isFormSubmited = true;
                Close();
            }
        }
    }
}
