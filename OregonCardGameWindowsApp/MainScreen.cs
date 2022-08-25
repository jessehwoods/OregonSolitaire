using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OregonCardGameWindowsApp
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            OpenStartScreen(); 
        }

        private void OpenStartScreen()
        {
            panelMain.Controls.Clear();
            StartScreen startScreen = new StartScreen() { TopLevel = false, TopMost = true };
            panelMain.Controls.Add(startScreen);
            startScreen.FormBorderStyle = FormBorderStyle.None;
            // Watch for start of game
            startScreen.StartButtonClicked += StartGame;
            // Watch for request for rules
            startScreen.RulesButtonClicked += RulesDisplay;
            startScreen.Show();
        }

        /// <summary>
        /// Starts the game screen.
        /// </summary>
        private void StartGame(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            GameScreen gameScreen = new GameScreen() { TopLevel = false, TopMost = true };
            panelMain.Controls.Add(gameScreen);
            gameScreen.FormBorderStyle = FormBorderStyle.None;
            // Watch for game being completed
            gameScreen.GameCompleted += GoToStartScreen;
            gameScreen.Show();
        }

        private void GoToStartScreen(object sender, EventArgs e)
        {
            OpenStartScreen();
        }

        /// <summary>
        /// Opens the rules screen.
        /// </summary>
        private void RulesDisplay(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            RulesScreen rulesScreen = new RulesScreen() { TopLevel = false, TopMost = true };
            panelMain.Controls.Add(rulesScreen);
            rulesScreen.FormBorderStyle = FormBorderStyle.None;
            // Watch for game being completed
            rulesScreen.StartButtonClicked += GoToStartScreen;
            rulesScreen.Show();
        }

    }
}
