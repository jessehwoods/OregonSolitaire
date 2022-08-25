using OregonCardGame.Model;

namespace OregonCardGameTests.Model
{
    [TestClass]
    public class LayoutTests
    {

        [TestMethod]
        public void PlaceCardTests()
        {
            // Make some cards, first five contains a pair, adding the sixth gives you a straight flush.
            Card c1 = new Card(Deck.Suits.Clubs, Deck.Ranks.Ace);
            Card c2 = new Card(Deck.Suits.Hearts, Deck.Ranks.Ace);
            Card c3 = new Card(Deck.Suits.Clubs, Deck.Ranks.King);
            Card c4 = new Card(Deck.Suits.Clubs, Deck.Ranks.Queen);
            Card c5 = new Card(Deck.Suits.Clubs, Deck.Ranks.Jack);
            Card c6 = new Card(Deck.Suits.Clubs, Deck.Ranks.Ten);

            // Make a hand and cards
            Layout testHand = new Layout();
            testHand.PlaceCard(0, c1);
            Assert.AreEqual(c1.ToString(), testHand.ToString());
            Assert.AreEqual(ScoreCalculator.PluggedNickel, testHand.Score);
            Assert.IsFalse(testHand.Full);

            // Try using ReplaceCard outside current hand
            try
            {
                testHand.PlaceCard(2, c2);
                Assert.Fail();
            } catch (IndexOutOfRangeException)
            {
                Assert.AreEqual(c1.ToString(), testHand.ToString());
                Assert.AreEqual(ScoreCalculator.PluggedNickel, testHand.Score);
                Assert.IsFalse(testHand.Full);
            }

            testHand.PlaceCard(1, c2);
            testHand.PlaceCard(2, c3);
            testHand.PlaceCard(3, c4);
            testHand.PlaceCard(4, c5);
            Assert.AreEqual(c1.ToString() + "," + c2.ToString() + "," + c3.ToString() + "," + c4.ToString() + "," + c5.ToString(), testHand.ToString());
            Assert.AreEqual(ScoreCalculator.OnePair, testHand.Score);
            Assert.IsTrue(testHand.Full);

            // Try adding to invalid indexes
            try
            {
                testHand.PlaceCard(-1, c6);
                Assert.Fail();
            } catch (IndexOutOfRangeException)
            {
                Assert.AreEqual(c1.ToString() + "," + c2.ToString() + "," + c3.ToString() + "," + c4.ToString() + "," + c5.ToString(), testHand.ToString());
                Assert.AreEqual(ScoreCalculator.OnePair, testHand.Score);
                Assert.IsTrue(testHand.Full);
            }
            try
            {
                testHand.PlaceCard(Layout.MaximumLayoutSize + 1, c6);
                Assert.Fail();
            }
            catch (IndexOutOfRangeException)
            {
                Assert.AreEqual(c1.ToString() + "," + c2.ToString() + "," + c3.ToString() + "," + c4.ToString() + "," + c5.ToString(), testHand.ToString());
                Assert.AreEqual(ScoreCalculator.OnePair, testHand.Score);
                Assert.IsTrue(testHand.Full);
            }

            // Overwrite c2 to make the hand a straight flush
            testHand.PlaceCard(1, c6);
            Assert.AreEqual(c1.ToString() + "," + c6.ToString() + "," + c3.ToString() + "," + c4.ToString() + "," + c5.ToString(), testHand.ToString());
            Assert.AreEqual(ScoreCalculator.StraightFlush, testHand.Score);
            Assert.IsTrue(testHand.Full);

            // Replace each of the indexes
            for (int i = 0; i < Layout.MaximumLayoutSize; i++)
            {
                testHand.PlaceCard(i, c2);
            }
            Assert.AreEqual(c2.ToString() + "," + c2.ToString() + "," + c2.ToString() + "," + c2.ToString() + "," + c2.ToString(), testHand.ToString());
            Assert.IsTrue(testHand.Full);
        }
    }
}

