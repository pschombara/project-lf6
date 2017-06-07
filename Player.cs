using System;
using System.Drawing;
using System.IO;
using System.Xml;
using minesHunter.Properties;

namespace minesHunter
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

        public const int SKIN_STEVE = 30;
        public const int SKIN_ALEX = 40;
        public const int SKIN_HERO = 50;
        public const int SKIN_LUCINDA = 60;
        public const int SKIN_CAMO_GIRL = 70;

        /**
         * Class constructor Player
         */
        public Player()
        {
            this.name = "";
            this.skin = Field.PLAYER_STEVE;
            this.wayColor = Field.FIELD_CLEAR;
            this.score = new Score();
            this.location = new Location();
            this.orientation = ORIENTATION_DOWN;
            this.number = 0;
        }

        /**
         * Class constructor Player
         * 
         * @param string name player name
         */
        public Player(string name)
        {
            this.name = name;
            this.wayColor = Field.FIELD_CLEAR;
            this.skin = Field.PLAYER_STEVE;
            this.score = new Score();
            this.location = new Location();
            this.orientation = ORIENTATION_DOWN;
            this.number = 0;
        }

        /**
         * Set player name
         * 
         * @param string name player name
         */
        public void setName(string name)
        {
            this.name = name;
        }

        /**
         * Return player name
         * 
         * @return string
         */
        public string getName()
        {
            return this.name;
        }

        /**
         * Set player skin
         * 
         * @param int skin skin id
         */
        public void setSkin(int skin)
        {
            this.skin = skin;
        }

        /**
         * Return skin id
         * 
         * @return int
         */
        public int getSkin()
        {
            return this.skin;
        }

        /**
         * Get player skin image
         * 
         * @return Image
         */
        public Image getSkinImage()
        {
            Image img = null;
            switch (this.orientation + this.skin)
            {
                case 30:
                    img = Resources.Steve_Up;
                    break;
                case 31:
                    img = Resources.Steve_Right;
                    break;
                case 32:
                    img = Resources.Steve_Down;
                    break;
                case 33:
                    img = Resources.Steve_Left;
                    break;
                case 40:
                    img = Resources.Alex_Up;
                    break;
                case 41:
                    img = Resources.Alex_Right;
                    break;
                case 42:
                    img = Resources.Alex_Down;
                    break;
                case 43:
                    img = Resources.Alex_Left;
                    break;
                case 50:
                    img = Resources.The_Hero_Up;
                    break;
                case 51:
                    img = Resources.The_Hero_Right;
                    break;
                case 52:
                    img = Resources.The_Hero_Down;
                    break;
                case 53:
                    img = Resources.The_Hero_Left;
                    break;
                case 60:
                    img = Resources.Lucinda_Up;
                    break;
                case 61:
                    img = Resources.Lucinda_Right;
                    break;
                case 62:
                    img = Resources.Lucinda_Down;
                    break;
                case 63:
                    img = Resources.Lucinda_Left;
                    break;
                case 70:
                    img = Resources.Camo_Girl_Up;
                    break;
                case 71:
                    img = Resources.Camo_Girl_Right;
                    break;
                case 72:
                    img = Resources.Camo_Girl_Down;
                    break;
                case 73:
                    img = Resources.Camo_Girl_Left;
                    break;
            }
            return img;
        }

        /**
         * Set way color id
         * 
         * @param int newColor color id
         */
        public void setWayColor(int newColor)
        {
            this.wayColor = newColor;
        }

        /**
         * Return way color id
         * 
         * @return int
         */
        public int getWayColor()
        {
            return this.wayColor;
        }

        /**
         * Return player location
         * 
         * @return Location
         */
        public Location getLocation()
        {
            return this.location;
        }
        
        /**
         * Set player location
         * 
         * @param int x position on x axis
         * @param int y position on y axis
         */
        public void setLocation(int x, int y)
        {
            this.location = new Location(x, y);
        }

        /**
         * Set player location
         * 
         * @param Location newLoc player location to set
         */
        public void setLocation(Location newLoc)
        {
            this.location = newLoc;
        }

        /**
         * @return int
         */
        public int getNumber()
        {
            return this.number;
        }

        /**
         * Return player score
         * 
         * @return Score
         */
        public Score getScore()
        {
            return this.score;
        }

        /**
         * Set player orientation
         * 
         * @param int orientation player orientation
         */
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

        /**
         * Return player orientation
         * 
         * @return int
         */
        public int getOrientation()
        {
            return this.orientation;
        }

        /**
         * Save player to xml file
         * 
         * @return bool
         */
        public bool saveToFile()
        {
            Directory.CreateDirectory(Global.PATH_PLAYER_FOLDER);
            XmlDocument doc = new XmlDocument();

            doc.AppendChild(doc.ImportNode(this.serialize(), true));
            doc.Save(this.name.ToXmlPlayerPath());

            return true;
        }

        /**
         * Load player from xml file
         * 
         * @param string name file name
         */
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

            XmlNodeList nodeSkin = doc.GetElementsByTagName("skin");

            if (nodeSkin.Count == 1)
            {
                this.skin = Convert.ToInt16(nodeSkin.Item(0).InnerText);
            }

            XmlNodeList nodeWayColor = doc.GetElementsByTagName("wayColor");

            if (nodeWayColor.Count == 1)
            {
                this.wayColor = Convert.ToInt16(nodeWayColor.Item(0).InnerText);
            }

            XmlNodeList nodeLocation = doc.GetElementsByTagName("location");
            this.location.loadFromXml(nodeLocation);

            XmlNodeList nodeScore = doc.GetElementsByTagName("score");
        }

        /**
         * Serialie player to xml
         * 
         * @return XmlElement
         */
        public XmlElement serialize()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement player = doc.CreateElement("player");
            XmlElement name = doc.CreateElement("name");
            XmlElement orientation = doc.CreateElement("orientation");
            XmlElement skin = doc.CreateElement("skin");
            XmlElement wayColor = doc.CreateElement("wayColor");

            name.InnerText = this.name;
            orientation.InnerText = this.orientation.ToString();
            skin.InnerText = this.skin.ToString();
            wayColor.InnerText = this.wayColor.ToString();

            player.AppendChild(name);
            player.AppendChild(orientation);
            player.AppendChild(skin);
            player.AppendChild(wayColor);
            player.AppendChild(doc.ImportNode(this.location.serialize(), true));
            player.AppendChild(doc.ImportNode(this.score.serialize(), true));
            doc.AppendChild(player);

            return player;
        }
    }
}