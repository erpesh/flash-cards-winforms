using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    public class CardsTest
    {
        private CardsSet cardsSet;
        private List<TestQuestion> testQuestions = new();
        public List<TestQuestion> TestQuestions { get { return testQuestions; } } 
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
                testQuestions.Add(question);
            }
        }
    }
}
