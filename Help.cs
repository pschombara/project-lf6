using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesHunter
{
    public partial class Help : Form
    {
        /**
         * Class constructor Help
         */
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


        #region Draw_KeyDescription_Player1
        private void pB_W_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 12))
            {
                e.Graphics.DrawString("W", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void pB_A_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 12))
            {
                e.Graphics.DrawString("A", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void pB_S_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 12))
            {
                e.Graphics.DrawString("S", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void pB_D_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 12))
            {
                e.Graphics.DrawString("D", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void pB_V_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 12))
            {
                e.Graphics.DrawString("V", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void pB_Space_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 12))
            {
                e.Graphics.DrawString("Leertaste", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        #endregion


        #region Draw_KeyDescription_Player2
        private void pB_8_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 12))
            {
                e.Graphics.DrawString("8", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void pB_4_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 12))
            {
                e.Graphics.DrawString("4", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void pB_5_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 12))
            {
                e.Graphics.DrawString("5", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void pB_6_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 12))
            {
                e.Graphics.DrawString("6", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void pB_2_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 12))
            {
                e.Graphics.DrawString("2", myFont, Brushes.Black, new Point(2, 2));
            }
        }
        #endregion

        /**
         * Event handler key down
         * 
         * @param object       sender sender
         * @param KeyEventArgs e      key event arguments
         */
        private void Help_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            switch(key)
            {
                case Keys.W:
                    pB_W.BorderStyle = BorderStyle.Fixed3D;
                    pB_W.BackColor = Color.LightGreen;
                    lbl_description.Text = "Nach oben bewegen";
                    break;

                case Keys.A:
                    pB_A.BorderStyle = BorderStyle.Fixed3D;
                    pB_A.BackColor = Color.LightGreen;
                    lbl_description.Text = "Nach links bewegen";
                    break;

                case Keys.S:
                    pB_S.BorderStyle = BorderStyle.Fixed3D;
                    pB_S.BackColor = Color.LightGreen;
                    lbl_description.Text = "Nach unten bewegen";
                    break;

                case Keys.D:
                    pB_D.BorderStyle = BorderStyle.Fixed3D;
                    pB_D.BackColor = Color.LightGreen;
                    lbl_description.Text = "Nach rechts bewegen";
                    break;

                case Keys.V:
                    pB_V.BorderStyle = BorderStyle.Fixed3D;
                    pB_V.BackColor = Color.LightGreen;
                    lbl_description.Text = "Block in Blickrichtung abbauen/zerstören";
                    break;

                case Keys.Space:
                    pB_Space.BorderStyle = BorderStyle.Fixed3D;
                    pB_Space.BackColor = Color.LightGreen;
                    lbl_description.Text = "Würfeln";
                    break;

                case Keys.NumPad8:
                    pB_8.BorderStyle = BorderStyle.Fixed3D;
                    pB_8.BackColor = Color.LightGreen;
                    lbl_description.Text = "Nach oben bewegen";
                    break;

                case Keys.NumPad4:
                    pB_4.BorderStyle = BorderStyle.Fixed3D;
                    pB_4.BackColor = Color.LightGreen;
                    lbl_description.Text = "Nach links bewegen";
                    break;

                case Keys.NumPad5:
                    pB_5.BorderStyle = BorderStyle.Fixed3D;
                    pB_5.BackColor = Color.LightGreen;
                    lbl_description.Text = "Block in Blickrichtung abbauen/zerstören";
                    break;

                case Keys.NumPad6:
                    pB_6.BorderStyle = BorderStyle.Fixed3D;
                    pB_6.BackColor = Color.LightGreen;
                    lbl_description.Text = "Nach rechts bewegen";
                    break;

                case Keys.NumPad2:
                    pB_2.BorderStyle = BorderStyle.Fixed3D;
                    pB_2.BackColor = Color.LightGreen;
                    lbl_description.Text = "Nach unten bewegen";
                    break;
            }
        }

        /**
         * Event handler key up
         * 
         * @param object       sender sender
         * @param KeyEventArgs e      key event arguments
         */
        private void Help_KeyUp(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            switch (key)
            {
                case Keys.W:
                    pB_W.BorderStyle = BorderStyle.FixedSingle;
                    pB_W.BackColor = DefaultBackColor;
                    lbl_description.Text = "bitte drücken sie eine Taste...";
                    break;

                case Keys.A:
                    pB_A.BorderStyle = BorderStyle.FixedSingle;
                    pB_A.BackColor = DefaultBackColor;
                    lbl_description.Text = "bitte drücken sie eine Taste...";
                    break;

                case Keys.S:
                    pB_S.BorderStyle = BorderStyle.FixedSingle;
                    pB_S.BackColor = DefaultBackColor;
                    lbl_description.Text = "bitte drücken sie eine Taste...";
                    break;

                case Keys.D:
                    pB_D.BorderStyle = BorderStyle.FixedSingle;
                    pB_D.BackColor = DefaultBackColor;
                    lbl_description.Text = "bitte drücken sie eine Taste...";
                    break;

                case Keys.V:
                    pB_V.BorderStyle = BorderStyle.FixedSingle;
                    pB_V.BackColor = DefaultBackColor;
                    lbl_description.Text = "bitte drücken sie eine Taste...";
                    break;

                case Keys.Space:
                    pB_Space.BorderStyle = BorderStyle.FixedSingle;
                    pB_Space.BackColor = DefaultBackColor;
                    lbl_description.Text = "bitte drücken sie eine Taste...";
                    break;

                case Keys.NumPad8:
                    pB_8.BorderStyle = BorderStyle.FixedSingle;
                    pB_8.BackColor = DefaultBackColor;
                    lbl_description.Text = "bitte drücken sie eine Taste...";
                    break;

                case Keys.NumPad4:
                    pB_4.BorderStyle = BorderStyle.FixedSingle;
                    pB_4.BackColor = DefaultBackColor;
                    lbl_description.Text = "bitte drücken sie eine Taste...";
                    break;

                case Keys.NumPad5:
                    pB_5.BorderStyle = BorderStyle.FixedSingle;
                    pB_5.BackColor = DefaultBackColor;
                    lbl_description.Text = "bitte drücken sie eine Taste...";
                    break;

                case Keys.NumPad6:
                    pB_6.BorderStyle = BorderStyle.FixedSingle;
                    pB_6.BackColor = DefaultBackColor;
                    lbl_description.Text = "bitte drücken sie eine Taste...";
                    break;

                case Keys.NumPad2:
                    pB_2.BorderStyle = BorderStyle.FixedSingle;
                    pB_2.BackColor = DefaultBackColor;
                    lbl_description.Text = "bitte drücken sie eine Taste...";
                    break;
            }
        }

        private void btn_anleitung_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\Anleitung\\Spielanleitung.pdf");
        }
    }
}
