using System;
using System.Linq;
using System.Xml;

namespace projectlf6
{
	public class Location
    {
        private int x;
        private int y;
        private int live;

        public Location()
        {
            Random random = new Random();
            this.x = 0;
            this.y = 0;
            this.live = random.Next(5, 10);
        }

        public Location(int x, int y)
        {
            Random random = new Random();
            this.x = x;
            this.y = y;
            this.live = random.Next(5, 10);
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public void setX(int xValue)
        {
            this.x = xValue;
        }

        public void setY(int yValue)
        {
            this.y = yValue;
        }

        public bool reduceLive()
        {
            this.live--;

            if (this.live > 0)
            {
                return true;
            }

            return false;
        }

        public XmlElement serialize()
        {
            XmlDocument document = new XmlDocument();
            XmlElement location = document.CreateElement("location");
            XmlElement x = document.CreateElement("x");
            XmlElement y = document.CreateElement("y");
            XmlElement live = document.CreateElement("live");
            x.InnerText = this.x.ToString();
            y.InnerText = this.y.ToString();
            live.InnerText = this.live.ToString();
            location.AppendChild(x);
            location.AppendChild(y);
            location.AppendChild(live);

            return location;
        }

        public void loadFromXml(XmlNodeList xml)
        {
            if (xml.Count == 1 && xml.Item(0).Name == "location")
            {
                XmlNodeList childs = xml.Item(0).ChildNodes;
                for (int x = 0; x < childs.Count; x++) {
                    if (childs.Item(x).Name == "x")
                    {
                        this.x = Convert.ToInt16(childs.Item(x).InnerText);
                    }
                    else if (childs.Item(x).Name == "y")
                    {
                        this.y = Convert.ToInt16(childs.Item(x).InnerText);
                    }
                    else if (childs.Item(x).Name == "live")
                    {
                        this.live = Convert.ToInt16(childs.Item(x).InnerText);
                    }
                }
            }
        }
    }
}