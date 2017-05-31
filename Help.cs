using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectlf6
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        #region Steuerung_Spieler1
        private void pB_W_MouseHover(object sender, EventArgs e)
        {
            ToolTip up = new ToolTip();
            up.SetToolTip(this.pB_W, "Spieler bewegt sich nach oben");
        }

        private void pB_A_MouseHover(object sender, EventArgs e)
        {
            ToolTip left = new ToolTip();
            left.SetToolTip(this.pB_A, "Spieler bewegt sich nach links");
        }

        private void pB_S_MouseHover(object sender, EventArgs e)
        {
            ToolTip down = new ToolTip();
            down.SetToolTip(this.pB_S, "Spieler bewegt sich nach unten");
        }

        private void pB_D_MouseHover(object sender, EventArgs e)
        {
            ToolTip right = new ToolTip();
            right.SetToolTip(this.pB_D, "Spieler bewegt sich nach rechts");
        }

        private void pB_V_MouseHover(object sender, EventArgs e)
        {
            ToolTip breakblock = new ToolTip();
            breakblock.SetToolTip(this.pB_V, "Spieler baut den Block in seine Blickrichtung ab");
        }
        #endregion


        #region Steuerung_Spieler2
        private void pB_8_MouseHover(object sender, EventArgs e)
        {
            ToolTip up = new ToolTip();
            up.SetToolTip(this.pB_8, "Spieler bewegt sich nach oben");
        }

        private void pB_4_MouseHover(object sender, EventArgs e)
        {
            ToolTip left = new ToolTip();
            left.SetToolTip(this.pB_4, "Spieler bewegt sich nach links");
        }

        private void pB_5_MouseHover(object sender, EventArgs e)
        {
            ToolTip breakblock = new ToolTip();
            breakblock.SetToolTip(this.pB_5, "Spieler baut den Block in seine Blickrichtung ab");
        }

        private void pB_6_MouseHover(object sender, EventArgs e)
        {
            ToolTip right = new ToolTip();
            right.SetToolTip(this.pB_6, "Spieler bewegt sich nach rechts");
        }

        private void pB_2_MouseHover(object sender, EventArgs e)
        {
            ToolTip down = new ToolTip();
            down.SetToolTip(this.pB_2, "Spieler bewegt sich nach unten");
        }
        #endregion
    }
}
