using FlashCards.MainPage;

namespace FlashCards
{
    class CardsSet
    {
        private string _filePath = "cards.txt";
        public List<CardItem> cards = new List<CardItem>();

        public CardsSet()
        {
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "");
            }
            ReadFromFile();
        }
        private void ReadFromFile()
        {
            List<string> cards = File.ReadAllLines(_filePath).ToList();
            foreach (string card in cards)
            {
                var splitCard = card.Split(',');
                var newCardItem = new CardItem();
                newCardItem.Term = splitCard[0];
                newCardItem.Definition = splitCard[1];
                this.cards.Add(newCardItem);
            }
        }
        private void WriteToFile()
        {
            List<string> stringCards = new List<string>();
            foreach (CardItem card in cards)
            {
                stringCards.Add(card.Term + "," + card.Definition);
            }
            File.WriteAllLines(_filePath, stringCards);
        }
        public void AddCard(CardItem card)
        {
            this.cards.Add(card);
            WriteToFile();
        }
        public void RemoveCard(CardItem card)
        {
            this.cards.Remove(card);
            WriteToFile();
        }
    }
}
