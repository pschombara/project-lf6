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

		public TextureObject(Image texture, int x, int y, int w, int h)
		{
			this.texture = texture;
			this.rect = new Rectangle(x * 16, y * 16, w, h);
			this.changed = true;
			this.location = new Location(x, y);
		}

		public Image getTexture()
		{
			return texture;
		}

		public void setTexture(Image img)
		{
			this.texture = img;
			this.changed = true;
		}

		public bool Changed()
		{
			return changed;
		}

		public void setChangeState(bool changed)
		{
			this.changed = changed;
		}

		public Location getLocation()
		{
			return this.location;
		}

		public void Draw(Graphics g)
		{
			//if (Changed())
			{
				g.DrawImage(texture, rect);
				setChangeState(false);
			}
		}

		public bool Contains(Point p)
		{
			return rect.Contains(p);
		}
	}
}
