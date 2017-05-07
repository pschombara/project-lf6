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
        private int CursorX, CursorY; //Cursor Position
        private int[,] map; //Level Daten
        private bool isGrid; //Gitter zeichnen
        private bool isCursor; //Cursor zeichnen
        private int selectedTexture; //ausgewählte Textur
        private bool CursorOnMap; //Ist Cursor auf Level

        public Editor(int x, int y)
        {
            Level = new Point(x, y);
            x = 0; y = 0;
            map = new int[32, 32];
            isGrid = false;
            isCursor = false;
            selectedTexture = Field.FIELD_GRASS;
            CursorOnMap = false;
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

        #region Mauszeiger zeichnen
        private void drawSelection(Graphics graphics, Color color, int size = 1)
        {
            SolidBrush brush = new SolidBrush(color);
            int x = (this.CursorX / 16) * 16;
            int y = (this.CursorY / 16) * 16;
            graphics.DrawImage(getTexture(selectedTexture), x, y, 16, 16);
        }
        #endregion

        #region Texturen zeichnen
        private void drawTextures(Graphics graphics)
        {
            for (int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 32; y++)
                {
                    graphics.DrawImage(getTexture(map[x, y]), (x * 16), (y * 16), 16, 16);
                }
            }
        }
        #endregion

        private Image getTexture(int texture)
        {
            switch (texture)
            {
                case Field.FIELD_STONE:
                    return Resources.Stone;
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
                default:
                    return null;
            }
        }

        public void drawLevel(Graphics graphics)
        {
            drawTextures(graphics);
            if (isGrid)
                drawGrid(graphics, Color.Black);
            if (isCursor && CursorOnMap)
                drawSelection(graphics, Color.Black);
        }

        #region Cursor
        public void putCursor(int x, int y)
        {
            this.CursorX = x;
            this.CursorY = y;
        }
        public Point getCursor()
        {
            Point point = new Point((this.CursorX / 16), (this.CursorY / 16));
            return point;
        }
        public void setCursor(bool state)
        {
            isCursor = state;
        }
        #endregion

        public void putTexture(Graphics graphics, int x, int y)
        {
            //TODO absturz, X | Y größer 32
            int MapX = x / 16;
            int MapY = y / 16;
            map[MapX, MapY] = selectedTexture;
            graphics.DrawImage(getTexture(selectedTexture), (MapX * 16), (MapY * 16), 16, 16);
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
            string[] str = datei.Split(';');
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

            for (int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 32; y++)
                {
                    datei += map[x, y].ToString() + ';';
                }
                datei += Environment.NewLine;
            }
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

        public void setCursorOnMap(bool state)
        {
            this.CursorOnMap = state;
        }

        public Cursor getCustomCursor(Point p)
        {
            return new Cursor((new Bitmap("C:/Users/meteo/Documents/Cursor.png").GetHicon()));
        }
    }
}
