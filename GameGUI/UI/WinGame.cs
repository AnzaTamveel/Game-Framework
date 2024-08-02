using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGameGUI.UI
{
    public partial class WinGame : Form
    {
        string ScoreDisplay;

        public WinGame(string scoreDisplay)
        {
            InitializeComponent();
            this.ScoreDisplay = scoreDisplay;
        }

        private void WinGame_Load(object sender, EventArgs e)
        {
            Score_show.Text = ScoreDisplay;
        }

        private void Restart_game_Click(object sender, EventArgs e)
        {
          /*  this.Hide();
            FrontPage forntPage = new FrontPage();
            forntPage.Show();*/
        }
    }
}
