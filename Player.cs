﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace projectlf6
{
    public class Player
    {
        private string name;
        private Skin skin;
        private Score score;
        private Location location;
        private int orientation;

        const int ORIENTATION_UP = 0;
        const int ORIENTATION_RIGHT = 1;
        const int ORIENTATION_DOWN = 2;
        const int ORIENTATION_LEFT = 3;

        const string SAVE_PATH = "\\projectlf6\\save\\";

        public Player()
        {
            this.name = "";
            this.skin = new Skin();
            this.score = new Score();
            this.location = new Location();
            this.orientation = ORIENTATION_DOWN;
        }

        public Player(string name)
        {
            this.name = name;
            this.skin = new Skin();
            this.score = new Score();
            this.location = new Location();
            this.orientation = ORIENTATION_DOWN;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setSkin(Skin skin)
        {
            this.skin = skin;
        }

        public Skin getSkin()
        {
            return this.skin;
        }

        public Location getLocation()
        {
            return this.location;
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
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + SAVE_PATH;
                Directory.CreateDirectory(path);
                string saveXml = path + "player_" + this.name + ".xml";

                XmlDocument doc = new XmlDocument();

                doc.AppendChild(doc.ImportNode(this.serialize(), true));

                doc.Save(saveXml);
            }
            catch (Exception ex)
            {

            }


            return true;
        }

        public void loadFromFile(string name)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + SAVE_PATH;

            XmlDocument doc = new XmlDocument();
            doc.Load(path + "player_" + name + ".xml");
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
