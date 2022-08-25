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

    public partial class RulesScreen : Form
    {

        public event EventHandler StartButtonClicked;

        public RulesScreen()
        {
            InitializeComponent();
            textBoxRules.Text = Properties.Resources.rules_text;
        }

        private void buttonToStart_Click(object sender, EventArgs e)
        {
            EventHandler handler = StartButtonClicked;
            handler?.Invoke(this, e);
            this.Close();
        }
    }
}
