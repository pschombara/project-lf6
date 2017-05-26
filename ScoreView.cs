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


			string lvlText = "";
			string scoresP1Text = "";
			string scoresP2Text = "";

			for (int i = 0; i < levelCount; i++)
			{
				lvlText += (i + 1) + "\r\n";

				if (i <= activeLevel)
				{
					scoresP1Text += scoresP1[i] + "\r\n";
					scoresP2Text += scoresP2[i] + "\r\n";
				}
				else
				{
					scoresP1Text += "\r\n";
					scoresP2Text += "\r\n";
				}
			}

			int height = (txtLevel.Font.Height ) * levelCount;
			

			txtLevel.Height = height;
			txtScoreP1.Height = height;
			txtScoreP2.Height = height;

			this.Height = height + 120;

			txtLevel.Text = lvlText;
			txtScoreP1.Text = scoresP1Text;
			txtScoreP2.Text = scoresP2Text;
			txtNameP1.Text = playerOne.getName();
			txtNameP2.Text = playerTwo.getName();

			txtTotalScoreP1.Text = playerOne.getScore().getTotalscore().ToString();
			txtTotalScoreP2.Text = playerTwo.getScore().getTotalscore().ToString();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
