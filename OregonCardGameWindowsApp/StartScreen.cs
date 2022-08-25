namespace OregonCardGameWindowsApp
{
    public partial class StartScreen : Form
    {
        public event EventHandler StartButtonClicked;

        public event EventHandler RulesButtonClicked;

        public StartScreen()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            EventHandler handler = StartButtonClicked;
            handler?.Invoke(this, e);
            this.Close();
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            EventHandler handler = RulesButtonClicked;
            handler?.Invoke(this, e);
            this.Close();
        }
    }

}
