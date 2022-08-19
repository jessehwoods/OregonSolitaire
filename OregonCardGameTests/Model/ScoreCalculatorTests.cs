using OregonCardGame.Model;

namespace OregonCardGameTests.Model

{
    [TestClass]
    public class ScoreCalculatorTests
    {
        [TestMethod]
        public void StraightFlushTest()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Two));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Three));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Four));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Five));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Six));

            Assert.AreEqual(ScoreCalculator.StraightFlush, ScoreCalculator.CalculateScore(hand));
        }

        [TestMethod]
        public void FourOfAKindTest()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Ace));
            hand.Add(new Card(Deck.Suits.Diamonds, Deck.Ranks.Ace));
            hand.Add(new Card(Deck.Suits.Hearts, Deck.Ranks.Ace));
            hand.Add(new Card(Deck.Suits.Spades, Deck.Ranks.Ace));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Six));

            Assert.AreEqual(ScoreCalculator.FourOfAKind, ScoreCalculator.CalculateScore(hand));
        }

        [TestMethod]
        public void FullHouseTest()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Three));
            hand.Add(new Card(Deck.Suits.Diamonds, Deck.Ranks.Three));
            hand.Add(new Card(Deck.Suits.Hearts, Deck.Ranks.Three));
            hand.Add(new Card(Deck.Suits.Diamonds, Deck.Ranks.Two));
            hand.Add(new Card(Deck.Suits.Spades, Deck.Ranks.Two));

            Assert.AreEqual(ScoreCalculator.FullHouse, ScoreCalculator.CalculateScore(hand));
        }

        [TestMethod]
        public void FlushTest()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Two));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Three));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Four));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Five));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Ace));

            Assert.AreEqual(ScoreCalculator.Flush, ScoreCalculator.CalculateScore(hand));
        }

        [TestMethod]
        public void StraightTest()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Two));
            hand.Add(new Card(Deck.Suits.Diamonds, Deck.Ranks.Three));
            hand.Add(new Card(Deck.Suits.Hearts, Deck.Ranks.Four));
            hand.Add(new Card(Deck.Suits.Spades, Deck.Ranks.Five));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Six));

            Assert.AreEqual(ScoreCalculator.Straight, ScoreCalculator.CalculateScore(hand));
        }

        [TestMethod]
        public void ThreeOfAKindTest()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Ace));
            hand.Add(new Card(Deck.Suits.Diamonds, Deck.Ranks.Ace));
            hand.Add(new Card(Deck.Suits.Hearts, Deck.Ranks.Ace));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Five));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Six));

            Assert.AreEqual(ScoreCalculator.ThreeOfAKind, ScoreCalculator.CalculateScore(hand));
        }

        [TestMethod]
        public void TwoPairsTest()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Two));
            hand.Add(new Card(Deck.Suits.Diamonds, Deck.Ranks.Two));
            hand.Add(new Card(Deck.Suits.Hearts, Deck.Ranks.Ace));
            hand.Add(new Card(Deck.Suits.Spades, Deck.Ranks.Ace));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Six));

            Assert.AreEqual(ScoreCalculator.TwoPair, ScoreCalculator.CalculateScore(hand));
        }

        [TestMethod]
        public void OnePairTest()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Two));
            hand.Add(new Card(Deck.Suits.Hearts, Deck.Ranks.Two));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Four));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Five));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Six));

            Assert.AreEqual(ScoreCalculator.OnePair, ScoreCalculator.CalculateScore(hand));
        }

        [TestMethod]
        public void PluggedNickelTest()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Two));
            hand.Add(new Card(Deck.Suits.Hearts, Deck.Ranks.Three));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Four));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Five));
            hand.Add(new Card(Deck.Suits.Clubs, Deck.Ranks.Ace));

            Assert.AreEqual(ScoreCalculator.PluggedNickel, ScoreCalculator.CalculateScore(hand));
        }
    }
}