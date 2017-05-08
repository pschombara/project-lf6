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
    class Editor
    {
        private Point Level; //Größe des Levels
        private int[,] map; //Level Daten
        private bool isGrid; //Gitter zeichnen
        private int selectedTexture; //ausgewählte Textur
        private Location player_1, player_2; //Spieler Koordinaten

        public Editor(int x, int y)
        {
            Level = new Point(x, y);
            x = 0; y = 0;
            map = new int[32, 32];
            isGrid = false;
            selectedTexture = Field.FIELD_GRASS;
            player_1 = new Location();
            player_2 = new Location();
        }

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
                    if (selectedTexture == Field.FIELD_Player_1 || selectedTexture == Field.FIELD_Player_2)
                    {
                        //graphics.DrawImage(getTexture(map[x, y]), (x * 16), (y * 16), 15, 32);
                        graphics.DrawImage(getTexture(map[x, y]), (x * 16), (y * 16), 16, 16);
                    }
                    else
                        graphics.DrawImage(getTexture(map[x, y]), (x * 16), (y * 16), 16, 16);
                }
            }
            graphics.DrawImage(getTexture(Field.FIELD_Player_1), (player_1.getX() * 16), (player_1.getY() * 16), 15, 32); //Zeichne Player 1
            graphics.DrawImage(getTexture(Field.FIELD_Player_2), (player_2.getX() * 16), (player_2.getY() * 16), 15, 32); //Zeichne Player 2
        }
        #endregion

        public static string getBetween(string strSource, string strStart, string strEnd)
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
                case Field.FIELD_Player_1:
                    return Resources.Player_1;
                case Field.FIELD_Player_2:
                    return Resources.Player_2;
                default:
                    return null;
            }
        }

        public void drawLevel(Graphics graphics)
        {
            drawTextures(graphics);
            if (isGrid)
                drawGrid(graphics, Color.Black);
        }

        public void putTexture(Graphics graphics, int x, int y)
        {
            int MapX = x / 16;
            int MapY = y / 16;
            if (MapX >= 0 && MapX <= 31 && MapY >= 0 && MapY <= 31)
            {
                if (selectedTexture == Field.FIELD_Player_1)
                {
                    player_1.setX(MapX);
                    player_1.setY(MapY);
                    drawLevel(graphics);
                }
                else if (selectedTexture == Field.FIELD_Player_2)
                {
                    player_2.setX(MapX);
                    player_2.setY(MapY);
                    drawLevel(graphics);
                }
                else
                {
                    map[MapX, MapY] = selectedTexture;
                    graphics.DrawImage(getTexture(selectedTexture), (MapX * 16), (MapY * 16), 16, 16);
                }
            }
            if (isGrid)
                drawGrid(graphics, Color.Black);
        }

        public void setTexture(int texture)
        {
            selectedTexture = texture;
        }

        public void setGrid(bool state)
        {
            isGrid = state;
        }

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

        public void NewLevel()
        {
            for (int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 32; y++)
                {
                    map[x, y] = Field.FIELD_STONE;
                }
            }
        }

        public Cursor getCustomCursor()
        {
            Bitmap b;
            if (selectedTexture == Field.FIELD_Player_1 || selectedTexture == Field.FIELD_Player_2)
                b = new Bitmap(getTexture(selectedTexture), 15, 32);
            else
                b = new Bitmap(getTexture(selectedTexture), 16, 16);
            IntPtr ptr = b.GetHicon();
            return new Cursor(ptr);
        }
    }
}
