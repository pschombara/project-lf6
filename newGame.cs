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
        }

        private void prepareFillComboBox()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Player.SAVE_PATH;
            FileInfo[] files = new DirectoryInfo(path).GetFiles();

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
            int playerOneIndex = this.cbPlayerOneProfile.SelectedIndex;
            int playerTwoIndex = this.cbPlayerTwoProfile.SelectedIndex;

            if (playerOneName == playerTwoName)
            {
                MessageBox.Show("Bitte wählen Sie unterschiedliche Spieler aus.");
            }

            try
            {
                if (playerOneIndex == -1)
                {
                    playerOne = new Player(playerOneName);
                }
                else
                {
                    playerOne = new Player();
                    playerOne.loadFromFile(playerOneName);
                }

                if (playerTwoIndex == -1)
                {
                    playerTwo = new Player(playerTwoName);
                    playerTwo.saveToFile();
                }
                else
                {
                    playerTwo = new Player();
                    playerTwo.loadFromFile(playerTwoName);
                }

                Form GameMain = new GameMain();
                GameMain.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Fehler beim laden eines Spielers");
            }
            
        }

        private void cbPlayerOneProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = new Player();
            player.loadFromFile(this.cbPlayerOneProfile.SelectedItem.ToString());
        }
    }
}
