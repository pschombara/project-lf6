using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace projectlf6
{
    public class Location
    {
        private int x;
        private int y;

        public Location()
        {
            this.x = 0;
            this.y = 0;
        }

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
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

        public XmlElement serialize()
        {
            XmlDocument document = new XmlDocument();
            XmlElement location = document.CreateElement("location");
            XmlElement x = document.CreateElement("x");
            XmlElement y = document.CreateElement("y");
            x.InnerText = this.x.ToString();
            y.InnerText = this.y.ToString();
            location.AppendChild(x);
            location.AppendChild(y);

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
                        this.y = Convert.ToInt16(childs.Item(y).InnerText);
                    }
                }
            }
        }
    }
}
