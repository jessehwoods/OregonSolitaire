namespace OregonCardGameWindowsApp
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        private void laoutIndex0_Click(object sender, EventArgs e)
        {
            labelLayoutScore.Text = "0";
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
    }
}