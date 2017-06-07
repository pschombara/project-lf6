using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesHunter
{
	public class TextureObject
	{
		private Image texture;
		private bool changed = true;
		private Rectangle rect;
		private Location location;

        /**
         * Class constructor TextureObject
         * 
         * @param Image texture texture
         * @param int   x       position on x axis
         * @param int   y       position on y axis
         * @param int   w       with for rectangle
         * @param int   h       height for rectangle
         */
		public TextureObject(Image texture, int x, int y, int w, int h)
		{
			this.texture = texture;
			this.rect = new Rectangle(x * 16, y * 16, w, h);
			this.changed = true;
			this.location = new Location(x, y);
		}

        /**
         * Return the texture
         * 
         * @return Image
         */
		public Image getTexture()
		{
			return texture;
		}

        /**
         * Set texture
         * 
         * @param Image img image to set for texture
         */
		public void setTexture(Image img)
		{
			this.texture = img;
			this.changed = true;
		}

        /**
         * Return if the state changed
         * 
         * @return bool
         */
		public bool Changed()
		{
			return changed;
		}

        /**
         * Set if state of change
         * 
         * @param bool changed state has changed or not
         */
		public void setChangeState(bool changed)
		{
			this.changed = changed;
		}

        /**
         * Return the location
         * 
         * @return Location
         */
		public Location getLocation()
		{
			return this.location;
		}

        /**
         * Draw on graphic
         * 
         * @param Graphics g graphic context
         */
		public void Draw(Graphics g)
		{
			g.DrawImage(texture, rect);
			setChangeState(false);
		}

        /**
         * Check if rect contains point
         * 
         * @params Point p point to check
         * 
         * @return bool
         */
		public bool Contains(Point p)
		{
			return rect.Contains(p);
		}
	}
}
