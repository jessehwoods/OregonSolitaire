
using static OregonCardGame.Model.Deck;

namespace OregonCardGame.Model
{

    /// <summary>
    /// Holds a Rank value and Suit value, determined by the Deck.
    /// </summary>
    internal class Card : IComparable<Card>
    {
        /// <summary>
        /// Suit of the card.
        /// </summary>
        internal Suits Suit { get; private set; }

        /// <summary>
        /// Rank of the card within the Suit.
        /// </summary>
        internal Ranks Rank { get; private set; }

        /// <summary>
        /// Creates a Card object.
        /// </summary>
        /// <param name="suit">
        /// Sets suit for the created Card.
        /// </param>
        /// <param name="rank">
        /// Sets rank for the created Card.
        /// </param>
        internal Card(Suits suit, Ranks rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        public int CompareTo(Card? other)
        {
            if (!(other is Card))
            {
                throw new ArgumentException("Card cannot be compared to a non-Card.");
            }
            return this.Rank.CompareTo(other.Rank);
        }

        public override string ToString()
        {
            return Rank.ToString() + "," + Suit.ToString();
        }
    }
}
