namespace OregonCardGame.Model
{

    internal static class ScoreCalculator
    {
        /// <summary>
        /// Score value of a hand with five cards that are the same rank and sequential.
        /// </summary>
        internal const int StraightFlush = 10;

        /// <summary>
        /// Score value of a hand with four cards of the same rank.
        /// </summary>
        internal const int FourOfAKind = 7;

        /// <summary>
        /// Score value of a hand 
        /// </summary>
        internal const int FullHouse = 5;

        /// <summary>
        /// Score value of a hand with 5 cards of the same suit.
        /// </summary>
        internal const int Flush = 3;

        /// <summary>
        /// Score value of a hand with five sequential ranks.
        /// </summary>
        internal const int Straight = 3;

        /// <summary>
        /// Score values of three cards of same rank.
        /// </summary>
        internal const int ThreeOfAKind = 3;

        /// <summary>
        /// Score value of two sets of matching ranks.
        /// </summary>
        internal const int TwoPair = 2;

        /// <summary>
        /// Score value of one pair of matching ranks and only one pair.
        /// </summary>
        internal const int OnePair = 1;

        /// <summary>
        /// Score value of a hand when no other values are found.
        /// </summary>
        internal const int PluggedNickel = 0;

        /// <summary>
        /// Calculates the score of an input hand.
        /// </summary>
        /// <remarks>
        /// This function is built on the assumption that all input hands will be five cards or less. Undefined behavior may occur with larger hand sizes.
        /// </remarks>
        /// <param name="handToScore">
        /// This is a hand of Card objects, with suits and ranks, to be evaluated.
        /// </param>
        /// <returns>
        /// The score value of the input Hand object.
        /// </returns>
        internal static int CalculateScore( IEnumerable<Card> handToScore )
        {
            var score = PluggedNickel;
            if (IsStraightFlush(handToScore))
            {
                score = StraightFlush;
            }
            else if (IsFourOfAKind(handToScore))
            {
                score = FourOfAKind;
            }
            else if (IsFullHouse(handToScore))
            {
                score = FullHouse;
            }
            else if (IsStraight(handToScore))
            {
                score = Straight;
            }
            else if (IsFlush(handToScore))
            {
                score = Flush; 
            }
            else if (IsThreeOfAKind(handToScore))
            {
                score = ThreeOfAKind;
            }
            else if (IsTwoPair(handToScore))
            {
                score = TwoPair;
            }
            else if (IsOnePair(handToScore))
            {
                score = OnePair;
            }
            return score;
        }

        /// <summary>
        /// Checks for the existence of a three of a kind in the hand.
        /// </summary>
        /// <param name="handToScore">
        /// Hand to examine.
        /// </param>
        /// <returns>
        /// True if there is exactly one three of a kind in the hand.
        /// </returns>
        private static bool IsThreeOfAKind(IEnumerable<Card> handToScore)
        {
            return handToScore.GroupBy(card => card.Rank).Count(group => group.Count() == 3) == 1;
        }

        /// <summary>
        /// Checks for the existence of a a pair.
        /// </summary>
        /// <param name="handToScore">
        /// Hand to examine.
        /// </param>
        /// <returns>
        /// True if there is exactly one pair in the hand.
        /// </returns>
        private static bool IsOnePair(IEnumerable<Card> handToScore)
        {
            return handToScore.GroupBy(card => card.Rank).Count(group => group.Count() == 2) == 1;
        }

        /// <summary>
        /// Checks for two pairs in the input hand.
        /// </summary>
        /// <param name="handToScore">
        /// Hand to examine.
        /// </param>
        /// <returns>
        /// True if there is exactly two pairs in the hand.
        /// </returns>
        private static bool IsTwoPair(IEnumerable<Card> handToScore)
        {
            return handToScore.GroupBy(card => card.Rank).Count(group => group.Count() == 2) == 2;
        }

        /// <summary>
        /// Checks for a full house, (one pair and one three of a kind).
        /// </summary>
        /// <param name="handToScore">
        /// Hand to examine.
        /// </param>
        /// <returns>
        /// True if there is exactly one pair and exactly one three of a kind in the hand.
        /// </returns>
        private static bool IsFullHouse(IEnumerable<Card> handToScore)
        {
            return IsOnePair(handToScore) && IsThreeOfAKind(handToScore);
        }

        /// <summary>
        /// Checks for a four of a kind.
        /// </summary>
        /// <param name="handToScore">
        /// Hand to examine.
        /// </param>
        /// <returns>
        /// True if there is exactly one four of a kind in the hand.
        /// </returns>
        private static bool IsFourOfAKind(IEnumerable<Card> handToScore)
        {
            return handToScore.GroupBy(card => card.Rank).Count(group => group.Count() == 4) == 1;
        }

        /// <summary>
        /// Checks for a straight that is also a flush.
        /// </summary>
        /// <param name="handToScore">
        /// Hand to examine.
        /// </param>
        /// <returns>
        /// True if the hand is a straight flush.
        /// </returns>
        private static Boolean IsStraightFlush(IEnumerable<Card> handToScore)
        {
            return IsStraight(handToScore) && IsFlush(handToScore);
        }

        /// <summary>
        /// Checks for a flush (hand of 5 cards with the same suit).
        /// </summary>
        /// <param name="handToScore">
        /// Hand to examine.
        /// </param>
        /// <returns>
        /// True if there are five cards of the same suit in the hand.
        /// </returns>
        private static bool IsFlush(IEnumerable<Card> handToScore)
        {
            return handToScore.GroupBy(card => card.Suit).Count(group => group.Count() == 5) == 1;
        }

        /// <summary>
        /// Checks for a straight (at least five cards that increase in a monotonic sequence).
        /// </summary>
        /// <param name="handToScore"></param>
        /// <returns></returns>
        private static bool IsStraight(IEnumerable<Card> handToScore)
        {
            if (handToScore.Count() >= 5) //Make sure there's at least enough cards to make a straight
            {
                // Sort so the iteration will make more sense
                var sortedCards = handToScore.OrderBy(card => card.Rank).ToList();
                // Start tracking the number of ordered cards
                var maxSequenceSize = 0;
                var sequenceSize = 1;
                int valueToCompare = (int) sortedCards[0].Rank;
                for(int i = 1; i < sortedCards.Count; i++)
                {
                    if ((int)sortedCards[i].Rank - valueToCompare == 1) // Increased by one, so continuing sequence
                    {
                        sequenceSize++;
                        if (sequenceSize > maxSequenceSize)
                        {
                            maxSequenceSize = sequenceSize;
                        }
                    }
                    else if ((int)sortedCards[i].Rank != valueToCompare) // Sequence is broken
                    {
                        sequenceSize = 0;
                    }
                    valueToCompare = (int)sortedCards[i].Rank;
                }
                return maxSequenceSize >= 5;
            }
            return false; // Weren't enough cards in the hand for a straight
        }
    }
}
