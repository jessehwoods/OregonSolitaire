namespace OregonCardGame.Model
{

    /// <summary>
    /// The deck will hold cards and be drawn from. 
    /// </summary>
    internal class Deck
    {
        /// <summary>
        /// The <c>Suits</c> property is the groups all cards will be divided in.
        /// </summary>
        internal enum Suits
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        /// <summary>
        /// The <c>Ranks</c> property is the cards that will be in each suit.
        /// </summary>
        internal enum Ranks
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace,
        }

        /// <summary>
        /// The <c>cards</c> property is all of the cards currently in the deck.
        /// </summary>
        private List<Card> cards;

        /// <summary>
        /// Accessor for the number of cards left in the deck.
        /// </summary>
        internal int cardsInDeck
        {
            get { return cards.Count; }
        }

        /// <summary>
        /// The <c>random</c> property is a randomizer for drawing random cards from the deck.
        /// </summary>
        private Random random;

        /// <summary>
        /// Creates a new deck of cards.
        /// </summary>
        /// <remarks>
        /// This constructor will create 1 of every rank/suit combination. 
        /// </remarks>
        internal Deck()
        {
            // Create the deck
            cards = new List<Card>();
            int DeckSize = Enum.GetNames(typeof(Suits)).Length * Enum.GetNames(typeof(Ranks)).Length;
            for (int i = 0; i < DeckSize; i++)
            {
                cards.Add(new Card( (Suits) (i % Enum.GetNames(typeof(Suits)).Length), (Ranks)(i % Enum.GetNames(typeof(Ranks)).Length)));
            }
            random = new Random();
        }

        /// <summary>
        /// Returns a random card and removes it from the deck
        /// </summary>
        /// <returns>A card which is removed from the deck.</returns>
        internal Card GetCard()
        {
            if (cards.Count <= 0)
            {
                throw new InvalidOperationException("Trying to draw from an empty deck.");
            }
            var idx = random.Next(cards.Count); 
            var cardToReturn = cards[idx];
            cards.RemoveAt(idx);
            return cardToReturn;
        }
        
    }
}
