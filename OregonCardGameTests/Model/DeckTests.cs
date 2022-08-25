using OregonCardGame.Model;

namespace OregonCardGameTests.Model
{
    [TestClass]
    public class GameTests
    {

        [TestMethod]
        public void TestDraw()
        {
            var drawnCards = new HashSet<Card>();
            var testDeck = new Deck();
            // Draw all cards from deck
            for (int i = 0; i < 52; i++)
            {
                Assert.AreEqual(52 - i, testDeck.cardsInDeck) ;
                var card = testDeck.GetCard();
                Assert.IsFalse(drawnCards.Contains(card));
                drawnCards.Add(card);
            }
            Assert.AreEqual(0, testDeck.cardsInDeck);
        }
    }
}

