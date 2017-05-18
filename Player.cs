using System;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Xml;

namespace projectlf6
{
	public class Player
	{
		private string name;
		private int skin;
		private int wayColor;
		private Score score;
		private Location location;
		private int orientation;
		private int number;

		public const int ORIENTATION_UP = 0;
		public const int ORIENTATION_RIGHT = 1;
		public const int ORIENTATION_DOWN = 2;
		public const int ORIENTATION_LEFT = 3;

		public Player()
		{
			this.name = "";
			this.skin = Field.FIELD_Player_1;
			this.wayColor = Field.FIELD_CLEAR;
			this.score = new Score();
			this.location = new Location();
			this.orientation = ORIENTATION_DOWN;
			this.number = 0;
		}

		public Player(string name)
		{
			this.name = name;
			this.wayColor = Field.FIELD_CLEAR;
			this.skin = Field.FIELD_Player_1;
			this.score = new Score();
			this.location = new Location();
			this.orientation = ORIENTATION_DOWN;
			this.number = 0;
		}

		public void setName(string name)
		{
			this.name = name;
		}

		public string getName()
		{
			return this.name;
		}

		public void setSkin(int skin)
		{
			this.skin = skin;
		}

		public int getSkin()
		{
			return this.skin;
		}

		public void setWayColor(int newColor)
		{
			this.wayColor = newColor;
		}

		public int getWayColor()
		{
			return this.wayColor;
		}

		public Location getLocation()
		{
			return this.location;
		}

		public void setLocation(int x, int y)
		{
			Location newLoc = new Location(x, y);
			this.location = newLoc;
		}

		public void setLocation(Location newLoc)
		{
			this.location = newLoc;
		}

		public int getNumber()
		{
			return this.number;
		}

		public Score getScore()
		{
			return this.score;
		}

		public void setNumber(int number)
		{
			if (number > 2 || number < 1)
				this.number = 0;
			if (number == 1)
				this.number = 1;
			if (number == 2)
				this.number = 2;
		}

		public void setOrientation(int orientation)
		{
			if (orientation >= ORIENTATION_UP && orientation <= ORIENTATION_LEFT)
			{
				this.orientation = orientation;
			}
			else
			{
				this.orientation = ORIENTATION_DOWN;
			}
		}

		public int getOrientation()
		{
			return this.orientation;
		}

		public bool saveToFile()
		{
			try
			{
				Directory.CreateDirectory(Global.PATH_PLAYER_FOLDER);
				string saveXml = this.name.ToXmlPlayerPath();

				XmlDocument doc = new XmlDocument();

				doc.AppendChild(doc.ImportNode(this.serialize(), true));

				doc.Save(this.name.ToXmlPlayerPath());
			}
			catch (Exception ex)
			{
			}

			return true;
		}

		public void loadFromFile(string name)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(name.ToXmlPlayerPath());
			XmlNodeList nodeName = doc.GetElementsByTagName("name");

			if (nodeName.Count == 1)
			{
				this.name = nodeName.Item(0).InnerText;
			}

			XmlNodeList nodeOrientation = doc.GetElementsByTagName("orientation");

			if (nodeOrientation.Count == 1)
			{
				this.orientation = Convert.ToInt16(nodeOrientation.Item(0).InnerText);
			}

			XmlNodeList nodeLocation = doc.GetElementsByTagName("location");
			this.location.loadFromXml(nodeLocation);

			XmlNodeList nodeScore = doc.GetElementsByTagName("score");
		}

		public XmlElement serialize()
		{
			XmlDocument doc = new XmlDocument();
			XmlElement player = doc.CreateElement("player");
			XmlElement name = doc.CreateElement("name");
			XmlElement orientation = doc.CreateElement("orientation");
			name.InnerText = this.name;
			orientation.InnerText = this.orientation.ToString();
			player.AppendChild(name);
			player.AppendChild(orientation);
			player.AppendChild(doc.ImportNode(this.location.serialize(), true));
			player.AppendChild(doc.ImportNode(this.score.serialize(), true));
			doc.AppendChild(player);

			return player;
		}
	}
}