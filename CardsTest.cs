using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    public class CardsTest
    {
        // attributes
        private CardsSet cardsSet;
        private List<TestQuestion> testQuestions = new();
        private bool isTestSubmited = false;

        // getters setters
        public List<TestQuestion> TestQuestions { get { return testQuestions; } } 
        public bool IsTestSubmitted { get { return isTestSubmited; } }

        // constructor
        public CardsTest(CardsSet cardsSet)
        {
            this.cardsSet = cardsSet;
            GenerateQuestions();
        }

        // methods
        private void GenerateQuestions()
        {
            foreach (CardItem cardItem in cardsSet.Cards)
            {
                TestQuestion question = new(cardsSet, cardItem);
                testQuestions.Add(question);
            }
            Random rand = new Random();
            testQuestions = testQuestions.OrderBy(_ => rand.Next()).ToList();
        }
        public void SubmitTest()
        {
            isTestSubmited = true;
        }
    }
}
