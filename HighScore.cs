using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesHunter
{
    public partial class HighScore : Form
    {
        private HighscoreControl highscoreControl;

        /**
         * Class constructor HighScore
         * 
         * @param string player player name
         * @param string game   game name
         * @param int    score  player total score
         * @param int    levels levels of game
         * @param int    rounds rounds per level
         */
        public HighScore(string player, string game, int score, int levels, int rounds)
        {
            InitializeComponent();
            this.highscoreControl = new HighscoreControl();
            this.highscoreControl.addHighscore(player, game, score, levels, rounds);
            this.fillHighscoreList();
        }

        /**
         * Class constructor HighScore
         */
        public HighScore()
        {
            InitializeComponent();
            this.highscoreControl = new HighscoreControl();
            this.fillHighscoreList();
        }

        /**
         * Fill the data grid view with highscore list 
         */
        private void fillHighscoreList()
        {
            List<HighscoreItem> highscore = this.highscoreControl.getHighscore();

            for (int i = 0; i < highscore.Count; i++)
            {
                this.dgvHighscore.Rows.Add(
                    i + 1,
                    highscore[i].getPlayer(),
                    highscore[i].getGame(),
                    highscore[i].getLevels(),
                    highscore[i].getRounds(),
                    highscore[i].getScore()
                );
            }
        }

         /**
         * Event handler button close highscore
         * 
         * @param object    sender sender
         * @param EventArgs e      event arguments
         */
        private void btnCloseHighscore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Event handler button reset highscore
         * 
         * @param object    sender sender
         * @param EventArgs e      event arguments
         */
        private void btnResetHighscore_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Wollen Sie den Highscore wirklich löschen? Alle Daten werden Unwiderruflich gelöscht!",
                "Highscore zurücksetzen?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                this.highscoreControl.reset();
                this.dgvHighscore.Rows.Clear();
            }
        }

        /**
         * Event handler help
         * 
         * @param object       sender sender
         * @param KeyEventArgs e      key event arguments
         */
        private void HighScore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Form Help = new Help();
                Help.ShowDialog();
            }
        }
    }
}
