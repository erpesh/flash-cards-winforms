using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    public class TestQuestion
    {
        // attributes
        private const int numberOfAnswers = 4;
        private CardsSet cardsSet;
        private CardItem cardItem;
        private List<string> possibleAnswers = new();
        private string answer = "";
        private bool isAnswered = false;
        private bool isCorrect = false;

        // getters setters
        public CardItem CardItem { get { return cardItem; } }
        public List<string> PossibleAnswers { get { return possibleAnswers; } }
        public bool IsAnswered { get { return isAnswered; } }
        public bool IsCorrect { get { return isCorrect; } }
        public void SetAnswer(int answerIndex)
        {
            answer = possibleAnswers[answerIndex];
            isAnswered = true;
            isCorrect = answer == cardItem.Definition;
        }

        // constructors
        public TestQuestion(CardsSet cardsSet, CardItem cardItem)
        {
            this.cardsSet = cardsSet;
            this.cardItem = cardItem;

            GeneratePossibleAnswers();
        }
        
        // methods
        private void GeneratePossibleAnswers()
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(numberOfAnswers);
            
            for (int i = 0; i < numberOfAnswers; i++)
            {
                if (randomIndex == i) possibleAnswers.Add(cardItem.Definition);
                else possibleAnswers.Add(cardsSet.GetRandomCardExcept(possibleAnswers));
            }
        }
    }
}
