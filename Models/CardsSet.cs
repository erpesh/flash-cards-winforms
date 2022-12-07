using FlashCards.MainPage;

namespace FlashCards.Models
{
    public class CardsSet
    {
        // Data
        private const char separator = '&';
        private string cardSetName;
        private string filePath;
        private List<CardItem> cards = new List<CardItem>();

        // getters setters
        public char Separator { get { return separator; } }
        public string CardSetName { get { return cardSetName; } }
        public string FilePath { get { return filePath; } }
        public List<CardItem> Cards { get { return cards; } }

        // constructor
        public CardsSet(string cardSetName = "cards.txt")
        {
            this.cardSetName = cardSetName;
            this.filePath = "card-sets/" + cardSetName + ".txt";
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
            }
            ReadFromFile();
        }

        // member functions
        private void ReadFromFile()
        {
            List<string> cards = File.ReadAllLines(filePath).ToList();
            foreach (string card in cards)
            {
                var splitCard = card.Split(separator);
                var newCardItem = new CardItem(splitCard[0], splitCard[1], splitCard[2]);
                this.cards.Add(newCardItem);
            }
        }
        public void WriteToFile()
        {
            List<string> stringCards = new List<string>();
            foreach (CardItem card in cards)
            {
                string cardString = card.Term + separator + card.Definition + separator +
                    (card.IsStarred ? "1" : "0");
                stringCards.Add(cardString);
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
                if (!exceptions.Contains(cards[index].Definition))
                {
                    return cards[index].Definition;
                }
            }
        }
        public List<CardItem> GetUnstarredCards()
        {
            return new List<CardItem>(cards.FindAll(item => !item.IsStarred));
        }
        public void StarCards(List<CardItem> cardsToStar)
        {
            foreach(CardItem card in cards)
            {
                if (cardsToStar.Contains(card)) card.IsStarred = true;
            }
            WriteToFile();
        }
    }
}
