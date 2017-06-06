using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectlf6.Properties;
using System.Media;

namespace projectlf6
{
    public partial class GameMain : Form
    {
        private Player playerOne;
        private Player playerTwo;
        private Player activePlayer;
        private Game game;
        private Random dice;
        private int[,] board;
        private List<Location> waysP1;
        private List<Location> waysP2;
        private int moves;
        private Bitmap visualBoard;
        private Player firstPlayer;
        private int finishCounter;
        private int rounds;
        private bool isNotNewLevel;
        private bool finish;

        public GameMain(Player player_1, Player player_2, Game game, int rounds)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.dice = new Random();
            this.playerOne = player_1;
            this.playerTwo = player_2;
            this.activePlayer = (rollTheDice() % 2 == 1 ? playerOne : playerTwo);
            this.firstPlayer = activePlayer;
            this.game = game;
            this.rounds = rounds;
            this.finish = false;
            startNewLevel();
        }

        private Image getTexture(int texture)
        {
            Image img = null;
            switch (texture)
            {
                case Field.FIELD_STONE:
                    img = Resources.Stone;
                    break;
                case Field.FIELD_SKY:
                    img = Resources.Sky;
                    break;
                case Field.FIELD_DIRT:
                    img = Resources.Dirt;
                    break;
                case Field.FIELD_GRASS:
                    img = Resources.Grass;
                    break;
                case Field.FIELD_NO_BROCKEN:
                    img = Resources.No_Brocken;
                    break;
                case Field.FIELD_COAL:
                    img = Resources.Coal;
                    break;
                case Field.FIELD_COPPER:
                    img = Resources.Copper;
                    break;
                case Field.FIELD_IRON:
                    img = Resources.Iron;
                    break;
                case Field.FIELD_SILVER:
                    img = Resources.Silver;
                    break;
                case Field.FIELD_GOLD:
                    img = Resources.Gold;
                    break;
                case Field.FIELD_DIAMOND:
                    img = Resources.Diamond;
                    break;
                case Field.PLAYER_STEVE:
                case 11:
                    img = Resources.Player_1;
                    break;
                case Field.PLAYER_ALEX:
                case 12:
                    img = Resources.Player_2;
                    break;
                case Field.FIELD_CLEAR:
                    img = Resources.ClearTexture;
                    break;
                case Field.WAY_BLUE:
                    img = Resources.wayBlue;
                    break;
                case Field.WAY_BLUE_DARK:
                    img = Resources.wayBlueDark;
                    break;
                case Field.WAY_BLUE_LIGHT:
                    img = Resources.wayBlueLight;
                    break;
                case Field.WAY_GREEN:
                    img = Resources.wayGreen;
                    break;
                case Field.WAY_ORANGE:
                    img = Resources.wayOrange;
                    break;
                case Field.WAY_PINK:
                    img = Resources.wayPink;
                    break;
                case Field.WAY_PURPLE:
                    img = Resources.wayPurple;
                    break;
                case Field.WAY_RED:
                    img = Resources.wayRed;
                    break;
                case Field.WAY_YELLOW:
                    img = Resources.wayYellow;
                    break;
                default:
                    img = null;
                    break;
            }

            return img;
        }

        #region draw complete texture sets

        private void drawBoard(Graphics g)
        {
            for (int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 32; y++)
                {
                    g.DrawImage(getTexture(board[x, y]), (x * 16), (y * 16), 16, 16);
                }
            }
        }

        private void drawWays(Graphics g)
        {
            foreach (Location loc in waysP1)
            {
                g.DrawImage(getTexture(playerOne.getWayColor()), loc.getX() * 16, loc.getY() * 16, 16, 16);
            }

            foreach (Location loc in waysP2)
            {
                g.DrawImage(getTexture(playerTwo.getWayColor()), loc.getX() * 16, loc.getY() * 16, 16, 16);
            }
        }

        private void drawPlayer(Graphics g)
        {
            g.DrawImage(playerOne.getSkinImage(), playerOne.getLocation().getX() * 16, playerOne.getLocation().getY() * 16, 16, 32);
            g.DrawImage(playerTwo.getSkinImage(), playerTwo.getLocation().getX() * 16, playerTwo.getLocation().getY() * 16, 16, 32);
        }

        #endregion draw complete board

        #region draw single textures

        public void drawSingleTexture(Graphics g, int texture, int x, int y, int width, int height)
        {
            g.DrawImage(getTexture(texture), x * 16, y * 16, width, height);
        }

        public void drawSinglePlayer(Graphics g, Player p, int newX, int newY)
        {
            g.DrawImage(p.getSkinImage(), newX * 16, newY * 16, 16, 32);
        }

        #endregion draw singles textures

        private void move(Location newLoc, bool diggingBeforeMove = false)
        {
            if (newLoc != null)
            {
                bool canMove = false;

                if (!diggingBeforeMove)
                {
                    List<Location> locs = (activePlayer == playerOne ? waysP1 : waysP2);
                    foreach (Location loc in locs)
                    {
                        if (loc.getX() == newLoc.getX() && loc.getY() == newLoc.getY())
                            canMove = true;
                    }
                }

                if (canMove || diggingBeforeMove)
                {
                    int newField = this.board[newLoc.getX(), newLoc.getY()];
                    updateData(newLoc.getX(), newLoc.getY(), diggingBeforeMove);

                    if (canMove && !diggingBeforeMove)
                    {
                        this.playSound(ResourceSound.step);
                    }
                    else if (newField == Field.FIELD_GRASS)
                    {
                        this.playSound(ResourceSound.grass);
                    }
                    else if (newField == Field.FIELD_DIRT)
                    {
                        this.playSound(ResourceSound.dirt);
                    }
                    else if (newField >= Field.FIELD_COAL && newField <= Field.FIELD_DIAMOND)
                    {
                        this.playSound(ResourceSound.successful_hit);
                    }
                    else
                    {
                        this.playSound(ResourceSound.dig);
                    }

                }

                Graphics g = Graphics.FromImage(visualBoard);

                drawBoard(g);
                drawWays(g);
                drawPlayer(g);
                g.Dispose();
            }

            if (moves == 0)
            {
                if (activePlayer == playerOne)
                {
                    activePlayer = playerTwo;
                    pbxPlayerTwoSkin.BackgroundImage = getTexture(playerTwo.getWayColor());
                    pbxPlayerOneSkin.BackgroundImage = getTexture(Field.FIELD_CLEAR);
                    this.lblPlayerTwoActive.Visible = true;
                    this.lblPlayerOneActive.Visible = false;
                }
                else
                {
                    activePlayer = playerOne;
                    pbxPlayerTwoSkin.BackgroundImage = getTexture(Field.FIELD_CLEAR);
                    pbxPlayerOneSkin.BackgroundImage = getTexture(playerOne.getWayColor());
                    this.lblPlayerTwoActive.Visible = false;
                    this.lblPlayerOneActive.Visible = true;
                }
            }

            pbBoard.Refresh();
        }

        private void playSound(System.IO.UnmanagedMemoryStream play)
        {
            if (this.menueSound.Checked)
            {
                SoundPlayer sound = new SoundPlayer(play);
                sound.Play();
                sound.Dispose();
            }
        }

        private void digIt()
        {
            bool canDigg = true;
            Location newLoc = getNewLocation(activePlayer.getLocation(), activePlayer.getOrientation());

            if (newLoc != null)
            {
                List<Location> locs = (activePlayer == playerOne ? waysP1 : waysP2);
                foreach (Location loc in locs)
                {
                    if (loc.getX() == newLoc.getX() && loc.getY() == newLoc.getY())
                    {
                        canDigg = false;
                        continue;
                    }
                }

                if (canDigg)
                {
                    canDigg = isDiggable(newLoc.getX(), newLoc.getY());
                }

                if (canDigg)
                {
                    activePlayer.getScore().setScore(activePlayer.getScore().getScore() + this.game.getActiveLevel().getFieldAtLocation(newLoc).getPoints());
                    move(newLoc, canDigg);
                }
            }
        }

        private bool isDiggable(int x, int y)
        {
            bool diggable = true;

            if (board[x, y] == Field.FIELD_NO_BROCKEN || board[x, y] == Field.FIELD_SKY)
            {
                diggable = false;
            }
            else
            {
                Location newLoc = getNewLocation(activePlayer.getLocation(), activePlayer.getOrientation());
                List<Location> locs = (activePlayer == playerTwo ? waysP1 : waysP2);
                foreach (Location loc in locs)
                {
                    if (loc.getX() == newLoc.getX() && loc.getY() == newLoc.getY())
                    {
                        diggable = false;
                        continue;
                    }
                }
            }

            return diggable;
        }

        private void updateData(int x, int y, bool digging)
        {
            activePlayer.setLocation(x, y - 1);

            bool newWay = true;
            List<Location> locs = (activePlayer == playerOne ? waysP1 : waysP2);
            foreach (Location loc in locs)
            {
                if (loc.getX() == x && loc.getY() == y)
                    newWay = false;
            }

            if (newWay)
                locs.Add(new Location(x, y));

            if (digging)
            {
                board[x, y] = Field.FIELD_STONE;
                this.moves--;
                setMovesImage();
            }

            updateLabels();
        }

        private Location getNewLocation(Location oldLocation, int orientation)
        {
            Location newLoc = null;

            switch (orientation)
            {
                case Player.ORIENTATION_DOWN:
                    newLoc = new Location(oldLocation.getX(), oldLocation.getY() + 2);
                    break;
                case Player.ORIENTATION_LEFT:
                    newLoc = new Location(oldLocation.getX() - 1, oldLocation.getY() + 1);
                    break;
                case Player.ORIENTATION_RIGHT:
                    newLoc = new Location(oldLocation.getX() + 1, oldLocation.getY() + 1);
                    break;
                case Player.ORIENTATION_UP:
                    newLoc = new Location(oldLocation.getX(), oldLocation.getY());
                    break;
            }

            if (newLoc.getX() < 0 || newLoc.getX() > 31 || newLoc.getY() < 0 || newLoc.getY() > 31)
            {
                newLoc = null;
            }

            return newLoc;
        }

        private int rollTheDice()
        {
            return dice.Next(1, 13);
        }

        private void GameMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (moves > 0)
            {
                #region player one
                if (activePlayer == playerOne)
                {
                    if (e.KeyCode == Keys.W)
                    {
                        playerOne.setOrientation(Player.ORIENTATION_UP);
                        move(getNewLocation(activePlayer.getLocation(), Player.ORIENTATION_UP));
                    }
                    else if (e.KeyCode == Keys.A)
                    {
                        playerOne.setOrientation(Player.ORIENTATION_LEFT);
                        move(getNewLocation(activePlayer.getLocation(), Player.ORIENTATION_LEFT));
                    }
                    else if (e.KeyCode == Keys.S)
                    {
                        playerOne.setOrientation(Player.ORIENTATION_DOWN);
                        move(getNewLocation(activePlayer.getLocation(), Player.ORIENTATION_DOWN));
                    }
                    else if (e.KeyCode == Keys.D)
                    {
                        playerOne.setOrientation(Player.ORIENTATION_RIGHT);
                        move(getNewLocation(activePlayer.getLocation(), Player.ORIENTATION_RIGHT));
                    }
                    else if (e.KeyCode == Keys.V)
                    {
                        digIt();
                    }
                }
                #endregion player one

                #region player two
                else
                {
                    if (e.KeyCode == Keys.NumPad8)
                    {
                        playerTwo.setOrientation(Player.ORIENTATION_UP);
                        move(getNewLocation(activePlayer.getLocation(), Player.ORIENTATION_UP));
                    }
                    else if (e.KeyCode == Keys.NumPad4)
                    {
                        playerTwo.setOrientation(Player.ORIENTATION_LEFT);
                        move(getNewLocation(activePlayer.getLocation(), Player.ORIENTATION_LEFT));
                    }
                    else if (e.KeyCode == Keys.NumPad2)
                    {
                        playerTwo.setOrientation(Player.ORIENTATION_DOWN);
                        move(getNewLocation(activePlayer.getLocation(), Player.ORIENTATION_DOWN));
                    }
                    else if (e.KeyCode == Keys.NumPad6)
                    {
                        playerTwo.setOrientation(Player.ORIENTATION_RIGHT);
                        move(getNewLocation(activePlayer.getLocation(), Player.ORIENTATION_RIGHT));
                    }
                    else if (e.KeyCode == Keys.NumPad5)
                    {
                        digIt();
                    }
                }
            }
            #endregion player two

            if (moves == 0)
            {
                this.lblRollTheDice.Visible = true;

                if (activePlayer == playerOne)
                {
                    this.updateRollTheDiceText(playerOne);
                }
                else
                {
                    this.updateRollTheDiceText(playerTwo);
                }
            }

            if (moves == 0 && e.KeyCode == Keys.Space)
            {
                isNotNewLevel = true;

                if (activePlayer == firstPlayer)
                {
                    if (finishCounter == 0)
                    {
                        playerOne.getScore().addScoreToScoreList(playerOne.getScore().getScore());
                        playerTwo.getScore().addScoreToScoreList(playerTwo.getScore().getScore());
                        ScoreView scoreView = new ScoreView(playerOne, playerTwo, game, this.rounds);
                        scoreView.ShowDialog();
                        if (game.hasNext())
                        {
                            this.game.changeActiveLevel();
                            startNewLevel();
                            isNotNewLevel = false;
                        }
                        else
                        {
                            this.finish = true;
                            this.Close();
                        }
                    }
                    else
                    {
                        finishCounter--;
                    }
                }
                if (isNotNewLevel && !this.finish)
                {
                    this.collapseWay();
                    this.lblRollTheDice.Visible = false;
                    pbxMoves.Top = this.Height;
                    moves = rollTheDice();
                    slotMachineAnimation();
                    pbxMoves.Top = this.Height - 110;
                }
            }
            updateLabels();

            if (e.KeyCode == Keys.F1)
            {
                Form Help = new Help();
                Help.ShowDialog();
            }
        }

        private void updateRollTheDiceText(Player player)
        {
            this.lblRollTheDice.Text = player.getName() + " ist dran ... Mit Leertaste würfeln";
        }

        private void slotMachineAnimation()
        {
            pbxMoves.Enabled = false;

            int lower = rollTheDice();
            Thread.Sleep(10);
            int middle = rollTheDice();
            Thread.Sleep(10);
            int upper = rollTheDice();

            pbxLower.Image = getSlotImage(lower);
            pbxMidd.Image = getSlotImage(middle);
            pbxUpper.Image = getSlotImage(upper);

            moveSlotMachine(pbxLower, pbxMidd, pbxUpper, this.Height);

            for (int i = 0; i < 5; i++)
            {
                middle = rollTheDice();
                Thread.Sleep(10);
                upper = rollTheDice();

                pbxLower.Image = pbxUpper.Image;
                pbxMidd.Image = getSlotImage(middle);
                pbxUpper.Image = getSlotImage(upper);

                moveSlotMachine(pbxLower, pbxMidd, pbxUpper, this.Height);
            }

            pbxLower.Image = pbxUpper.Image;
            pbxMidd.Image = getSlotImage(middle);
            pbxUpper.Image = getSlotImage(moves);

            moveSlotMachine(pbxLower, pbxMidd, pbxUpper, this.Height);

            pbxMoves.Image = pbxUpper.Image;
            pbxMoves.Enabled = true;
            pbxMoves.Refresh();

        }

        private void moveSlotMachine(PictureBox pbxLower, PictureBox pbxMidd, PictureBox pbxUpper, int height)
        {
            pbxLower.Top = height - 110;
            pbxMidd.Top = height - 170;
            pbxUpper.Top = height - 230;

            for (int i = 0; i < 120; i += 2)
            {
                pbxLower.Top += 2;
                pbxMidd.Top += 2;
                pbxUpper.Top += 2;
                pbxLower.Refresh();
                pbxMidd.Refresh();
                pbxUpper.Refresh();
            }
        }

        private void setMovesImage()
        {
            Image img = null;

            switch (moves)
            {
                case 12:
                    img = Resources.pick12;
                    break;
                case 11:
                    img = Resources.pick11;
                    break;
                case 10:
                    img = Resources.pick10;
                    break;
                case 9:
                    img = Resources.pick09;
                    break;
                case 8:
                    img = Resources.pick08;
                    break;
                case 7:
                    img = Resources.pick07;
                    break;
                case 6:
                    img = Resources.pick06;
                    break;
                case 5:
                    img = Resources.pick05;
                    break;
                case 4:
                    img = Resources.pick04;
                    break;
                case 3:
                    img = Resources.pick03;
                    break;
                case 2:
                    img = Resources.pick02;
                    break;
                case 1:
                    img = Resources.pick01;
                    break;
                case 0:
                    img = Resources.ClearTexture;
                    break;
            }

            pbxMoves.Image = img;
            //pbxMoves.Top = this.Height - 170;
            pbxMoves.Refresh();
        }

        private Image getSlotImage(int moves)
        {
            Image img = null;

            switch (moves)
            {
                case 12:
                    img = Resources.pick12;
                    break;
                case 11:
                    img = Resources.pick11;
                    break;
                case 10:
                    img = Resources.pick10;
                    break;
                case 9:
                    img = Resources.pick09;
                    break;
                case 8:
                    img = Resources.pick08;
                    break;
                case 7:
                    img = Resources.pick07;
                    break;
                case 6:
                    img = Resources.pick06;
                    break;
                case 5:
                    img = Resources.pick05;
                    break;
                case 4:
                    img = Resources.pick04;
                    break;
                case 3:
                    img = Resources.pick03;
                    break;
                case 2:
                    img = Resources.pick02;
                    break;
                case 1:
                    img = Resources.pick01;
                    break;
                case 0:
                    img = Resources.ClearTexture;
                    break;
            }

            //pbxMoves.Image = img;
            //pbxMoves.Top = this.Height - 170;
            return img;
        }

        private void updateLabels()
        {
            lbl_playerone.Text = playerOne.getName();
            lbl_scoreplayerone.Text = playerOne.getScore().getScore().ToString();

            lbl_playertwo.Text = playerTwo.getName();
            lbl_scoreplayertwo.Text = playerTwo.getScore().getScore().ToString();

            this.Text = this.game.getName() + " - " + this.game.getActiveLevel().getName() + " - verbleibende Züge: " + moves + " - verbleibende Runden: " + finishCounter;
        }

        private void startNewLevel()
        {
            //set finish counter to round start value
            this.finishCounter = this.rounds;

            //reset player one for new game
            this.playerOne.setLocation(this.game.getActiveLevel().getStartLocations()[0]);
            this.playerOne.getScore().setScore(0);
            this.playerOne.setOrientation(Player.ORIENTATION_DOWN);
            this.waysP1 = new List<Location>();
            this.waysP1.Add(new Location(playerOne.getLocation().getX(), playerOne.getLocation().getY() + 1));
            pbxPlayerOneSkin.BackgroundImage = getTexture(playerOne.getWayColor());
            pbxPlayerOneSkin.Image = playerOne.getSkinImage();

            //reset player two for new game
            this.playerTwo.setLocation(this.game.getActiveLevel().getStartLocations()[1]);
            this.playerTwo.getScore().setScore(0);
            this.playerTwo.setOrientation(Player.ORIENTATION_DOWN);
            this.waysP2 = new List<Location>();
            this.waysP2.Add(new Location(playerTwo.getLocation().getX(), playerTwo.getLocation().getY() + 1));
            pbxPlayerTwoSkin.BackgroundImage = getTexture(playerTwo.getWayColor());
            pbxPlayerTwoSkin.Image = playerTwo.getSkinImage();

            //set and draw new level
            this.board = this.game.getActiveLevel().getMap();
            this.visualBoard = new Bitmap(512, 512);
            Graphics g = Graphics.FromImage(visualBoard);
            drawBoard(g);
            drawWays(g);
            drawPlayer(g);
            pbBoard.Image = visualBoard;
            pbBoard.Refresh();

            //reset labels
            updateLabels();

            //set first- and activeplayer
            if (firstPlayer == playerOne)
            {
                firstPlayer = playerTwo;
                activePlayer = playerTwo;
                pbxPlayerTwoSkin.BackgroundImage = getTexture(playerTwo.getWayColor());
                pbxPlayerOneSkin.BackgroundImage = getTexture(Field.FIELD_CLEAR);
                this.lblPlayerTwoActive.Visible = true;
                this.lblPlayerOneActive.Visible = false;
            }
            else
            {
                firstPlayer = playerOne;
                activePlayer = playerOne;
                pbxPlayerTwoSkin.BackgroundImage = getTexture(Field.FIELD_CLEAR);
                pbxPlayerOneSkin.BackgroundImage = getTexture(playerOne.getWayColor());
                this.lblPlayerTwoActive.Visible = false;
                this.lblPlayerOneActive.Visible = true;
            }

            this.updateRollTheDiceText(this.activePlayer);
        }

        private void collapseWay()
        {
            if (activePlayer == this.playerOne)
            {
                for (int i = this.waysP1.Count - 1; i > 0; i--)
                {
                    if (!this.waysP1[i].reduceLive())
                    {
                        board[this.waysP1[i].getX(), this.waysP1[i].getY()] = Field.FIELD_DIRT;
                        this.waysP1.RemoveAt(i);
                        Refresh();
                    }

                }
            }
            else if (activePlayer == this.playerTwo)
            {
                for (int i = this.waysP2.Count - 1; i > 0; i--)
                {
                    if (!this.waysP2[i].reduceLive())
                    {
                        board[this.waysP2[i].getX(), this.waysP2[i].getY()] = Field.FIELD_DIRT;
                        this.waysP2.RemoveAt(i);
                        Refresh();
                    }

                }
            }
        }

        private void spielBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.finish)
            {
                DialogResult result = MessageBox.Show("Wollen Sie das Spiel wirklich beenden?", "Spiel beenden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

