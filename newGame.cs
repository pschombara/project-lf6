using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace projectlf6
{
    public partial class newGame : Form
    {
        private List<string> playerList;
        public newGame()
        {
            InitializeComponent();
            this.playerList = new List<string>();

            this.prepareFillComboBox();
            this.fillPlayerComboBox(this.cbPlayerOneProfile);
            this.fillPlayerComboBox(this.cbPlayerTwoProfile);
            this.fillGameComboBox();
        }

        private void prepareFillComboBox()
        {
            FileInfo[] files = new DirectoryInfo(Global.PATH_PLAYER_FOLDER).GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Name.Contains("player_"))
                {
                    string playerName = files[i].Name.Replace("player_", "").Replace(".xml", "");

                    this.playerList.Add(playerName);
                }
            }
        }

        private void fillPlayerComboBox(ComboBox box)
        {
            box.Items.Clear();
            for (int i = 0; i < this.playerList.Count; i++)
            {
                box.Items.Add(playerList.ElementAt(i));
            }
        }

        private void fillGameComboBox()
        {
            Games games = new Games();

            for (int i = 0; i < games.getNumberOfGames(); i++)
            {
                this.cbGames.Items.Add(games.getGameName(i));
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Player playerOne;
            Player playerTwo;
            string playerOneName = this.cbPlayerOneProfile.Text;
            string playerTwoName = this.cbPlayerTwoProfile.Text;

            if (this.checkGameStart())
            {
                playerOne = new Player(playerOneName);
                playerTwo = new Player(playerTwoName);
                Form GameMain = new GameMain(playerOne, playerTwo);
                GameMain.ShowDialog();
            }
        }

        private void cbPlayerOneProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = new Player();
            player.loadFromFile(this.cbPlayerOneProfile.SelectedItem.ToString());
        }

        private bool checkGameStart()
        {
            bool start = true;

            if (this.cbPlayerOneProfile.Text == "")
            {
                start = false;
                MessageBox.Show("Bitte wählen Sie einen Spieler für Spieler 1 aus.");
            }
            else if (this.cbPlayerTwoProfile.Text == "")
            {
                start = false;
                MessageBox.Show("Bitte wählen Sie einen Spieler für Spieler 2 aus.");
            }
            else if (this.cbPlayerOneProfile.Text == this.cbPlayerTwoProfile.Text)
            {
                start = false;
                MessageBox.Show("Bitte wählen Sie unterschiedliche Spieler aus.");
            }
            else if (this.cbGames.SelectedIndex == -1)
            {
                start = false;
                MessageBox.Show("Bitte wählen Sie ein Spiel aus.");
            }

            return start;
        }
    }
}
