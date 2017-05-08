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
    public partial class newGame : Form
    {
        public newGame()
        {
            InitializeComponent();
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
