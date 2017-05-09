using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectlf6
{
    class Skin
    {
        private string texture;
        private Color color;
        private bool used;

        public Skin()
        {
            //
        }
        public Skin(string texture, Color color)
        {
            this.texture = texture;
            this.color = color;
        }

        public Color getColor()
        {
            return this.color;
        }

        public string getTexture()
        {
            return this.texture;
        }

        public void setTexture(string texture)
        {
            this.texture = texture;
        }

        public void setColor(Color color)
        {
            this.color = color;
        }

        public bool isUsed()
        {
            return this.used;
        }

        public void setUsed(bool isUsed)
        {
            this.used = isUsed;
        }
    }
}
