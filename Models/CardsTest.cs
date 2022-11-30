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
            bool useOnlyStarredCards)
        {
            this.cardsSet = cardsSet;
            this.toStarCorrectAnswers = toStarCorrectAnswers;
            GenerateQuestions(numOfQuestions, useOnlyStarredCards);
        }

        // functions
        private void GenerateQuestions(int numOfQuestions, bool useOnlyStarredCards)
        {
            for (int i = 0; i < numOfQuestions; i++)
            {
                CardItem cardItem = cardsSet.Cards[i];
                // if useOnlyStarredCards == true the progam is skipping unstarred cards
                if (useOnlyStarredCards && !cardItem.IsStarred) continue;

                TestQuestion question = new(cardsSet, cardItem);
                testQuestions.Add(question);
            }
            Random rand = new Random();
            testQuestions = testQuestions.OrderBy(_ => rand.Next()).ToList();
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
