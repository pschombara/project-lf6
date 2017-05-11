using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace projectlf6
{
	public class Score
    {
        private int score;
        private List<int> gameScores;

        public Score()
        {
            this.score = 0;
            this.gameScores = new List<int>();
        }

        public void setScore(int score)
        {
            this.score = score;
        }

        public int getScore()
        {
            return this.score;
        }

        public void addScoreToScoreList(int score)
        {
            this.gameScores.Add(score);
        }

        public List<int> getScoreList()
        {
            return this.gameScores;
        }

        public int getTotalscore()
        {
            int sum = 0;
            foreach (var item in gameScores)
            {
                sum += item;
            }
            return sum;
        }

        public int getMinScore()
        {
            int min = this.gameScores[0];
            for (int i = 0; i < this.gameScores.Count; i++)
            {
                if (this.gameScores[i] < min)
                    min = this.gameScores[i];
            }
            return min;
        }

        public int getMaxScore()
        {
            int max = this.gameScores[0];
            for (int i = 0; i < this.gameScores.Count; i++)
            {
                if (this.gameScores[i] > max)
                    max = this.gameScores[i];
            }
            return max;
        }

        public int incrementScore(int points)
        {
            this.score += points;
            return score;
        }

        public int decrementScore(int score)
        {
            this.score -= score;
            return score;
        }

        public XmlElement serialize()
        {
            XmlDocument document = new XmlDocument();
            XmlElement scoreClass = document.CreateElement("score");
            XmlElement score = document.CreateElement("score");
            XmlElement gameScores = document.CreateElement("gameScores");
            score.InnerText = this.score.ToString();

            scoreClass.AppendChild(score);

            for (int x = 0; x < this.gameScores.Count; x++)
            {
                XmlElement elem = document.CreateElement("element");
                elem.InnerText = this.gameScores.ElementAt(x).ToString();
                gameScores.AppendChild(elem);
            }

            scoreClass.AppendChild(gameScores);

            return scoreClass;
        }

        public void loadFromXml(XmlNodeList xml)
        {
            if (xml.Count == 1 && xml.Item(0).Name == "score")
            {
                XmlNodeList childs = xml.Item(0).ChildNodes;
                for (int x = 0; x < childs.Count; x++)
                {
                    if (childs.Item(x).Name == "score")
                    {
                        this.score = Convert.ToInt16(childs.Item(x).InnerText);
                    }
                    else if (childs.Item(x).Name == "gameScores")
                    {
                        XmlNodeList gameScores = childs.Item(x).ChildNodes;

                        for (int y = 0; y < gameScores.Count; y++)
                        {
                            this.gameScores.Add(Convert.ToInt16(gameScores.Item(y).InnerText));
                        }
                    }
                }
            }
        }
    }
}