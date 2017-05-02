using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectlf6
{
    class Location
    {
        private int x;
        private int y;

        public Location()
        {
            this.x = 0;
            this.y = 0;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public void setX(int xValue)
        {
            this.x = xValue;
        }

        public void setY(int yValue)
        {
            this.y = yValue;
        }
    }
}
