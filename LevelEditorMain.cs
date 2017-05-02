using projectlf6.Properties;
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
    public partial class LevelEditorMain : Form
    {
        Editor Editor;
        bool mausDown;
        public LevelEditorMain()
        {
            InitializeComponent();
            mausDown = false;
            Editor = new Editor(pbLevel.Width, pbLevel.Height);
        }

        #region Menü
        private void neuesLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void levelLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void levelSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editorBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rasterToolStripMenuItem.Checked)
                Editor.setGrid(true);
            else
                Editor.setGrid(false);
            pbLevel.Refresh();
        }

        private void mauszeigerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mauszeigerToolStripMenuItem.Checked)
                Editor.setCursor(true);
            else
                Editor.setCursor(false);
            pbLevel.Refresh();
        }
        #endregion

        #region Texture
        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {

        }

        private void btnGrass_Click(object sender, EventArgs e)
        {
            Editor.setTexture(Field.FIELD_GRASS);
            pbSelection.BackgroundImage = Resources.Grass;
        }

        private void btnDirt_Click(object sender, EventArgs e)
        {
            Editor.setTexture(Field.FIELD_DIRT);
            pbSelection.BackgroundImage = Resources.Dirt;
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            Editor.setTexture(Field.FIELD_STONE);
            pbSelection.BackgroundImage = Resources.Stone;
        }

        private void btnNoBrocken_Click(object sender, EventArgs e)
        {
            Editor.setTexture(Field.FIELD_NO_BROCKEN);
            pbSelection.BackgroundImage = Resources.No_Brocken;
        }

        private void btnCoal_Click(object sender, EventArgs e)
        {
            Editor.setTexture(Field.FIELD_COAL);
            pbSelection.BackgroundImage = Resources.Coal;
        }

        private void btnCopper_Click(object sender, EventArgs e)
        {
            Editor.setTexture(Field.FIELD_COPPER);
            pbSelection.BackgroundImage = Resources.Copper;
        }

        private void btnIron_Click(object sender, EventArgs e)
        {
            Editor.setTexture(Field.FIELD_IRON);
            pbSelection.BackgroundImage = Resources.Iron;
        }

        private void btnSilver_Click(object sender, EventArgs e)
        {
            Editor.setTexture(Field.FIELD_SILVER);
            pbSelection.BackgroundImage = Resources.Silver;
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            Editor.setTexture(Field.FIELD_GOLD);
            pbSelection.BackgroundImage = Resources.Gold;
        }

        private void btnDiamond_Click(object sender, EventArgs e)
        {
            Editor.setTexture(Field.FIELD_DIAMOND);
            pbSelection.BackgroundImage = Resources.Diamond;
        }
        #endregion
        private void pbLevel_MouseDown(object sender, MouseEventArgs e)
        {
            mausDown = true;
            Editor.putTexture(e.X, e.Y);
            pbLevel.Refresh();
        }

        private void pbLevel_MouseMove(object sender, MouseEventArgs e)
        {
            Editor.putCursor(e.X, e.Y);
            if(mausDown)
                Editor.putTexture(e.X, e.Y);
            pbLevel.Refresh();
        }

        private void pbLevel_Paint(object sender, PaintEventArgs e)
        {
            Editor.drawLevel(e.Graphics);
        }

        private void pbLevel_MouseUp(object sender, MouseEventArgs e)
        {
            mausDown = false;
        }
    }
}
