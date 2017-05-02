using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectlf6
{
    class Field
    {
        private int fieldType;
        private string texture;
        private int points;

        const int FIELD_GRASS  = 0;
        const int FIELD_DIRT = 1;
        const int FIELD_STONE = 2;
        const int FIELD_NO_BROCKEN = 3;
        const int FIELD_COAL = 4;
        const int FIELD_COPPER = 5;
        const int FIELD_IRON = 6;
        const int FIELD_SILVER = 7;
        const int FIELD_GOLD = 8;
        const int FIELD_DIAMOND = 9;

        public Field(int fieldType)
        {
            this.fieldType = fieldType;
            this.texture = string.Empty;
            this.points = 0;
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

        private void setPoints(int points)
        {
            this.points = points;
        }

        public int getPoints()
        {
            return this.points;
        }
    }
}
