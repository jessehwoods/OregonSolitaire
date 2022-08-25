using OregonCardGame.Controller;

namespace OregonCardGameWindowsApp
{
    public partial class GameScreen : Form
    {
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
            layoutCards = new List<PictureBox> {layoutIndex0, layoutIndex1, layoutIndex2, layoutIndex3, layoutIndex4};
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
            // Check if game is over
            if (game.GameOver)
            {
                // Finish game
                EndGame();
            }
            //Clear the cards in the layout
            foreach (PictureBox pb in layoutCards)
            {
                pb.Image = null;
            }
            // Get the cards in the layout and get the pictures of them
            string[] cardsInLayout = game.CardsInLayout.Split(',');
            for(int i = 0; i <= game.HighestAvailableIndex; i++)
            {
                layoutCards[i].Image = Properties.Resources.ace_clubs;
            }
            // Get the drawn card
            var availableCardStringArray = game.AvailableCard.Split();
            drawnCardBox.Image = Properties.Resources.empty_ready;
            // Update layout score
            labelLayoutScore.Text = "Layout score: " + game.LayoutScore;
            // Update total score
            labelTotalScore.Text = " Total score: " + game.Score;
        }

        private void EndGame()
        {
            throw new NotImplementedException();
        }


    }
}