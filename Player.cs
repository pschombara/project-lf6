using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectlf6
{
    class Player
    {
        private string name;
        private Skin skin;
        private Score score;
        private Location location;
        private int orientation;

        const int ORIENTATION_UP = 0;
        const int ORIENTATION_RIGHT = 1;
        const int ORIENTATION_DOWN = 2;
        const int ORIENTATION_LEFT = 3;

        public Player()
        {
            this.name = "";
            this.skin = new Skin();
            this.score = new Score();
            this.location = new Location();
            this.orientation = ORIENTATION_DOWN;
        }

        public Player(string name)
        {
            this.name = name;
            this.skin = new Skin();
            this.score = new Score();
            this.location = new Location();
            this.orientation = ORIENTATION_DOWN;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setSkin(Skin skin)
        {
            this.skin = skin;
        }

        public Skin getSkin()
        {
            return this.skin;
        }

        public void setLocation(int xValue, int yValue)
        {
            //TODO set Location
        }

        public Location getLocation()
        {
            return this.location;
        }

        public void setOrientation(int orientation)
        {
            if (orientation >= ORIENTATION_UP && orientation <= ORIENTATION_LEFT) {
                this.orientation = orientation;
            } else {
                this.orientation = ORIENTATION_DOWN;
            }
        }

        public int getOrientation()
        {
            return this.orientation;
        }

        public bool saveToFile()
        {
            // TODO save to file
            return true;
        }

        public void loadFromFile()
        {
            //TODO load from file
        }
    }
}
