using projectlf6.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace projectlf6
{
    public class Editor
    {
        private Point Level; //Größe des Levels
        private int[,] map; //Level Daten
        private bool isGrid; //Gitter zeichnen
        private int selectedTexture; //ausgewählte Textur
        private Location player_1, player_2; //Spieler Koordinaten
        private List<FileInfo> lstLevels; //enthält alle Levels eines Spiels
        private string gameName; //enthält Spielname
        private string gamePath; //enthält Spielpfad

        #region Konstruktor
        public Editor(int x, int y)
        {
            Level = new Point(x, y);
            x = 0; y = 0;
            map = new int[32, 32];
            NewLevel();
            isGrid = false;
            selectedTexture = Field.FIELD_GRASS;
            lstLevels = new List<FileInfo>();
            gameName = string.Empty;
            gamePath = string.Empty;
        }
        #endregion

        #region Gitter zeichnen
        private void drawGrid(Graphics graphics, Color color, int size = 1)
        {
            Pen pen = new Pen(color, size);
            // X-Raster
            for (int x = 0; x < Level.X; x += 16)
            {
                graphics.DrawLine(pen, x, 0, x, Level.X);
            }
            // Y-Raster
            for (int y = 0; y < Level.Y; y += 16)
            {
                graphics.DrawLine(pen, 0, y, Level.Y, y);
            }
        }
        #endregion

        #region Texturen zeichnen
        private void drawTextures(Graphics graphics)
        {
            for (int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 32; y++)
                {
                    if (selectedTexture == Field.PLAYER_STEVE || selectedTexture == Field.PLAYER_ALEX)
                    {
                        graphics.DrawImage(getTexture(map[x, y]), (x * 16), (y * 16), 16, 16);
                    }
                    else
                        graphics.DrawImage(getTexture(map[x, y]), (x * 16), (y * 16), 16, 16);
                }
            }
            drawPlayer(graphics);
        }
        #endregion

        #region Spieler zeichnen
        private void drawPlayer(Graphics graphics)
        {
            graphics.DrawImage(getTexture(Field.PLAYER_STEVE), (player_1.getX() * 16), (player_1.getY() * 16), 16, 32); //Zeichne Player 1
            graphics.DrawImage(getTexture(Field.PLAYER_ALEX), (player_2.getX() * 16), (player_2.getY() * 16), 16, 32); //Zeichne Player 2
        }
        #endregion

        #region Level zeichnen
        public void drawLevel(Graphics graphics)
        {
            drawTextures(graphics);
            if (isGrid)
                drawGrid(graphics, Color.Black);
        }
        #endregion

        #region Zeichne Texture an Position
        public void putTexture(Graphics graphics, int x, int y)
        {
            int MapX = x / 16;
            int MapY = y / 16;
            if (MapX >= 0 && MapX <= 31 && MapY >= 0 && MapY <= 31)
            {
                if (selectedTexture == Field.PLAYER_STEVE)
                {
                    if (map[MapX, MapY] == Field.FIELD_SKY && map[MapX, MapY + 1] == Field.FIELD_SKY && map[MapX, MapY + 2] != Field.FIELD_SKY)
                    {
                        if (Math.Abs(MapX - player_2.getX()) >= 4)
                        {
                            player_1.setX(MapX);
                            player_1.setY(MapY);
                            drawLevel(graphics);
                        }
                        else
                            MessageBox.Show("Spieler 1 muss mindestens 4 Blöcke Abstand zu Spieler 2 haben!", "Fehler: Spieler 1");
                    }
                    else
                        MessageBox.Show("Spieler 1 kann nicht an Position gesetzt werden!", "Fehler: Spieler 1");
                }
                else if (selectedTexture == Field.PLAYER_ALEX)
                {
                    if (map[MapX, MapY] == Field.FIELD_SKY && map[MapX, MapY + 1] == Field.FIELD_SKY && map[MapX, MapY + 2] != Field.FIELD_SKY)
                    {
                        if (Math.Abs(MapX - player_1.getX()) >= 4)
                        {
                            player_2.setX(MapX);
                            player_2.setY(MapY);
                            drawLevel(graphics);
                        }
                        else
                            MessageBox.Show("Spieler 2 muss mindestens 4 Blöcke Abstand zu Spieler 1 haben!", "Fehler: Spieler 2");
                    }
                    else
                        MessageBox.Show("Spieler 2 kann nicht an Position gesetzt werden!", "Fehler: Spieler 2");

                }
                else
                {
                    if (!checkMouseOverPlayer(MapX, MapY))
                    {
                        map[MapX, MapY] = selectedTexture;
                        graphics.DrawImage(getTexture(selectedTexture), (MapX * 16), (MapY * 16), 16, 16);
                    }
                }
            }
            if (isGrid)
                drawGrid(graphics, Color.Black);
            /*if (checkMouseOverPlayer(MapX, MapY))
                drawPlayer(graphics);*/
        }
        #endregion

        private static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }

        private Image getTexture(int texture)
        {
            switch (texture)
            {
                case Field.FIELD_STONE:
                    return Resources.Stone;
                case Field.FIELD_SKY:
                    return Resources.Sky;
                case Field.FIELD_DIRT:
                    return Resources.Dirt;
                case Field.FIELD_GRASS:
                    return Resources.Grass;
                case Field.FIELD_NO_BROCKEN:
                    return Resources.No_Brocken;
                case Field.FIELD_COAL:
                    return Resources.Coal;
                case Field.FIELD_COPPER:
                    return Resources.Copper;
                case Field.FIELD_IRON:
                    return Resources.Iron;
                case Field.FIELD_SILVER:
                    return Resources.Silver;
                case Field.FIELD_GOLD:
                    return Resources.Gold;
                case Field.FIELD_DIAMOND:
                    return Resources.Diamond;
                case Field.PLAYER_STEVE:
                    return Resources.Player_1;
                case Field.PLAYER_ALEX:
                    return Resources.Player_2;
                default:
                    return null;
            }
        }

        private bool checkMouseOverPlayer(int mapX, int mapY)
        {
            if (mapX == player_1.getX() && mapY == player_1.getY() || mapX == player_2.getX() && mapY == player_2.getY() || mapX == player_1.getX() && mapY == player_1.getY() + 1 || mapX == player_2.getX() && mapY == player_2.getY() + 1)
                return true;
            else
                return false;
        }

        #region set
        public void setTexture(int texture)
        {
            selectedTexture = texture;
        }

        public void setGrid(bool state)
        {
            isGrid = state;
        }
        #endregion

        #region Game Methoden
        public void loadGameFromDirectory(string path)
        {
            this.gameName = new FileInfo(path).Name;
            this.gamePath = path;

            refreshLevels();
        }

        public List<FileInfo> getLevels()
        {
            refreshLevels();
            return lstLevels;
        }

        public void removeLevel(int levelIndex)
        {
            if (levelIndex >= 0)
            {
                File.Delete(lstLevels[levelIndex].FullName);
                lstLevels.RemoveAt(levelIndex);
                refreshLevels();
            }
            else
                MessageBox.Show("Zuerst Level auswählen", "Fehler: Kein Level ausgewählt");
        }

        public void refreshLevels()
        {
            lstLevels.Clear();
            string[] files = Directory.GetFiles(this.gamePath);
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo fileInfo = new FileInfo(files[i]);
                lstLevels.Add(fileInfo);
            }
            if (files.Length != 0)
                loadLevelFromFile(files[0]);
        }

        public string getGameName()
        {
            return this.gameName;
        }

        public void addLevelToGame(string levelName)
        {
            if (levelName != string.Empty)
                saveLevelToFile(this.gamePath + "\\" + levelName + ".lvl");
            else
                MessageBox.Show("Levelname darf nicht leer sein!", "Fehler: Levelname");
        }
        #endregion

        #region loadLevel
        public void loadLevelFromFile(String file)
        {
            String datei = File.ReadAllText(file);
            player_1.setX(Convert.ToInt16(getBetween(datei, "Player_1_X=", "\n")));
            player_1.setY(Convert.ToInt16(getBetween(datei, "Player_1_Y=", "\n")));
            player_2.setX(Convert.ToInt16(getBetween(datei, "Player_2_X=", "\n")));
            player_2.setY(Convert.ToInt16(getBetween(datei, "Player_2_Y=", "\n")));

            datei = getBetween(datei, "<Map>", "</Map>");
            string[] str = datei.Split(';');
            //Level
            for (int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 32; y++)
                {
                    map[x, y] = Convert.ToInt16(str[(32 * x) + y]);
                }
            }
        }

        public void loadLevelFromFile(int levelIndex)
        {
            String datei = File.ReadAllText(lstLevels[levelIndex].FullName);
            player_1.setX(Convert.ToInt16(getBetween(datei, "Player_1_X=", "\n")));
            player_1.setY(Convert.ToInt16(getBetween(datei, "Player_1_Y=", "\n")));
            player_2.setX(Convert.ToInt16(getBetween(datei, "Player_2_X=", "\n")));
            player_2.setY(Convert.ToInt16(getBetween(datei, "Player_2_Y=", "\n")));

            datei = getBetween(datei, "<Map>", "</Map>");
            string[] str = datei.Split(';');
            //Level
            for (int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 32; y++)
                {
                    map[x, y] = Convert.ToInt16(str[(32 * x) + y]);
                }
            }
        }
        #endregion

        #region saveLevel
        public void saveLevelToFile(String file)
        {
            String datei = String.Empty;
            datei += "Player_1_X=" + player_1.getX() + Environment.NewLine;
            datei += "Player_1_Y=" + player_1.getY() + Environment.NewLine;
            datei += "Player_2_X=" + player_2.getX() + Environment.NewLine;
            datei += "Player_2_Y=" + player_2.getY() + Environment.NewLine;
            //Level
            datei += "<Map>" + Environment.NewLine;
            for (int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 32; y++)
                {
                    datei += map[x, y].ToString() + ';';
                }
                datei += Environment.NewLine;
            }
            datei += "</Map>";
            File.WriteAllText(file, datei);
        }

        public void saveLevelToFile(int levelIndex)
        {
            if (levelIndex >= 0)
            {
                String datei = String.Empty;
                datei += "Player_1_X=" + player_1.getX() + Environment.NewLine;
                datei += "Player_1_Y=" + player_1.getY() + Environment.NewLine;
                datei += "Player_2_X=" + player_2.getX() + Environment.NewLine;
                datei += "Player_2_Y=" + player_2.getY() + Environment.NewLine;
                //Level
                datei += "<Map>" + Environment.NewLine;
                for (int x = 0; x < 32; x++)
                {
                    for (int y = 0; y < 32; y++)
                    {
                        datei += map[x, y].ToString() + ';';
                    }
                    datei += Environment.NewLine;
                }
                datei += "</Map>";
                File.WriteAllText(lstLevels[levelIndex].FullName, datei);
            }
            else
                MessageBox.Show("Levelname darf nicht leer sein!", "Fehler: Levelname");
        }
        #endregion

        public void NewLevel()
        {
            //Himmel zeichnen
            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < 32; x++)
                {
                    map[x, y] = Field.FIELD_SKY;
                }
            }
            //Gras zeichnen
            for (int x = 0; x < 32; x++)
            {
                map[x, 2] = Field.FIELD_GRASS;
            }
            //Erde zeichnen
            for (int y = 3; y < 6; y++)
            {
                for (int x = 0; x < 32; x++)
                {
                    map[x, y] = Field.FIELD_DIRT;
                }
            }
            //Steine zeichnen
            for (int y = 6; y < 30; y++)
            {
                for (int x = 0; x < 32; x++)
                {
                    map[x, y] = Field.FIELD_STONE;
                }
            }
            //Nicht-abbaubar zeichnen
            for (int x = 0; x < 32; x++)
            {
                map[x, 31] = Field.FIELD_NO_BROCKEN;
            }
            //Spieler
            player_1 = new Location(6, 0);
            player_2 = new Location(25, 0);
        }

        public Cursor getCustomCursor()
        {
            Bitmap b;
            if (selectedTexture == Field.PLAYER_STEVE || selectedTexture == Field.PLAYER_ALEX)
            {
                if (this.isGrid)
                    b = new Bitmap(getTexture(selectedTexture), 15, 31);
                else
                    b = new Bitmap(getTexture(selectedTexture), 16, 32);
            }
            else
            {
                if (this.isGrid)
                    b = new Bitmap(getTexture(selectedTexture), 15, 15);
                else
                    b = new Bitmap(getTexture(selectedTexture), 16, 16);
            }
            IntPtr ptr = b.GetHicon();
            b.Dispose();
            return new Cursor(ptr);
        }

        #region Erze zufällig verteilen
        public void randomOres(int cntCoal, int cntCopper, int cntIron, int cntSilver, int cntGold, int cntDiamond)
        {
            Random rnd = new Random();
            //Kohle
            for (int i = 0; i < cntCoal; i++)
            {
                map[rnd.Next(32), rnd.Next(6, 11)] = Field.FIELD_COAL;
            }
            //Kupfer
            for (int i = 0; i < cntCopper; i++)
            {
                map[rnd.Next(32), rnd.Next(11, 16)] = Field.FIELD_COPPER;
            }
            //Eisen
            for (int i = 0; i < cntIron; i++)
            {
                map[rnd.Next(32), rnd.Next(16, 20)] = Field.FIELD_IRON;
            }
            //Silber
            for (int i = 0; i < cntSilver; i++)
            {
                map[rnd.Next(32), rnd.Next(20, 24)] = Field.FIELD_SILVER;
            }
            //Gold
            for (int i = 0; i < cntGold; i++)
            {
                map[rnd.Next(32), rnd.Next(24, 28)] = Field.FIELD_GOLD;
            }
            //Diamant
            for (int i = 0; i < cntDiamond; i++)
            {
                map[rnd.Next(32), rnd.Next(28, 31)] = Field.FIELD_DIAMOND;
            }
        }
        #endregion
    }
}
