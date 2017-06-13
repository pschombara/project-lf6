using minesHunter.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace minesHunter
{
    public partial class LevelEditorMain : Form
    {
        Editor Editor;
        double lastValue; //CPU-Value
        bool saved; // Level gespeichert
        int lastLevelIndex; //letztes Level

        #region Konstruktor
        public LevelEditorMain()
        {
            InitializeComponent();
            Editor = new Editor(pnlLevel.Width, pnlLevel.Height);
            setSaved(true);
            pnlLevel.Refresh();
            grbGameManager.Visible = false; //GameManager ausblenden
            lastLevelIndex = 0;
        }

        public LevelEditorMain(string path)
        {
            InitializeComponent();

            Editor = new Editor(pnlLevel.Width, pnlLevel.Height);
            setSaved(true);
            if (path.Contains("\\"))
                Editor.loadGameFromDirectory(path);
            else
                Editor.loadGameFromDirectory(Global.PATH_GAME_FOLDER + path);
            edtGameName.Text = Editor.getGameName();
            levelToComboBox(true);
            if (comboBoxLevel.Items.Count > 0)
                comboBoxLevel.SelectedIndex = 0;
            pnlLevel.Refresh();
            lastLevelIndex = 0;
        }
        #endregion

        #region Menü
        private void neuesLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                Editor.NewLevel();
                pnlLevel.Refresh();
                setSaved(false);
            }
            else
            {
                if (MessageBox.Show("Möchten Sie ohne zu speichern fortfahren?", "Level nicht gespeichert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Editor.NewLevel();
                    pnlLevel.Refresh();
                    setSaved(false);
                }
            }
        }

        private void levelLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Editor.loadLevelFromFile(openFileDialog1.FileName);
                    pnlLevel.Refresh();
                    setSaved(false);
                }
            }
            else
            {
                if (MessageBox.Show("Möchten Sie ohne zu speichern fortfahren?", "Level nicht gespeichert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        Editor.loadLevelFromFile(openFileDialog1.FileName);
                        pnlLevel.Refresh();
                        setSaved(false);
                    }
                }
            }
        }

        private void levelSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Editor.saveLevelToFile(saveFileDialog1.FileName);
                    setSaved(true);
                }
            }
            else
            {
                if (MessageBox.Show("Möchten Sie ohne zu speichern fortfahren?", "Level nicht gespeichert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        Editor.saveLevelToFile(saveFileDialog1.FileName);
                        setSaved(true);
                    }
                }
            }
        }

        private void levelExportierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                getLevelAsBitmap().Save(saveFileDialogExport.FileName, ImageFormat.Bmp);
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
            if (mauszeigerToolStripMenuItem.Checked && pnlLevel.ClientRectangle.Contains(pnlLevel.PointToClient(Cursor.Position)))
                this.Cursor = Editor.getCustomCursor();
            else
                this.Cursor = Cursors.Arrow;
        }

        private void beschriftungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (beschriftungToolStripMenuItem.Checked)
                pbScale.Visible = true;
            else
                pbScale.Visible = false;
        }
        #endregion

        #region Texture Buttons
        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            pbSelection.Size = new Size(31, 64);
            Editor.setTexture(Field.PLAYER_STEVE);
            pbSelection.BackgroundImage = Resources.Player_1;
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            pbSelection.Size = new Size(31, 64);
            Editor.setTexture(Field.PLAYER_ALEX);
            pbSelection.BackgroundImage = Resources.Player_2;
        }

        private void btnGrass_Click(object sender, EventArgs e)
        {
            pbSelection.Size = new Size(50, 50);
            Editor.setTexture(Field.FIELD_GRASS);
            pbSelection.BackgroundImage = Resources.Grass;
        }

        private void btnDirt_Click(object sender, EventArgs e)
        {
            pbSelection.Size = new Size(50, 50);
            Editor.setTexture(Field.FIELD_DIRT);
            pbSelection.BackgroundImage = Resources.Dirt;
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            pbSelection.Size = new Size(50, 50);
            Editor.setTexture(Field.FIELD_STONE);
            pbSelection.BackgroundImage = Resources.Stone;
        }

        private void btnNoBrocken_Click(object sender, EventArgs e)
        {
            pbSelection.Size = new Size(50, 50);
            Editor.setTexture(Field.FIELD_NO_BROCKEN);
            pbSelection.BackgroundImage = Resources.No_Brocken;
        }

        private void btnSky_Click(object sender, EventArgs e)
        {
            pbSelection.Size = new Size(50, 50);
            Editor.setTexture(Field.FIELD_SKY);
            pbSelection.BackgroundImage = Resources.Sky;
        }

        private void btnCoal_Click(object sender, EventArgs e)
        {
            pbSelection.Size = new Size(50, 50);
            Editor.setTexture(Field.FIELD_COAL);
            pbSelection.BackgroundImage = Resources.Coal;
        }

        private void btnCopper_Click(object sender, EventArgs e)
        {
            pbSelection.Size = new Size(50, 50);
            Editor.setTexture(Field.FIELD_COPPER);
            pbSelection.BackgroundImage = Resources.Copper;
        }

        private void btnIron_Click(object sender, EventArgs e)
        {
            pbSelection.Size = new Size(50, 50);
            Editor.setTexture(Field.FIELD_IRON);
            pbSelection.BackgroundImage = Resources.Iron;
        }

        private void btnSilver_Click(object sender, EventArgs e)
        {
            pbSelection.Size = new Size(50, 50);
            Editor.setTexture(Field.FIELD_SILVER);
            pbSelection.BackgroundImage = Resources.Silver;
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            pbSelection.Size = new Size(50, 50);
            Editor.setTexture(Field.FIELD_GOLD);
            pbSelection.BackgroundImage = Resources.Gold;
        }

        private void btnDiamond_Click(object sender, EventArgs e)
        {
            pbSelection.Size = new Size(50, 50);
            Editor.setTexture(Field.FIELD_DIAMOND);
            pbSelection.BackgroundImage = Resources.Diamond;
        }
        #endregion

        #region Maus
        private void pnlLevel_MouseDown(object sender, MouseEventArgs e)
        {
            Editor.putTexture(pnlLevel.CreateGraphics(), e.X, e.Y);
            setSaved(false);
            RefreshAnalytics();
        }

        private void pnlLevel_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLblLocation.Text = "X: " + Convert.ToInt16(e.X / 16 + 1) + " Y: " + Convert.ToInt16(e.Y / 16 + 1);
            if (e.Button == MouseButtons.Left)
            {
                Editor.putTexture(pnlLevel.CreateGraphics(), e.X, e.Y);
                setSaved(false);
            }

            RefreshAnalytics();
        }

        private void pnlLevel_MouseEnter(object sender, EventArgs e)
        {
            if (mauszeigerToolStripMenuItem.Checked)
            {
                this.Cursor = Editor.getCustomCursor();
            }
        }

        private void pnlLevel_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLblLocation.Text = "X: --" + " Y: --";
            this.Cursor = Cursors.Arrow;
        }
        #endregion

        private void pnlLevel_Paint(object sender, PaintEventArgs e)
        {
            Editor.drawLevel(e.Graphics);

            RefreshAnalytics();
        }

        private Bitmap getLevelAsBitmap()
        {
            Bitmap bitmap = new Bitmap(pnlLevel.Width, pnlLevel.Height);
            pnlLevel.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            return bitmap;
        }

        private void levelToComboBox(bool selectNew = false)
        {
            comboBoxLevel.Items.Clear();
            List<FileInfo> levels = Editor.getLevels();
            for (int i = 0; i < levels.Count; i++)
            {
                comboBoxLevel.Items.Add(levels[i].Name.Replace(levels[i].Extension, string.Empty));
            }
            if (comboBoxLevel.Items.Count > 0 && selectNew)
                comboBoxLevel.SelectedIndex = 0;
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            //RAM
            Process currentProc = Process.GetCurrentProcess();
            long memoryUsed = currentProc.PrivateMemorySize64;
            //Console.WriteLine(System.Environment.WorkingSet);
            toolStripStatusLblRAM.Text = "RAM: " + Math.Round(memoryUsed / Math.Pow(1024, 2)) + " MB";

            //CPU
            AppDomain.MonitoringIsEnabled = true;
            double differenz = (double)AppDomain.CurrentDomain.MonitoringTotalProcessorTime.TotalMilliseconds - lastValue;
            double percentage = ((differenz / timerUpdate.Interval) * 100) / Environment.ProcessorCount;
            lastValue = (double)AppDomain.CurrentDomain.MonitoringTotalProcessorTime.TotalMilliseconds;
            toolStripStatusLblCPU.Text = "CPU: " + Math.Round(percentage) + "%";
        }

        private void setSaved(bool state)
        {
            saved = state;
            btnSaveLevel.Enabled = !saved;
            levelSpeichernToolStripMenuItem.Enabled = !saved;
        }

        #region Spiel Werkzeuge
        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (saved)
            {
                Editor.loadLevelFromFile(comboBoxLevel.SelectedIndex);
                pnlLevel.Refresh();
            }
            else
            {
                if (MessageBox.Show("Möchten Sie ohne zu speichern fortfahren?", "Level nicht gespeichert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Editor.loadLevelFromFile(comboBoxLevel.SelectedIndex);
                    pnlLevel.Refresh();
                    setSaved(true);
                    lastLevelIndex = comboBoxLevel.SelectedIndex;
                }
                else
                {
                    comboBoxLevel.SelectedIndexChanged -= comboBoxLevel_SelectedIndexChanged;
                    comboBoxLevel.SelectedIndex = lastLevelIndex;
                    comboBoxLevel.SelectedIndexChanged += comboBoxLevel_SelectedIndexChanged;
                }
            }
        }

        private void comboBoxLevel_TextUpdate(object sender, EventArgs e)
        {
            btnAddLevel.Enabled = true;
        }

        private void btnAddLevel_Click(object sender, EventArgs e)
        {
            btnAddLevel.Enabled = false;
            Editor.addLevelToGame(comboBoxLevel.Text);
            levelToComboBox();
            comboBoxLevel.SelectedItem = comboBoxLevel.Text;
            setSaved(true);
        }

        private void btnRemoveLevel_Click(object sender, EventArgs e)
        {
            Editor.removeLevel(comboBoxLevel.SelectedIndex);
            levelToComboBox(true);
        }

        private void btnSaveLevel_Click(object sender, EventArgs e)
        {
            Editor.saveLevelToFile(comboBoxLevel.SelectedIndex);
            setSaved(true);
        }
        #endregion

        private void LevelEditorMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                if (MessageBox.Show("Möchten Sie ohne zu speichern fortfahren?", "Level nicht gespeichert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void btnRandomOres_Click(object sender, EventArgs e)
        {
            int[] coal = new int[3];
            int[] copper = new int[3];
            int[] iron = new int[3];
            int[] silver = new int[3];
            int[] gold = new int[3];
            int[] diamond = new int[3];

            coal[0] = (int)numCoalMin.Value;
            coal[1] = (int)numCoalMax.Value;
            coal[2] = (int)numCoalCnt.Value;

            copper[0] = (int)numCopperMin.Value;
            copper[1] = (int)numCopperMax.Value;
            copper[2] = (int)numCopperCnt.Value;

            iron[0] = (int)numIronMin.Value;
            iron[1] = (int)numIronMax.Value;
            iron[2] = (int)numIronCnt.Value;

            silver[0] = (int)numSilverMin.Value;
            silver[1] = (int)numSilverMax.Value;
            silver[2] = (int)numSilverCnt.Value;

            gold[0] = (int)numGoldMin.Value;
            gold[1] = (int)numGoldMax.Value;
            gold[2] = (int)numGoldCnt.Value;

            diamond[0] = (int)numDiamondMin.Value;
            diamond[1] = (int)numDiamondMax.Value;
            diamond[2] = (int)numDiamondCnt.Value;

            Editor.randomOres(coal, copper, iron, silver, gold, diamond);
            pnlLevel.Refresh();
            setSaved(false);
        }

        private void LevelEditorMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Form Help = new Help();
                Help.ShowDialog();
            }
        }

        private void btnResetOres_Click(object sender, EventArgs e)
        {
            numCoalMin.Value = 7;
            numCoalMax.Value = 11;
            numCoalCnt.Value = 15;

            numCopperMin.Value = 12;
            numCopperMax.Value = 16;
            numCopperCnt.Value = 10;

            numIronMin.Value = 17;
            numIronMax.Value = 20;
            numIronCnt.Value = 8;

            numSilverMin.Value = 21;
            numSilverMax.Value = 24;
            numSilverCnt.Value = 5;

            numGoldMin.Value = 25;
            numGoldMax.Value = 28;
            numGoldCnt.Value = 3;

            numDiamondMin.Value = 29;
            numDiamondMax.Value = 31;
            numDiamondCnt.Value = 2;
        }

        public void RefreshAnalytics()
        {
            int[] ores = Editor.AnalyticOres();
            lblAnalyticsCntCoal.Text = ores[0].ToString() + "x";
            lblAnalyticsPointsCoal.Text = "= " + ores[1].ToString() + " P";
            lblAnalyticsCntCopper.Text = ores[2].ToString() + "x";
            lblAnalyticsPointsCopper.Text = "= " + ores[3].ToString() + " P";
            lblAnalyticsCntIron.Text = ores[4].ToString() + "x";
            lblAnalyticsPointsIron.Text = "= " + ores[5].ToString() + " P";
            lblAnalyticsCntSilver.Text = ores[6].ToString() + "x";
            lblAnalyticsPointsSilver.Text = "= " + ores[7].ToString() + " P";
            lblAnalyticsCntGold.Text = ores[8].ToString() + "x";
            lblAnalyticsPointsGold.Text = "= " + ores[9].ToString() + " P";
            lblAnalyticsCntDiamond.Text = ores[10].ToString() + "x";
            lblAnalyticsPointsDiamond.Text = "= " + ores[11].ToString() + " P";
            lblTotalPoints.Text = "= " + ores[12].ToString() + " P";
        }
    }
}
