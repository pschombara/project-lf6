using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.IO;

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
                this.addDefaultGames();
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

        private void addDefaultGames()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            this.copyDirectory(path + "\\Templates\\games", MAIN_PATH + "games\\");
        }

        private void copyDirectory(string source, string dest)
        {
            DirectoryInfo dir = new DirectoryInfo(source);

            if (dir.Exists)
            {
                FileInfo[] files = dir.GetFiles();

                if (!Directory.Exists(dest))
                {
                    Directory.CreateDirectory(dest);
                }

                foreach (FileInfo file in files)
                {
                    string temp = Path.Combine(dest, file.Name);
                    file.CopyTo(temp, false);
                }

                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo subdir in dirs)
                {
                    string temp = Path.Combine(dest, subdir.Name);
                    this.copyDirectory(subdir.FullName, temp);
                }
            }

        }

        private void btnOpenHighscore_Click(object sender, EventArgs e)
        {
            Form highscore = new HighScore();
            highscore.ShowDialog();
        }
    }
}