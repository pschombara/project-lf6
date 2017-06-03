using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace projectlf6
{
	public partial class MainMenu : Form
	{
		private string MAIN_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\projectlf6\\";
        FormSplash formSplash;

        public MainMenu()
		{
			InitializeComponent();
            //SplashScreen
            formSplash = new FormSplash();
            formSplash.Show();
            Thread.Sleep(2000);
            formSplash.Close();

            CreateFolderTree();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
            this.Close();
		}

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form Help = new Help();
            Help.ShowDialog();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
		{
			Form newGame = new newGame();
			newGame.ShowDialog();
		}

		private void btnLevelEditor_Click(object sender, EventArgs e)
		{
			Form gameEditor = new GameEditor();
			gameEditor.ShowDialog();
		}

		private void CreateFolderTree()
		{
			if (!Directory.Exists(MAIN_PATH))
			{
				Directory.CreateDirectory(MAIN_PATH);
			}

			if (!Directory.Exists(MAIN_PATH + "games\\"))
			{
				Directory.CreateDirectory(MAIN_PATH + "games\\");
			}

			if (!Directory.Exists(MAIN_PATH + "player\\"))
			{
				Directory.CreateDirectory(MAIN_PATH + "player\\");
			}

			if (!Directory.Exists(MAIN_PATH + "save\\"))
			{
				Directory.CreateDirectory(MAIN_PATH + "save\\");
			}
		}

        private void btnOpenHighscore_Click(object sender, EventArgs e)
        {
            Form highscore = new HighScore();
            highscore.ShowDialog();
        }
    }
}