using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectlf6
{
    public class Field
    {
        private int fieldType;
        private string texture;
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
        public const int FIELD_Player_1 = 11;
        public const int FIELD_Player_2 = 12;

        public Field(int fieldType)
        {
            this.fieldType = fieldType;
            this.texture = string.Empty;
            this.setPoints();
        }

        public string getTexture()
        {
            return this.texture;
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
