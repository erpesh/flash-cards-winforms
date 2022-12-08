using FlashCards.Models;
using FlashCards.StartForm;
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
    public partial class StartForm : Form
    {
        // data
        private const string titlesFilePath = "card-sets.txt";
        private List<string> cardSetsNames = new List<string>();
        
        // constructor
        public StartForm()
        {
            InitializeComponent();

            ReadFromFile();
            UpdateListOfSets();
            UpdateDispaly();
        }
        // event functions
        private void CardSetsList_SelectedChanged(object sender, EventArgs e)
        {
            UpdateDispaly();
        }
        private void btnCreateSet_Click(object sender, EventArgs e)
        {
            CardSetNameForm csnf = new(cardSetsNames);
            csnf.ShowDialog();

            if (csnf.IsFormSubmited)
            {
                string cardSetName = csnf.GetCardSetName();
                cardSetsNames.Add(cardSetName);
                WriteToFile();
                OpenMainForm(cardSetName);
            }
        }
        private void btnGoToSelected_Click(object sender, EventArgs e)
        {
            string selectedName = lbCardSets.GetItemText(lbCardSets.SelectedItem);
            OpenMainForm(selectedName);
        }
        // member functions
        private void ReadFromFile()
        {
            if (!File.Exists(titlesFilePath))
            {
                File.WriteAllText(titlesFilePath, "");
            }
            cardSetsNames = File.ReadAllLines(titlesFilePath).ToList();
        }
        private void WriteToFile()
        {
            File.WriteAllLines(titlesFilePath, cardSetsNames);
        }
        private void UpdateListOfSets()
        {
            lbCardSets.Items.Clear();
            foreach(string cardSet in cardSetsNames)
            {
                lbCardSets.Items.Add(cardSet);
            }
        }
        private void UpdateDispaly()
        {
            btnGoToSelected.Enabled = lbCardSets.SelectedItem != null;
        }
        private void OpenMainForm(string name)
        {
            Hide();
            MainForm mf = new(name);
            mf.ShowDialog();

            if (mf.IsGoBackToSetsList) // if user didn't close the main page
            {
                Show();

                if (mf.IsCardSetDeleted) 
                    DeleteCardSet(mf.CardsSet);
                UpdateListOfSets();
                UpdateDispaly();
            }
            else Close(); // if user closed the main page
        }
        private void DeleteCardSet(CardsSet cardsSet)
        {
            cardSetsNames.Remove(cardsSet.CardSetName);
            WriteToFile();
            File.Delete(cardsSet.FilePath);
        }
    }
}
