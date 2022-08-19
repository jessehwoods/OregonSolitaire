using OregonCardGame.Model;

namespace OregonCardGame.Controller
{

    /*
     * This is the model of the game. It functions as the controller for the game objects and takes
     * input from any interface being used.
     */
    public class Game
    {
        /// <summary>
        /// Used to check if the game is complete.
        /// </summary>
        public bool GameOver { get; private set; }

        /// <summary>
        /// Deck to be drawn from for the game.
        /// </summary>
        private Deck deck;

        /// <summary>
        /// Accessor for number of cards left in the deck.
        /// </summary>
        public int CardsInDeck
        {
            get { return deck.cardsInDeck; }
        }

        /// <summary>
        /// Provides the score of the current layout
        /// </summary>
        public int LayoutScore
        {
            get { return layout.Score; }
        }

        /// <summary>
        /// Layout currently in use by the game.
        /// </summary>
        private Layout layout;

        /// <summary>
        /// Returns the cards in the layout as a string of comma-separated values, in the form "rank,suit"
        /// </summary>
        public string CardsInLayout
        {
            get { return layout.ToString(); }
        }

        /// <summary>
        /// Gives the highest index that can have a card legally placed in it.
        /// </summary>
        public int HighestAvailableIndex => AvailableIndexes();

        /// <summary>
        /// Card that has been taken from deck, but not played to layout yet.
        /// </summary>
        private Card DrawnCard;

        /// <summary>
        /// Returns the drawn card as a string in the form "rank,suit"
        /// </summary>
        public string AvailableCard => DrawnCard.ToString();

        /// <summary>
        /// Total score for the game, over multiple layouts.
        /// </summary>
        public int Score { get; private set; }

        /// <summary>
        /// Creates a Game object, ready to start playing.
        /// </summary>
        public Game()
        {
            GameOver = false;
            deck = new Deck();
            layout = new Layout();
            Score = 0;
            // Draw first card and start first hand.
            DrawCard();
            StartNewLayout();
        }

        /// <summary>
        /// Uses the drawn card to start a new layout.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Thrown if this is called when there is no drawn card.
        /// </exception>
        public void StartNewLayout()
        {
            if (GameOver)
            {
                throw new InvalidOperationException("Cannot start a layout when game is over.");
            }
            if (DrawnCard == null)
            {
                throw new InvalidOperationException("Cannot start a layout when there is no drawn card.");
            }
            Score += layout.Score;
            layout = new Layout();
            PlaceCard(0);
        }

        /// <summary>
        /// Puts a card in the layout at the provided index.
        /// </summary>
        /// <param name="idx">
        /// The index for the card to be placed.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the DrawnCard is null.
        /// </exception>
        /// <exception cref="IndexOutOfRangeException">
        /// Thrown if the index is outside of the current hand size + 1 or over maximum hand size.
        /// </exception>
        public void PlaceCard(int idx)
        {
            if (GameOver)
            {
                throw new InvalidOperationException("Cannot place card when game is over.");
            }
            if (DrawnCard == null)
            {
                throw new InvalidOperationException("Cannot place a card in Layout with no drawn card.");
            }
            if (idx > layout.LayoutCount || idx >= Layout.MaximumLayoutSize)
            {
                throw new IndexOutOfRangeException("Trying to add card to an invalid index in layout");
            }
            if (idx == layout.LayoutCount)
            {
                layout.FillLayout(DrawnCard);
            }
            else
            {
                layout.ReplaceCard(idx, DrawnCard);
            }
            DrawCard();
        }

        /// <summary>
        /// Draws a card from the deck and puts it in the DrawnCard.
        /// </summary>
        private void DrawCard()
        {
            if (GameOver)
            {
                throw new InvalidOperationException("Cannot draw card when game is over.");
            }
            if (deck.cardsInDeck == 0)
            {
                EndGame(); 
            }
            DrawnCard = deck.GetCard();
        }

        /// <summary>
        /// Ends the game.
        /// </summary>
        private void EndGame()
        {
            Score += layout.Score;
            GameOver = true;
        }

        /// <summary>
        /// Gives a number indicating what indexes can have cards placed in them by giving the highest number.
        /// </summary>
        /// <remarks>
        /// Any lower indexes (starting at 0) can also have cards placed in them.
        /// </remarks>
        /// <returns>
        /// The highest index that can be played in.
        /// </returns>
        private int AvailableIndexes()
        {
            if (layout.LayoutCount < Layout.MaximumLayoutSize)
            {
                return layout.LayoutCount;
            }
            return Layout.MaximumLayoutSize;
        }
    }
}