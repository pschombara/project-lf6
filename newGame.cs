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
using projectlf6.Properties;

namespace projectlf6
{
    public partial class newGame : Form
    {
        private List<string> playerList;
        private List<Bitmap> figures;
        private List<int> figuresNumbers;
        private int figurePlayerOne;
        private int figurePlayerTwo;

        public newGame()
        {
            InitializeComponent();
            this.playerList = new List<string>();

            this.prepareFillComboBox();
            this.fillPlayerComboBox(this.cbPlayerOneProfile);
            this.fillPlayerComboBox(this.cbPlayerTwoProfile);
            this.fillGameComboBox();
            this.fillFigures();
            this.figurePlayerOne = 0;
            this.figurePlayerTwo = 0;
            this.drawPlayerFigure(this.pbPlayerOneFigure, this.figurePlayerOne);
            this.drawPlayerFigure(this.pbPlayerTwoFigure, this.figurePlayerTwo);
        }

        private void drawPlayerFigure(PictureBox box, int index)
        {
            box.Image = this.figures[index];
            box.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void fillFigures()
        {
            this.figures = new List<Bitmap>();
            this.figuresNumbers = new List<int>();

            this.figures.Add(Resources.Steve_Down);
            this.figures.Add(Resources.Alex_Down);

            this.figuresNumbers.Add(Player.SKIN_STEVE);
            this.figuresNumbers.Add(Player.SKIN_ALEX);
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
            Game game = new Game(cbGames.Text);
            Player playerOne;
            Player playerTwo;
            string playerOneName = this.cbPlayerOneProfile.Text;
            string playerTwoName = this.cbPlayerTwoProfile.Text;

            if (this.checkGameStart())
            {
                playerOne = new Player(playerOneName);
                playerOne.setWayColor(cbPlayerOneColor.SelectedIndex + 14);
                playerOne.setSkin(this.figuresNumbers[this.figurePlayerOne]);
                playerOne.saveToFile();
                playerTwo = new Player(playerTwoName);
                playerTwo.setWayColor(cbPlayerTwoColor.SelectedIndex + 14);
                playerTwo.setSkin(this.figuresNumbers[this.figurePlayerTwo]);
                playerTwo.saveToFile();
                game.loadFromFile();
                Form GameMain = new GameMain(playerOne, playerTwo, game);

                GameMain.ShowDialog();
            }
        }

        private void cbPlayerOneProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = new Player();
            player.loadFromFile(this.cbPlayerOneProfile.SelectedItem.ToString());

            int figure = this.figuresNumbers.FindIndex(x => x == player.getSkin());

            if (figure > -1)
            {
                this.figurePlayerOne = figure;
                this.drawPlayerFigure(this.pbPlayerOneFigure, this.figurePlayerOne);
            }

            cbPlayerOneColor.SelectedIndex = player.getWayColor() - 14;
        }

        private void cbPlayerTwoProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = new Player();
            player.loadFromFile(this.cbPlayerTwoProfile.SelectedItem.ToString());

            int figure = this.figuresNumbers.FindIndex(x => x == player.getSkin());

            if (figure > -1)
            {
                this.figurePlayerTwo = figure;
                this.drawPlayerFigure(this.pbPlayerTwoFigure, this.figurePlayerTwo);
            }

            cbPlayerTwoColor.SelectedIndex = player.getWayColor() - 14;
        }

        private void cbPlayerOneColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Field field = new Field(cbPlayerOneColor.SelectedIndex + 14);
            pbPlayerOneFigure.BackgroundImage = field.getTexture();
        }

        private void cbPlayerTwoColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Field field = new Field(cbPlayerTwoColor.SelectedIndex + 14);
            pbPlayerTwoFigure.BackgroundImage = field.getTexture();
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
            else if (this.cbPlayerOneColor.SelectedIndex == -1)
            {
                start = false;
                MessageBox.Show("Bitte wählen Sie eine Farbe für Spieler 1 aus.");
            }
            else if (this.cbPlayerTwoColor.SelectedIndex == -1)
            {
                start = false;
                MessageBox.Show("Bitte wählen Sie eine Farbe für Spieler 2 aus.");
            }
            else if (cbPlayerOneColor.SelectedIndex == cbPlayerTwoColor.SelectedIndex)
            {
                start = false;
                MessageBox.Show("Bitte wählen Sie unterschiedliche Farben aus.");
            }
            else if (this.figurePlayerOne == this.figurePlayerTwo)
            {
                start = false;
                MessageBox.Show("Bitte wählen Sie unterschiedliche Spielfiguren aus.");
            }

            return start;
        }

        private void btnPlayerOneFigureBack_Click(object sender, EventArgs e)
        {
            if (this.figurePlayerOne == 0)
            {
                this.figurePlayerOne = this.figures.Count - 1;
            }
            else
            {
                this.figurePlayerOne--;
            }

            this.drawPlayerFigure(this.pbPlayerOneFigure, this.figurePlayerOne);
        }

        private void btnPlayerOneFigureForward_Click(object sender, EventArgs e)
        {
            if (this.figurePlayerOne < this.figures.Count - 1)
            {
                this.figurePlayerOne++;
            }
            else
            {
                this.figurePlayerOne = 0;
            }

            this.drawPlayerFigure(this.pbPlayerOneFigure, this.figurePlayerOne);
        }

        private void btnPlayerTwoFigureBack_Click(object sender, EventArgs e)
        {
            if (this.figurePlayerTwo == 0)
            {
                this.figurePlayerTwo = this.figures.Count - 1;
            }
            else
            {
                this.figurePlayerTwo--;
            }

            this.drawPlayerFigure(this.pbPlayerTwoFigure, this.figurePlayerTwo);
        }

        private void btnPlayerTwoFigureForward_Click(object sender, EventArgs e)
        {
            if (this.figurePlayerTwo < this.figures.Count - 1)
            {
                this.figurePlayerTwo++;
            }
            else
            {
                this.figurePlayerTwo = 0;
            }

            this.drawPlayerFigure(this.pbPlayerTwoFigure, this.figurePlayerTwo);
        }
    }
}
