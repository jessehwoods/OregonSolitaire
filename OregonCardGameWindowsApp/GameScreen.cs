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
            UpdateGameScreen();
        }

        private void layoutIndex0_Click(object sender, EventArgs e)
        {
            labelLayoutScore.Text = "1";
        }

        private void layoutIndex1_Click(object sender, EventArgs e)
        {
            labelLayoutScore.Text = "1";
        }

        private void layoutIndex2_Click(object sender, EventArgs e)
        {
            labelLayoutScore.Text = "2";
        }

        private void layoutIndex3_Click(object sender, EventArgs e)
        {
            labelLayoutScore.Text = "3";
        }

        private void layoutIndex4_Click(object sender, EventArgs e)
        {
            labelLayoutScore.Text = "4";
        }

        private void buttonStartNewLayout_Click(object sender, EventArgs e)
        {
            labelLayoutScore.Text = "new";
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
            // Get the cards in the layout and get the pictures of them
            string[] cardsInLayout = game.CardsInLayout.Split(',');
            // Get the drawn card

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