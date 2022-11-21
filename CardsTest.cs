using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    class CardsTest
    {
        private CardsSet cardsSet;
        private List<TestQuestion> questions = new();
        public CardsTest(CardsSet cardsSet)
        {
            this.cardsSet = cardsSet;
            GenerateQuestions();
        }
        private void GenerateQuestions()
        {
            foreach (CardItem cardItem in cardsSet.Cards)
            {
                TestQuestion question = new(cardsSet, cardItem);
                questions.Add(question);
            }
        }
    }
}
