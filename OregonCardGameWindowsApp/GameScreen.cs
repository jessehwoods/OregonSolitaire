using OregonCardGame.Controller;

namespace OregonCardGameWindowsApp
{
    public partial class GameScreen : Form
    {
        /// <summary>
        /// Event handler used to notify delegates when the game is done.
        /// </summary>
        public EventHandler GameCompleted;

        /// <summary>
        /// Holds the Game object that handles the game rules.
        /// </summary>
        private Game game;

        /// <summary>
        /// These are the cards in the layout.
        /// </summary>
        private List<PictureBox> layoutCards;

        public GameScreen()
        {
            InitializeComponent();
            game = new Game();
            layoutCards = new List<PictureBox> { layoutIndex0, layoutIndex1, layoutIndex2, layoutIndex3, layoutIndex4 };
            deckBox.Image = Properties.Resources.cardback;
            UpdateGameScreen();
        }

        private void layoutIndex0_Click(object sender, EventArgs e)
        {
            PlaceCard(0);
        }

        private void layoutIndex1_Click(object sender, EventArgs e)
        {
            PlaceCard(1);
        }

        private void layoutIndex2_Click(object sender, EventArgs e)
        {
            PlaceCard(2);
        }

        private void layoutIndex3_Click(object sender, EventArgs e)
        {
            PlaceCard(3);
        }

        private void layoutIndex4_Click(object sender, EventArgs e)
        {
            PlaceCard(4);
        }

        private void buttonStartNewLayout_Click(object sender, EventArgs e)
        {
            game.StartNewLayout();
            UpdateGameScreen();
        }

        private void PlaceCard(int v)
        {
            game.PlaceCard(v);
            UpdateGameScreen();
        }

        /// <summary>
        /// Internal method that updates the GameScreen to match the contents of the Game object.
        /// </summary>
        private void UpdateGameScreen()
        {
            // Get the pictures for the layout as a queue
            var cardsInLayout = new Queue<String>(game.CardsInLayout.Split(','));
            // Add the images
            for (int i = 0; i < layoutCards.Count; i++)
            {
                if (cardsInLayout.Count >= 2)
                {
                    layoutCards[i].Image = GetCardPicture(cardsInLayout.Dequeue(), cardsInLayout.Dequeue());
                    layoutCards[i].Enabled = true;
                }
                else if (i <= game.HighestAvailableIndex)
                {
                    layoutCards[i].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("empty_ready");
                    layoutCards[i].Enabled = true;
                }
                else
                {
                    layoutCards[i].Image = null;
                    layoutCards[i].Enabled = false;
                }
            }
            // Now check if the game is over
            if (game.GameOver)
            {
                // Finish game
                EndGame();
            }
            else
            {
                // Game isn't over, so need to deal with the rest.
                // Get the drawn card
                var availableCardString = game.AvailableCard.Split(',');
                drawnCardBox.Image = GetCardPicture(availableCardString[0], availableCardString[1]);
                // Update layout score
                labelLayoutScore.Text = Properties.Resources.LayoutScore + game.LayoutScore;
                // Update total score
                labelTotalScore.Text = Properties.Resources.TotalScore + game.Score;
                // Update cards left in deck
                cardsInDeck.Text = "Cards left in deck: " + game.CardsInDeck;
                if (game.CardsInDeck <= 0)
                {
                    deckBox.Image = null;
                }
            }
        }

        /// <summary>
        /// Helper class to get card pictures from the resources file.
        /// </summary>
        /// <param name="rank">
        /// Rank of the card
        /// </param>
        /// <param name="suit">
        /// Suit of the card.
        /// </param>
        /// <returns>
        /// The image for the card from the resources file.
        /// </returns>
        private Bitmap GetCardPicture(string rank, string suit)
        {
            Bitmap bitmap = null;
            bitmap = (Bitmap)Properties.Resources.ResourceManager.GetObject(rank.ToLower() + "_" + suit.ToLower());
            if (bitmap == null)
            {
                bitmap = (Bitmap)Properties.Resources.ResourceManager.GetObject("error");
            }
            return bitmap;
        }

        /// <summary>
        /// Ends the game and gets rid of functionality.
        /// </summary>
        private void EndGame()
        {
            foreach (PictureBox pb in layoutCards)
            {
                pb.Enabled = false;
            }
            buttonStartNewLayout.Enabled = false;
            drawnCardBox.Image = null;
            labelLayoutScore.Text = null;
            labelTotalScore.Text = Properties.Resources.TotalScore + game.Score;

        }

        /// <summary>
        /// Custom event that notifies delegates the game is completed and they can go back to something else.
        /// </summary>
        private void buttonToStart_Click(object sender, EventArgs e)
        {
            EventHandler handler = GameCompleted;
            handler?.Invoke(this, e);
            this.Close();
        }
    }
}