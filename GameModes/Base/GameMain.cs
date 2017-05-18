using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectlf6.Properties;

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

		public GameMain(Player player_1, Player player_2, Game game)
		{
			InitializeComponent();
			this.DoubleBuffered = true;
			this.dice = new Random();
			this.playerOne = player_1;
			this.playerTwo = player_2;
			this.activePlayer = (rollTheDice() % 2 == 1 ? playerOne : playerTwo);
			this.lbl_currentPlayer.Text = activePlayer.getName();
			this.game = game;
			this.playerOne.setLocation(this.game.getActiveLevel().getStartLocations()[0]);
			this.playerTwo.setLocation(this.game.getActiveLevel().getStartLocations()[1]);
			this.waysP1 = new List<Location>();
			this.waysP1.Add(new Location(playerOne.getLocation().getX(), playerOne.getLocation().getY() + 1));
			this.waysP1.Add(new Location(playerOne.getLocation().getX(), playerOne.getLocation().getY() + 2));
			this.waysP2 = new List<Location>();
			this.waysP2.Add(new Location(playerTwo.getLocation().getX(), playerTwo.getLocation().getY() + 1));
			this.waysP2.Add(new Location(playerTwo.getLocation().getX(), playerTwo.getLocation().getY() + 2));
			this.board = this.game.getActiveLevel().getMap();
			updateLabels();
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
				case Field.FIELD_Player_1:
					img = Resources.Player_1;
					break;
				case Field.FIELD_Player_2:
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
			g.DrawImage(getTexture(playerOne.getSkin()), playerOne.getLocation().getX() * 16, playerOne.getLocation().getY() * 16, 16, 32);
			g.DrawImage(getTexture(playerTwo.getSkin()), playerTwo.getLocation().getX() * 16, playerTwo.getLocation().getY() * 16, 16, 32);
		}

		#endregion draw complete board

		#region draw single textures

		public void drawSingleTexture(Graphics g, int texture, int x, int y, int width, int height)
		{
			g.DrawImage(getTexture(texture), x * 16, y * 16, width, height);
		}

		public void drawSinglePlayer(Graphics g, Player p, int newX, int newY)
		{
			g.DrawImage(getTexture(p.getSkin()), newX * 16, newY * 16, 16, 32);
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
					Graphics g = pnl_game.CreateGraphics();

					//call "delete" old textures
					repaintOldTextures(g);

					//draw new Textures
					if (diggingBeforeMove)
						drawSingleTexture(g, Field.FIELD_STONE, newLoc.getX(), newLoc.getY(), 16, 16);

					drawSingleTexture(g, activePlayer.getWayColor(), newLoc.getX(), newLoc.getY(), 16, 16);

					//draw new playerlocation
					drawSinglePlayer(g, activePlayer, newLoc.getX(), newLoc.getY() - 1);
					g.Dispose();

					updateData(newLoc.getX(), newLoc.getY(), diggingBeforeMove);
				}
			}

			if (moves == 0)
			{
				if (activePlayer == playerOne)
					activePlayer = playerTwo;
				else
					activePlayer = playerOne;
			}
		}

		private void repaintOldTextures(Graphics g)
		{
			int x = activePlayer.getLocation().getX();
			int upperY = activePlayer.getLocation().getY();
			int lowerY = activePlayer.getLocation().getY() + 1;

			drawSingleTexture(g, board[x, upperY], x, upperY, 16, 16);
			drawSingleTexture(g, board[x, lowerY], x, lowerY, 16, 16);
			drawSingleTexture(g, activePlayer.getWayColor(), x, lowerY, 16, 16);

			List<Location> locs = (activePlayer == playerOne ? waysP1 : waysP2);
			foreach (Location loc in locs)
			{
				if (loc.getX() == x && loc.getY() == upperY)
					drawSingleTexture(g, activePlayer.getWayColor(), x, upperY, 16, 16);
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
					canDigg = isDiggable(newLoc.getX(), newLoc.getY());
				if (canDigg)
					move(newLoc, canDigg);
			}
		}

		private bool isDiggable(int x, int y)
		{
			bool diggable = true;

			if (board[x, y] == Field.FIELD_NO_BROCKEN || board[x, y] == Field.FIELD_SKY)
			{
				diggable = false;
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
			return dice.Next(1, 7);
		}

		private void pnl_game_Paint(object sender, PaintEventArgs e)
		{
			drawBoard(e.Graphics);
			drawWays(e.Graphics);
			drawPlayer(e.Graphics);
		}

		private void pnl_game_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			
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

			if (moves == 0 && e.KeyCode == Keys.Space)
			{
				moves = rollTheDice();
				moves += rollTheDice();
				updateLabels();
			}
			#endregion player two
		}

		private void updateLabels()
		{
			lbl_playerone.Text = playerOne.getName();
			lbl_scoreplayerone.Text = playerOne.getScore().getScore().ToString();


			lbl_playertwo.Text = playerTwo.getName();
			lbl_scoreplayertwo.Text = playerTwo.getScore().getScore().ToString();

			lbl_currentPlayer.Text = activePlayer.getName();

			this.Text = this.game.getName() + " - " + this.game.getActiveLevel().getName() + " - Moves: " + moves;
		}
	}

	#region Outcomment

	//private Player player_1;
	//private Player player_2;
	//private Game game;
	//private Random rand;
	//private bool playerOneIsActive;
	//private bool playerOneIsBeginner;
	//private int round;
	//private List<TextureObject> backgroundList;
	//private List<TextureObject> wayList;
	//private List<TextureObject> playerList;
	//private bool backgroundListChanged;
	//private bool wayListChanged;
	//private bool playerListChanged;
	//private Keys keycode;


	//public GameMain(Player player_1, Player player_2, Game game)
	//{
	//	InitializeComponent();

	//	this.DoubleBuffered = true;
	//	this.player_1 = player_1;
	//	this.player_2 = player_2;
	//	this.game = game;
	//	this.player_1.setLocation(this.game.getActiveLevel().getStartLocations()[0]);
	//	this.player_2.setLocation(this.game.getActiveLevel().getStartLocations()[1]);
	//	this.rand = new Random();
	//	this.round = 0;
	//	this.backgroundList = new List<TextureObject>();
	//	this.wayList = new List<TextureObject>();
	//	this.playerList = new List<TextureObject>();
	//	initializeGame();

	//	//set backgroundlist
	//	for (int x = 0; x < 32; x++)
	//	{
	//		for (int y = 0; y < 32; y++)
	//		{
	//			backgroundList.Add(new TextureObject(getTexture(this.game.getActiveLevel().getFieldAtLocation(new Location(x,y)).getFieldType()), new Rectangle(x*16, y*16, 16,16)));
	//		}
	//	}
	//	backgroundListChanged = true;

	//	//set wayList
	//	for (int x = 0; x < 32; x++)
	//	{
	//		for (int y = 0; y < 32; y++)
	//		{
	//			wayList.Add(new TextureObject(getTexture(13), new Rectangle(x * 16, y * 16, 16, 16)));
	//		}
	//	}
	//	wayListChanged = true;

	//	//set playerlist
	//	playerList.Add(new TextureObject(getTexture(player_1.getSkin()),new Rectangle(this.game.getActiveLevel().getStartLocations()[0].getX() * 16, this.game.getActiveLevel().getStartLocations()[0].getY() * 16, 16, 32)));
	//	wayList[(this.player_1.getLocation().getX() * 32 ) + (this.player_1.getLocation().getY() + 1)].setTexture(getTexture(this.player_1.getWayColor()));
	//	wayList[(this.player_1.getLocation().getX() * 32) + (this.player_1.getLocation().getY() + 2)].setTexture(getTexture(this.player_1.getWayColor()));
	//	wayList[(this.player_1.getLocation().getX() * 32) + (this.player_1.getLocation().getY() + 3)].setTexture(getTexture(this.player_1.getWayColor()));
	//	playerList.Add(new TextureObject(getTexture(player_2.getSkin()), new Rectangle(this.game.getActiveLevel().getStartLocations()[1].getX() * 16, this.game.getActiveLevel().getStartLocations()[1].getY() * 16, 16, 32)));
	//	wayList[this.player_2.getLocation().getX() * 32 + this.player_2.getLocation().getY() + 1].setTexture(getTexture(this.player_2.getWayColor()));
	//	playerListChanged = true;
	//}

	//public void initializeGame()
	//{
	//	lbl_playerone.Text = player_1.getName();
	//	lbl_playertwo.Text = player_2.getName();
	//	setActivePlayer(true);
	//	updateLabels();
	//}

	//public void updateLabels()
	//{
	//	lbl_scoreplayerone.Text = player_1.getScore().getScore().ToString();
	//	lbl_scoreplayertwo.Text = player_2.getScore().getScore().ToString();
	//	lbl_currentPlayer.Text = getActivePlayer().getName();
	//	this.Text = "GameMain - Round: " + this.round;
	//}

	//public Player getActivePlayer()
	//{
	//	Player retvar = null;

	//	if (playerOneIsActive)
	//	{
	//		retvar = player_1;	
	//	}
	//	else
	//	{
	//		retvar = player_2;
	//	}

	//	return retvar;
	//}

	//public void setActivePlayer(bool isFirstSet = false)
	//{
	//	if (isFirstSet)
	//	{
	//		playerOneIsActive = rollTheDice() % 2 == 1;
	//		playerOneIsBeginner = playerOneIsActive;
	//	}
	//	else
	//	{
	//		playerOneIsActive = !playerOneIsActive;
	//	}
	//	if (playerOneIsActive == playerOneIsBeginner)
	//	{
	//		round++;
	//	}
	//}

	//public int rollTheDice()
	//{
	//	return rand.Next(1,7);
	//}

	//private void p_game_Paint(object sender, PaintEventArgs e)
	//{
	//		//if (backgroundListChanged)
	//		{
	//			foreach (TextureObject to in backgroundList)
	//			{
	//				to.Draw(e.Graphics);
	//			}

	//			backgroundListChanged = false;
	//		}

	//		//if (wayListChanged)
	//		{
	//			foreach (TextureObject to in wayList)
	//			{
	//				to.Draw(e.Graphics);
	//			}

	//			wayListChanged = false;
	//		}

	//		//if (playerListChanged)
	//		{
	//			foreach (TextureObject to in playerList)
	//			{
	//				to.Draw(e.Graphics);
	//			}

	//			playerListChanged = false;
	//		}
	//}

	//private Image getTexture(int texture)
	//{
	//	Image img = null;
	//	switch (texture)
	//	{
	//		case Field.FIELD_STONE:
	//			img = Resources.Stone;
	//			break;
	//		case Field.FIELD_SKY:
	//			img = Resources.Sky;
	//			break;
	//		case Field.FIELD_DIRT:
	//			img = Resources.Dirt;
	//			break;
	//		case Field.FIELD_GRASS:
	//			img = Resources.Grass;
	//			break;
	//		case Field.FIELD_NO_BROCKEN:
	//			img = Resources.No_Brocken;
	//			break;
	//		case Field.FIELD_COAL:
	//			img = Resources.Coal;
	//			break;
	//		case Field.FIELD_COPPER:
	//			img = Resources.Copper;
	//			break;
	//		case Field.FIELD_IRON:
	//			img = Resources.Iron;
	//			break;
	//		case Field.FIELD_SILVER:
	//			img = Resources.Silver;
	//			break;
	//		case Field.FIELD_GOLD:
	//			img = Resources.Gold;
	//			break;
	//		case Field.FIELD_DIAMOND:
	//			img = Resources.Diamond;
	//			break;
	//		case Field.FIELD_Player_1:
	//			img = Resources.Player_1;
	//			break;
	//		case Field.FIELD_Player_2:
	//			img = Resources.Player_2;
	//			break;
	//		case Field.FIELD_CLEAR:
	//			img = Resources.ClearTexture;
	//			break;
	//		case Field.FIELD_WAY_BLUE:
	//			img = Resources.wayBlue;
	//			break;
	//		case Field.FIELD_WAY_BLUE_DARK:
	//			img = Resources.wayBlueDark;
	//			break;
	//		case Field.FIELD_WAY_BLUE_LIGHT:
	//			img = Resources.wayBlueLight;
	//			break;
	//		case Field.FIELD_WAY_GREEN:
	//			img = Resources.wayGreen;
	//			break;
	//		case Field.FIELD_WAY_ORANGE:
	//			img = Resources.wayOrange;
	//			break;
	//		case Field.FIELD_WAY_PINK:
	//			img = Resources.wayPink;
	//			break;
	//		case Field.FIELD_WAY_PURPLE:
	//			img = Resources.wayPurple;
	//			break;
	//		case Field.FIELD_WAY_RED:
	//			img = Resources.wayRed;
	//			break;
	//		case Field.FIELD_WAY_YELLOW:
	//			img = Resources.wayYellow;
	//			break;
	//		default:
	//			img = null;
	//			break;
	//	}

	//	return img;
	//}

	//private void GameMain_LocationChanged(object sender, EventArgs e)
	//{
	//}

	//private void GameMain_ResizeEnd(object sender, EventArgs e)
	//{
	//	this.backgroundListChanged = true;
	//	this.wayListChanged = true;
	//	this.playerListChanged = true;

	//	foreach (TextureObject to in backgroundList)
	//	{
	//		to.setChangeState(true);
	//	}

	//	foreach (TextureObject to in wayList)
	//	{
	//		to.setChangeState(true);
	//	}

	//	foreach (TextureObject to in playerList)
	//	{
	//		to.setChangeState(true);
	//	}

	//	this.Refresh();
	//}

	//private void GameMain_KeyPress(object sender, KeyPressEventArgs e)
	//{
	//	switch (keycode)
	//	{
	//		case Keys.W:
	//		case Keys.NumPad8:
	//			moveUP();
	//			break;
	//		case Keys.A:
	//		case Keys.NumPad4:
	//			moveLEFT();
	//			break;
	//		case Keys.S:
	//		case Keys.NumPad2:
	//			moveDOWN();
	//			break;
	//		case Keys.D:
	//		case Keys.NumPad6:
	//			moveRIGHT();
	//			break;
	//		case Keys.V:
	//		case Keys.NumPad5:
	//			hitTheBlock();
	//			break;
	//	}
	//}

	//private void GameMain_KeyDown(object sender, KeyEventArgs e)
	//{
	//	this.keycode = e.KeyCode;
	//}

	//#region MoveMethods

	//private void moveUP()
	//{
	//}

	//private void moveDOWN()
	//{
	//	if (playerOneIsActive && keycode == Keys.S)
	//	{
	//		if (isWay(this.player_1.getLocation().getX(), this.player_1.getLocation().getY() + 2))
	//		{
	//			this.player_1.getLocation().setY(this.player_1.getLocation().getY() + 1);
	//			playerList[0] = new TextureObject(getTexture(player_1.getSkin()), new Rectangle(this.player_1.getLocation().getX() * 16, this.player_1.getLocation().getY() * 16, 16, 32));

	//			this.Refresh();
	//		}
	//		else
	//		{
	//			this.player_1.setOrientation(Player.ORIENTATION_DOWN);
	//		}
	//	}
	//	if (!playerOneIsActive && keycode == Keys.NumPad2)
	//	{
	//		if (isWay(this.player_2.getLocation().getX(), this.player_2.getLocation().getY() + 2))
	//		{

	//		}
	//		else
	//		{
	//			this.player_2.setOrientation(Player.ORIENTATION_DOWN);
	//		}
	//	}
	//}

	//private void moveLEFT()
	//{
	//}

	//private void moveRIGHT()
	//{
	//}

	//private void hitTheBlock()
	//{
	//}

	//private bool isWay(int x, int y)
	//{
	//	bool isway = wayList[x * 32 + y].getTexture() != getTexture(Field.FIELD_CLEAR);
	//	return isway;
	//}

	//private bool isBlockDestroyable(int x, int y)
	//{
	//	bool isDestroyable = true;
	//	if (backgroundList[x * 16 + y].getTexture() == getTexture(Field.FIELD_NO_BROCKEN) || backgroundList[x * 16 + y].getTexture() == getTexture(Field.FIELD_SKY))
	//	{
	//		isDestroyable = false;
	//	}
	//	return isDestroyable;
	//}

	//#endregion Movemethods

	#endregion Outcomment

}
