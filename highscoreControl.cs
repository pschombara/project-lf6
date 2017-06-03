﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace projectlf6
{
    class HighscoreControl
    {
        private static string MAIN_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\projectlf6\\";
        private List<HighscoreItem> highscore;

        public HighscoreControl()
        {
            this.highscore = new List<HighscoreItem>();
            this.loadHighscore();
        }

        public void addHighscore(string player, string game, int score, int levels, int rounds)
        {
            int position = 0;

            for (int i = 0; i < this.highscore.Count; i++)
            {
                if (score < this.highscore[i].getScore())
                {
                    position++;
                }
            }

            if (position < 100)
            {
                this.highscore.Insert(position, new HighscoreItem(player, game, score, levels, rounds));
            }

            if (this.highscore.Count > 100)
            {
                this.highscore.RemoveAt(100);
            }

            this.saveHighscore();
        }

        public List<HighscoreItem> getHighscore()
        {
            return this.highscore;
        }

        public void reset()
        {
            this.highscore.Clear();
            this.saveHighscore();
        }

        private void loadHighscore()
        {
            if (File.Exists(MAIN_PATH + "highscore.xml"))
            {
                this.loadFromFile();
            }
            else
            {
                this.saveHighscore();
            }
        }

        private void saveHighscore()
        {
            XmlDocument document = new XmlDocument();
            document.AppendChild(document.ImportNode(this.serialize(), true));
            document.Save(MAIN_PATH + "highscore.xml");
        }

        private XmlElement serialize()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement highscore = doc.CreateElement("highscore");

            for (int i = 0; i < this.highscore.Count; i++)
            {
                XmlElement item = doc.CreateElement("item");
                XmlElement player = doc.CreateElement("player");
                XmlElement game = doc.CreateElement("game");
                XmlElement score = doc.CreateElement("score");
                XmlElement levels = doc.CreateElement("levels");
                XmlElement rounds = doc.CreateElement("rounds");


                player.InnerText = this.highscore.ElementAt(i).getPlayer();
                game.InnerText = this.highscore.ElementAt(i).getGame();
                score.InnerText = this.highscore.ElementAt(i).getScore().ToString();
                levels.InnerText = this.highscore.ElementAt(i).getLevels().ToString();
                rounds.InnerText = this.highscore.ElementAt(i).getRounds().ToString();


                item.AppendChild(player);
                item.AppendChild(game);
                item.AppendChild(score);
                item.AppendChild(levels);
                item.AppendChild(rounds);
                highscore.AppendChild(item);
            }

            return highscore;
        }

        private void loadFromFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MAIN_PATH + "highscore.xml");
            XmlNodeList nodeName = doc.GetElementsByTagName("highscore");

            if (nodeName.Count == 1)
            {
                XmlNodeList item = nodeName.Item(0).ChildNodes;

                for (int i = 0; i < item.Count; i++)
                {
                    if (item[i].Name == "item")
                    {
                        XmlNodeList itemChild = item[i].ChildNodes;
                        string player = "";
                        string game = "";
                        int score = 0;
                        int levels = 0;
                        int rounds = 0;

                        for (int j = 0; j < itemChild.Count; j++)
                        {
                            if (itemChild[j].Name == "player")
                            {
                                player = itemChild[j].InnerText;
                            }
                            else if (itemChild[j].Name == "game")
                            {
                                game = itemChild[j].InnerText;
                            }
                            else if (itemChild[j].Name == "score")
                            {
                                score = Convert.ToInt16(itemChild[j].InnerText);
                            }
                            else if (itemChild[j].Name == "levels")
                            {
                                levels = Convert.ToInt16(itemChild[j].InnerText);
                            }
                            else if (itemChild[j].Name == "rounds")
                            {
                                rounds = Convert.ToInt16(itemChild[j].InnerText);
                            }
                        }

                        this.highscore.Add(new HighscoreItem(player, game, score, levels, rounds));
                    }
                }
            }
        }
    }
}
