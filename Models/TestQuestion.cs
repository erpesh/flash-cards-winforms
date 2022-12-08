using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    public class TestQuestion
    {
        // data
        private const int numberOfAnswers = 4;
        private CardsSet cardsSet;
        private CardItem cardItem;
        private List<string> possibleAnswers = new();
        private int answerIndex = -1;
        private bool isAnswered = false;
        private bool isCorrect = false;

        // getters setters
        public int NumberOfAnswers { get { return numberOfAnswers; } }
        public CardItem CardItem { get { return cardItem; } }
        public int CorrectAnswerIndex
        {
            get
            {
                for (int i = 0; i < numberOfAnswers; i++)
                {
                    if (possibleAnswers[i] == cardItem.Definition) return i;
                }
                return 0;
            }
        }
        public List<string> PossibleAnswers { get { return possibleAnswers; } }
        public int AnswerIndex
        {
            get { return answerIndex; }
            set
            {
                answerIndex = value;
                isAnswered = value != -1;
                isCorrect = isAnswered && possibleAnswers[answerIndex] == cardItem.Definition;
            }
        }
        public bool IsAnswered { get { return isAnswered; } }
        public bool IsCorrect { get { return isCorrect; } }

        // constructor
        public TestQuestion(CardsSet cardsSet, CardItem cardItem)
        {
            this.cardsSet = cardsSet;
            this.cardItem = cardItem;

            GeneratePossibleAnswers();
        }

        // functions
        private void GeneratePossibleAnswers()
        {
            possibleAnswers.Add(cardItem.Definition); // adding correct answer to possibleAnswers

            for (int i = 0; i < numberOfAnswers - 1; i++)
            {
                possibleAnswers.Add(cardsSet.GetRandomDefinitionExcept(possibleAnswers));
            }
            // answer list shuffling
            Random rand = new Random();
            possibleAnswers = possibleAnswers.OrderBy(_ => rand.Next()).ToList();
        }
    }
}
