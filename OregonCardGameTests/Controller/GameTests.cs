using OregonCardGame.Controller;

namespace OregonCardGameTests.Controller
{
    [TestClass]
    public class GameTests
    {

        [TestMethod]
        public void TestDraw()
        {
            var testGame = new Game();
            // Draw all cards from deck
            for (int i = 0; i < 50; i++)
            {
                Assert.AreEqual(50 - i, testGame.CardsInDeck) ;
                testGame.PlaceCard(0);
                Assert.IsFalse(testGame.GameOver);
            }
            testGame.PlaceCard(0);
            Assert.IsTrue(testGame.GameOver);

        }
    }
}

