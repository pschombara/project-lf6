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

        public Player()
        {
            this.name = "";
            this.skin = new Skin();
            this.score = new Score();
            this.location = new Location();
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

    }
}
