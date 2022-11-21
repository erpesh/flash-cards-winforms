using FlashCards.MainPage;

namespace FlashCards
{
    public class CardsSet
    {
        private const string filePath = "cards.txt";
        private const char separator = '&';
        private List<CardItem> cards = new List<CardItem>();
        public List<CardItem> Cards
        {
            get { return cards; }
        }

        public CardsSet()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
            }
            ReadFromFile();
        }
        private void ReadFromFile()
        {
            List<string> cards = File.ReadAllLines(filePath).ToList();
            foreach (string card in cards)
            {
                var splitCard = card.Split(separator);
                var newCardItem = new CardItem(splitCard[0], splitCard[1]);
                this.cards.Add(newCardItem);
            }
        }
        public void WriteToFile()
        {
            List<string> stringCards = new List<string>();
            foreach (CardItem card in cards)
            {
                stringCards.Add(card.Term + separator + card.Definition);
            }
            File.WriteAllLines(filePath, stringCards);
        }
        public void AddCard(CardItem card)
        {
            cards.Add(card);
            WriteToFile();
        }
        public void RemoveCard(CardItem card)
        {
            cards.Remove(card);
            WriteToFile();
        }
        public string GetRandomCardExcept(List<string> exceptions)
        {
            Random rnd = new Random();
            while (true)
            {
                var index = rnd.Next(0, cards.Count);
                if (!exceptions.Contains(cards[index].Term))
                {
                    return cards[index].Term;
                }
            }
        }
    }
}
