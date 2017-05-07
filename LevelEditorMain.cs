using projectlf6.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectlf6
{
    public partial class LevelEditorMain : Form
    {
        Editor Editor;
        bool mausDown;

        #region Konstruktor
        public LevelEditorMain()
        {
            InitializeComponent();
            mausDown = false;
            Editor = new Editor(pnlLevel.Width, pnlLevel.Height);
            pnlLevel.Refresh();
        }
        #endregion

        #region Menü
        private void neuesLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editor.NewLevel();
            pnlLevel.Refresh();
        }

        private void levelLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Editor.loadLevelFromFile(openFileDialog1.FileName);
                pnlLevel.Refresh();
            }
        }

        private void levelSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Editor.saveLevelToFile(saveFileDialog1.FileName);
            }
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
            pnlLevel.Refresh();
        }

        private void mauszeigerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mauszeigerToolStripMenuItem.Checked)
                Editor.setCursor(true);
            else
                Editor.setCursor(false);
            pnlLevel.Refresh();
        }
        #endregion

        #region Buttons
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

        #region Maus
        private void pnlLevel_MouseDown(object sender, MouseEventArgs e)
        {
            mausDown = true;
            Editor.putTexture(pnlLevel.CreateGraphics(), e.X, e.Y);
        }

        private void pnlLevel_MouseUp(object sender, MouseEventArgs e)
        {
            mausDown = false;
        }

        private void pnlLevel_MouseMove(object sender, MouseEventArgs e)
        {
            Editor.putCursor(e.X, e.Y);
            toolStripStatusLblLocation.Text = "X: " + Editor.getCursor().X + " Y: " + Editor.getCursor().Y;
            if (mausDown)
                Editor.putTexture(pnlLevel.CreateGraphics(), e.X, e.Y);
        }

        private void pnlLevel_MouseEnter(object sender, EventArgs e)
        {
            Editor.setCursorOnMap(true);
        }

        private void pnlLevel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            Editor.setCursorOnMap(false);
        }
        #endregion

        private void pnlLevel_Paint(object sender, PaintEventArgs e)
        {
            Editor.drawLevel(e.Graphics);
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mausDown = true;
            Editor.putTexture(pnlLevel.CreateGraphics(), e.X, e.Y);
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mausDown = false;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            Editor.putCursor(e.X, e.Y);
            toolStripStatusLblLocation.Text = "X: " + Editor.getCursor().X + " Y: " + Editor.getCursor().Y;
            if (mausDown)
                Editor.putTexture(pnlLevel.CreateGraphics(), e.X, e.Y);
        }

        private void pnlTop_MouseEnter(object sender, EventArgs e)
        {
            Editor.setCursorOnMap(true);
        }

        private void pnlTop_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            Editor.setCursorOnMap(false);
        }
    }
}
