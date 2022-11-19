using FlashCards.MainPage;

namespace FlashCards
{
    public class CardsSet
    {
        private string _filePath = "cards.txt";
        private const char _separator = '&';
        private List<CardItem> _cards = new List<CardItem>();
        public List<CardItem> Cards
        {
            get { return _cards; }
            //set { _cards = value; }
        }

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
                var splitCard = card.Split(_separator);
                var newCardItem = new CardItem();
                newCardItem.Term = splitCard[0];
                newCardItem.Definition = splitCard[1];
                this._cards.Add(newCardItem);
            }
        }
        public void WriteToFile()
        {
            List<string> stringCards = new List<string>();
            foreach (CardItem card in _cards)
            {
                stringCards.Add(card.Term + _separator + card.Definition);
            }
            File.WriteAllLines(_filePath, stringCards);
        }
        public void AddCard(CardItem card)
        {
            _cards.Add(card);
            WriteToFile();
        }
        public void RemoveCard(CardItem card)
        {
            _cards.Remove(card);
            WriteToFile();
        }
    }
}
