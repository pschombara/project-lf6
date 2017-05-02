using projectlf6.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectlf6
{
    class Editor
    {
        private Point Level;
        private int CursorX, CursorY;
        private int[,] map;
        private bool isGrid;
        private bool isCursor;
        private int selectedTexture;
        
        public Editor(int x, int y)
        {
            Level = new Point(x, y);
            x = 0; y = 0;
            map = new int[32, 32];
            isGrid = false;
            isCursor = false;
            selectedTexture = Field.FIELD_GRASS;
        }

        #region Gitter zeichnen
        private void drawGrid(Graphics graphics, Color color, int size = 1)
        {
            Pen pen = new Pen(color, size);
            // X-Raster
            for (int x = 0; x < Level.X; x+=16)
            {
                graphics.DrawLine(pen, x, 0, x, Level.X);
            }
            // Y-Raster
            for (int y = 0; y < Level.Y; y+=16)
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
            graphics.FillRectangle(brush, x, y, 16, 16);
        }
        #endregion

        #region Texturen zeichnen
        private void drawTextures(Graphics graphics)
        {
            for (int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 32; y++)
                {
                    switch (map[x, y])
                    {
                        case Field.FIELD_GRASS:
                            graphics.DrawImage(Resources.Grass, (x * 16), (y * 16));
                            break;
                        case Field.FIELD_DIRT:
                            graphics.DrawImage(Resources.Dirt, (x * 16), (x * 16));
                            break;
                        case Field.FIELD_STONE:
                            graphics.DrawImage(Resources.Stone, (x * 16), (y * 16));
                            break;
                        case Field.FIELD_NO_BROCKEN:
                            graphics.DrawImage(Resources.No_Brocken, (x * 16), (y * 16));
                            break;
                        case Field.FIELD_COAL:
                            graphics.DrawImage(Resources.Coal, (x * 16), (y * 16));
                            break;
                        case Field.FIELD_COPPER:
                            graphics.DrawImage(Resources.Copper, (x * 16), (y * 16));
                            break;
                        case Field.FIELD_IRON:
                            graphics.DrawImage(Resources.Iron, (x * 16), (y * 16));
                            break;
                        case Field.FIELD_SILVER:
                            graphics.DrawImage(Resources.Silver, (x * 16), (y * 16));
                            break;
                        case Field.FIELD_GOLD:
                            graphics.DrawImage(Resources.Gold, (x * 16), (y * 16));
                            break;
                        case Field.FIELD_DIAMOND:
                            graphics.DrawImage(Resources.Diamond, (x * 16), (y * 16));
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        #endregion

        public void drawLevel(Graphics graphics)
        {
            drawTextures(graphics);
            if(isGrid)
                drawGrid(graphics, Color.Black);
            if(isCursor)
                drawSelection(graphics, Color.Black);
        }

        public void putCursor(int x, int y)
        {
            this.CursorX = x;
            this.CursorY = y;
        }

        public void putTexture(int x, int y)
        {
            int MapX = x / 16;
            int MapY = y / 16;
            map[MapX, MapY] = selectedTexture;
        }

        public void setTexture(int texture)
        {
            selectedTexture = texture;
        }

        public void setCursor(bool state)
        {
            isCursor = state;
        }

        public void setGrid(bool state)
        {
            isGrid = state;
        }
    }
}
