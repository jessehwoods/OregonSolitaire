using OregonCardGame.Model;

namespace OregonCardGame.Controller
{

    /// <summary>
    /// This is the the controller for the game objects. It takes input from any interface being used, and handles the game state.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Used to check if the game is ended or is still going on.
        /// </summary>
        /// <remarks>
        /// Most functions of the game will stop working when it ends to avoid undefined behavior.
        /// </remarks>
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
        public int HighestAvailableIndex => layout.AvailableIndexes();

        /// <summary>
        /// Gives the highest index that a card in layout can have.
        /// </summary>
        public int HighestPossibleIndex => Layout.MaximumLayoutSize - 1;

        /// <summary>
        /// Gives the highest index that a card has been played to.
        /// </summary>
        public int HighestPlayedIndex => layout.LayoutCount - 1;

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
        /// Thrown if this is called when the game is over.
        /// </exception>
        public void StartNewLayout()
        {
            if (GameOver)
            {
                throw new InvalidOperationException("Cannot start a layout when game is over.");
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
        /// <exception cref="ArgumentException">
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
            if (idx < 0 || idx > HighestAvailableIndex)
            {
                throw new ArgumentException("Game is attempting to place a card outside allowed ranged of indexes.");
            }
            layout.PlaceCard(idx, DrawnCard);
            // See if game needs to end here
            if (deck.cardsInDeck <= 0)
            {
                EndGame();
            }
            else
            {
                DrawCard();
            }
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
                throw new InvalidOperationException("Cannot draw card when deck is empty.");
            }
            else
            {
                DrawnCard = deck.GetCard();
            }
        }

        /// <summary>
        /// Ends the game.
        /// </summary>
        private void EndGame()
        {
            Score += layout.Score;
            GameOver = true;
        }
    }
}