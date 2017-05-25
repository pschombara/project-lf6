using projectlf6.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectlf6
{
	public class Field
	{
		private int fieldType;
		private Bitmap texture;
		private int points;

		public const int FIELD_STONE = 0;
		public const int FIELD_SKY = 1;
		public const int FIELD_DIRT = 2;
		public const int FIELD_GRASS = 3;
		public const int FIELD_NO_BROCKEN = 4;
		public const int FIELD_COAL = 5;
		public const int FIELD_COPPER = 6;
		public const int FIELD_IRON = 7;
		public const int FIELD_SILVER = 8;
		public const int FIELD_GOLD = 9;
		public const int FIELD_DIAMOND = 10;
		public const int FIELD_Player_1 = 30;
		public const int FIELD_Player_2 = 40;
		public const int FIELD_CLEAR = 13;
		public const int WAY_BLUE = 14;
		public const int WAY_BLUE_DARK = 15;
		public const int WAY_BLUE_LIGHT = 16;
		public const int WAY_GREEN = 17;
		public const int WAY_ORANGE = 18;
		public const int WAY_PINK = 19;
		public const int WAY_PURPLE = 20;
		public const int WAY_RED = 21;
		public const int WAY_YELLOW = 22;

		public Field(int fieldType)
		{
			this.fieldType = fieldType;
			this.texture = new Bitmap(16, 16);
			this.setPoints();
		}

		public Bitmap getTexture()
		{
            switch(fieldType)
            {
                case WAY_BLUE:
                    return Resources.wayBlue;
                case WAY_BLUE_DARK:
                    return Resources.wayBlueDark;
                case WAY_BLUE_LIGHT:
                    return Resources.wayBlueLight;
                case WAY_GREEN:
                    return Resources.wayGreen;
                case WAY_ORANGE:
                    return Resources.wayOrange;
                case WAY_PINK:
                    return Resources.wayPink;
                case WAY_PURPLE:
                    return Resources.wayPurple;
                case WAY_RED:
                    return Resources.wayRed;
                case WAY_YELLOW:
                    return Resources.wayYellow;
                default:
                    return null;
            }
		}

		public int getFieldType()
		{
			return this.fieldType;
		}

		public void setFieldType(int fieldTypeConstant)
		{
			this.fieldType = fieldTypeConstant;
		}

		private void setPoints()
		{
			if (this.fieldType == FIELD_COAL)
			{
				this.points = 10;
			}
			else if (this.fieldType == FIELD_COPPER)
			{
				this.points = 20;
			}
			else if (this.fieldType == FIELD_IRON)
			{
				this.points = 40;
			}
			else if (this.fieldType == FIELD_SILVER)
			{
				this.points = 60;
			}
			else if (this.fieldType == FIELD_GOLD)
			{
				this.points = 100;
			}
			else if (this.fieldType == FIELD_DIAMOND)
			{
				this.points = 200;
			}
			else
			{
				this.points = 0;
			}
		}

		public int getPoints()
		{
			return this.points;
		}
	}
}
