using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    public class CardsTest
    {
        // data
        private CardsSet cardsSet;
        private List<TestQuestion> testQuestions = new();
        private bool isTestSubmited;
        private bool toStarCorrectAnswers;

        // getters setters
        public List<TestQuestion> TestQuestions { get { return testQuestions; } }
        public bool IsTestSubmitted { get { return isTestSubmited; } }

        // constructor
        public CardsTest(
            CardsSet cardsSet,
            int numOfQuestions,
            bool toStarCorrectAnswers,
            bool useOnlyUnstarredCards)
        {
            this.cardsSet = cardsSet;
            this.toStarCorrectAnswers = toStarCorrectAnswers;

            GenerateQuestions(numOfQuestions, useOnlyUnstarredCards);
        }

        // functions
        private void GenerateQuestions(int numOfQuestions, bool useOnlyUnstarredCards)
        {
            Random rnd = new Random();
            List<CardItem> cardsForTest = useOnlyUnstarredCards ?
                cardsSet.GetUnstarredCards() : new List<CardItem>(cardsSet.Cards);
                
            for (int i = 0; i < numOfQuestions; i++)
            {
                int randomIndex = rnd.Next(cardsForTest.Count);
                CardItem cardItem = cardsForTest[randomIndex];
                cardsForTest.RemoveAt(randomIndex);


                TestQuestion question = new(cardsSet, cardItem);
                testQuestions.Add(question);
            }
            testQuestions = testQuestions.OrderBy(_ => rnd.Next()).ToList();
        }
        public void SubmitTest()
        {
            isTestSubmited = true;
            if (toStarCorrectAnswers) StarCards();
        }
        private void StarCards()
        {
            List<CardItem> cards = new();
            for(int i = 0; i < testQuestions.Count; i++)
            {
                if (testQuestions[i].IsCorrect) cards.Add(testQuestions[i].CardItem);
            }
            cardsSet.StarCards(cards);
        }
        public int GetNumberOfCorrectAnswers()
        {
            int numberOfCorrectAnswers = 0;
            foreach(TestQuestion testQuestion in testQuestions)
            {
                if (testQuestion.IsCorrect) numberOfCorrectAnswers++;
            }
            return numberOfCorrectAnswers;
        }
    }
}
