using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    class TestQuestion
    {
        private const int numberOfAnswers = 4;
        private CardsSet cardsSet;
        private CardItem cardItem;
        private List<string> possibleAnswers = new();
        public CardItem CardItem { get { return cardItem; } }
        public TestQuestion(CardsSet cardsSet, CardItem cardItem)
        {
            this.cardsSet = cardsSet;
            this.cardItem = cardItem;

            GeneratePossibleAnswers();
        }
        private void GeneratePossibleAnswers()
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(numberOfAnswers);
            
            for (int i = 0; i < numberOfAnswers; i++)
            {
                if (randomIndex == i) possibleAnswers.Add(cardItem.Term);
                else possibleAnswers.Add(cardsSet.GetRandomCardExcept(possibleAnswers));
            }
        }
    }
}
