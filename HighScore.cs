using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectlf6
{
    public partial class HighScore : Form
    {
        private HighscoreControl highscoreControl;

        public HighScore(string player, string game, int score, int levels, int rounds)
        {
            InitializeComponent();
            this.highscoreControl = new HighscoreControl();
            this.highscoreControl.addHighscore(player, game, score, levels, rounds);
            this.fillHighscoreList();
        }

        public HighScore()
        {
            InitializeComponent();
            this.highscoreControl = new HighscoreControl();
            this.fillHighscoreList();
        }

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

        private void btnCloseHighscore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
