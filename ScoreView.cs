﻿using minesHunter.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesHunter
{
    public partial class ScoreView : Form
    {
        private Player playerOne;
        private Player playerTwo;
        private Game game;
        private int rounds;

        /**
         * Class constructor ScoreView
         * 
         * @param Player playerOne first  player for score
         * @param Player playerTwo second player for score
         * @param Game   game      played game
         * @param int    rounds    rounds to play for levels
         */
        public ScoreView(Player playerOne, Player playerTwo, Game game, int rounds)
        {
            InitializeComponent();
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.game = game;
            this.rounds = rounds;
            showScoreLists();
            SoundPlayer player = new SoundPlayer(ResourceSound.levelup);
            player.Play();
        }

        /**
         * Show the score list
         */
        private void showScoreLists()
        {
            int levelCount = game.getLevels().Count;
            int activeLevel = game.getLevels().IndexOf(game.getActiveLevel());
            List<int> scoresP1 = playerOne.getScore().getScoreList();
            List<int> scoresP2 = playerTwo.getScore().getScoreList();

            dgvScoreView.Columns["scorePlayerOne"].HeaderText = "Punkte " + playerOne.getName();
            dgvScoreView.Columns["scorePlayerTwo"].HeaderText = "Punkte " + playerTwo.getName();

            for (int i = 0; i < levelCount; i++)
            {
                if (i <= activeLevel)
                {
                    dgvScoreView.Rows.Add(scoresP1[i], i + 1, scoresP2[i]);
                    dgvScoreView.Rows[i].DefaultCellStyle.Font = new Font(this.Font.FontFamily, this.Font.Height, FontStyle.Bold);
                }
                else
                {
                    dgvScoreView.Rows.Add(0, i + 1, 0);
                }
            }

            int totalScoreP1 = playerOne.getScore().getTotalscore();
            int totalScoreP2 = playerTwo.getScore().getTotalscore();

            dgvScoreView.Rows.Add(totalScoreP1, "Total", totalScoreP2);
            dgvScoreView.Rows[dgvScoreView.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 16.0f, FontStyle.Bold | FontStyle.Underline);
            dgvScoreView.Rows[dgvScoreView.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Blue;

            if (game.hasNext())
            {
                btnNext.Text = "Nächster Level spielen";
            }
            else
            {
                btnNext.Text = "Spiel beendet";
            }
        }

        /**
         * Handle click on button
         * 
         * @param object   sender sender
         * @param EventArg e      event arguments
         */
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!this.game.hasNext())
            {
                string gameName = this.game.getName();
                int levels = this.game.getLevels().Count;

                if (this.playerOne.getScore().getTotalscore() > this.playerTwo.getScore().getTotalscore())
                {
                    Form highscore = new HighScore(this.playerOne.getName(), gameName, this.playerOne.getScore().getTotalscore(), levels, this.rounds);
                    highscore.ShowDialog();
                }
                else if (this.playerOne.getScore().getTotalscore() < this.playerTwo.getScore().getTotalscore())
                {
                    Form highscore = new HighScore(this.playerTwo.getName(), gameName, this.playerTwo.getScore().getTotalscore(), levels, this.rounds);
                    highscore.ShowDialog();
                }
            }

            this.Close();
        }

        /**
         * Handle key down event
         * 
         * @param object       sender sender
         * @param KeyEventArgs e      key event arguments
         */
        private void ScoreView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Form Help = new Help();
                Help.ShowDialog();
            }
        }
    }
}
