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
	public partial class ScoreView : Form
	{
		private Player playerOne;
		private Player playerTwo;
		private Game game;

		public ScoreView(Player playerOne, Player playerTwo, Game game)
		{
			InitializeComponent();
			this.playerOne = playerOne;
			this.playerTwo = playerTwo;
			this.game = game;
			showScoreLists();
		}

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
                }
                else
                {
                    dgvScoreView.Rows.Add(0, i + 1, 0);
                }
               
			}

            int totalScoreP1 = playerOne.getScore().getTotalscore();
            int totalScoreP2 = playerTwo.getScore().getTotalscore();

            dgvScoreView.Rows.Add(totalScoreP1, "Total", totalScoreP2);

			if (game.hasNext())
			{
				btnNext.Text = "Nächster Level spielen";
			}
			else
			{
				btnNext.Text = "Spiel beendet";
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
