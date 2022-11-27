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
        private int answerIndex;
        private bool isAnswered = false;
        private bool isCorrect = false;

        // getters setters
        public CardItem CardItem { get { return cardItem; } }
        public List<string> PossibleAnswers { get { return possibleAnswers; } }
        public int AnswerIndex
        {
            get { return answerIndex; }
            set
            {
                answerIndex = value;
                isAnswered = true;
                isCorrect = possibleAnswers[answerIndex] == cardItem.Definition;
            }
        }
        public bool IsAnswered { get { return isAnswered; } }
        public bool IsCorrect { get { return isCorrect; } }

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
            possibleAnswers.Add(cardItem.Definition);

            for (int i = 0; i < numberOfAnswers - 1; i++)
            {
                possibleAnswers.Add(cardsSet.GetRandomCardExcept(possibleAnswers));
            }
            Random rand = new Random();
            possibleAnswers = possibleAnswers.OrderBy(_ => rand.Next()).ToList();
        }
    }
}
