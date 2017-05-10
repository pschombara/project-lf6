namespace projectlf6
{
    partial class LevelEditorMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelExportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mauszeigerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.pbSelection = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSky = new System.Windows.Forms.Button();
            this.btnNoBrocken = new System.Windows.Forms.Button();
            this.btnStone = new System.Windows.Forms.Button();
            this.btnDirt = new System.Windows.Forms.Button();
            this.btnGrass = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDiamond = new System.Windows.Forms.Button();
            this.btnGold = new System.Windows.Forms.Button();
            this.btnSilver = new System.Windows.Forms.Button();
            this.btnIron = new System.Windows.Forms.Button();
            this.btnCopper = new System.Windows.Forms.Button();
            this.btnCoal = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblRAM = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblCPU = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlLevel = new System.Windows.Forms.Panel();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnlSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelection)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem,
            this.ansichtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesLevelToolStripMenuItem,
            this.levelLadenToolStripMenuItem,
            this.levelSpeichernToolStripMenuItem,
            this.levelExportierenToolStripMenuItem,
            this.editorBeendenToolStripMenuItem});
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.editorToolStripMenuItem.Text = "Editor";
            // 
            // neuesLevelToolStripMenuItem
            // 
            this.neuesLevelToolStripMenuItem.Name = "neuesLevelToolStripMenuItem";
            this.neuesLevelToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.neuesLevelToolStripMenuItem.Text = "Neues Level";
            this.neuesLevelToolStripMenuItem.Click += new System.EventHandler(this.neuesLevelToolStripMenuItem_Click);
            // 
            // levelLadenToolStripMenuItem
            // 
            this.levelLadenToolStripMenuItem.Name = "levelLadenToolStripMenuItem";
            this.levelLadenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.levelLadenToolStripMenuItem.Text = "Level laden";
            this.levelLadenToolStripMenuItem.Click += new System.EventHandler(this.levelLadenToolStripMenuItem_Click);
            // 
            // levelSpeichernToolStripMenuItem
            // 
            this.levelSpeichernToolStripMenuItem.Name = "levelSpeichernToolStripMenuItem";
            this.levelSpeichernToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.levelSpeichernToolStripMenuItem.Text = "Level speichern";
            this.levelSpeichernToolStripMenuItem.Click += new System.EventHandler(this.levelSpeichernToolStripMenuItem_Click);
            // 
            // levelExportierenToolStripMenuItem
            // 
            this.levelExportierenToolStripMenuItem.Name = "levelExportierenToolStripMenuItem";
            this.levelExportierenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.levelExportierenToolStripMenuItem.Text = "Level Exportieren";
            this.levelExportierenToolStripMenuItem.Click += new System.EventHandler(this.levelExportierenToolStripMenuItem_Click);
            // 
            // editorBeendenToolStripMenuItem
            // 
            this.editorBeendenToolStripMenuItem.Name = "editorBeendenToolStripMenuItem";
            this.editorBeendenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editorBeendenToolStripMenuItem.Text = "Editor beenden";
            this.editorBeendenToolStripMenuItem.Click += new System.EventHandler(this.editorBeendenToolStripMenuItem_Click);
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rasterToolStripMenuItem,
            this.mauszeigerToolStripMenuItem});
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // rasterToolStripMenuItem
            // 
            this.rasterToolStripMenuItem.CheckOnClick = true;
            this.rasterToolStripMenuItem.Name = "rasterToolStripMenuItem";
            this.rasterToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.rasterToolStripMenuItem.Text = "Raster";
            this.rasterToolStripMenuItem.Click += new System.EventHandler(this.rasterToolStripMenuItem_Click);
            // 
            // mauszeigerToolStripMenuItem
            // 
            this.mauszeigerToolStripMenuItem.CheckOnClick = true;
            this.mauszeigerToolStripMenuItem.Name = "mauszeigerToolStripMenuItem";
            this.mauszeigerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.mauszeigerToolStripMenuItem.Text = "Mauszeiger";
            this.mauszeigerToolStripMenuItem.Click += new System.EventHandler(this.mauszeigerToolStripMenuItem_Click);
            // 
            // pnlSelection
            // 
            this.pnlSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelection.Controls.Add(this.pbSelection);
            this.pnlSelection.Location = new System.Drawing.Point(12, 383);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(196, 98);
            this.pnlSelection.TabIndex = 1;
            // 
            // pbSelection
            // 
            this.pbSelection.BackgroundImage = global::projectlf6.Properties.Resources.Grass;
            this.pbSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSelection.Location = new System.Drawing.Point(69, 23);
            this.pbSelection.Name = "pbSelection";
            this.pbSelection.Size = new System.Drawing.Size(50, 50);
            this.pbSelection.TabIndex = 0;
            this.pbSelection.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 350);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPlayer2);
            this.tabPage1.Controls.Add(this.btnPlayer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spieler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.BackgroundImage = global::projectlf6.Properties.Resources.Player_2;
            this.btnPlayer2.Location = new System.Drawing.Point(72, 16);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(31, 64);
            this.btnPlayer2.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnPlayer2, "Spieler 2");
            this.btnPlayer2.UseVisualStyleBackColor = true;
            this.btnPlayer2.Click += new System.EventHandler(this.btnPlayer2_Click);
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.BackgroundImage = global::projectlf6.Properties.Resources.Player_1;
            this.btnPlayer1.Location = new System.Drawing.Point(32, 16);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(31, 64);
            this.btnPlayer1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnPlayer1, "Spieler 1");
            this.btnPlayer1.UseVisualStyleBackColor = true;
            this.btnPlayer1.Click += new System.EventHandler(this.btnPlayer1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSky);
            this.tabPage2.Controls.Add(this.btnNoBrocken);
            this.tabPage2.Controls.Add(this.btnStone);
            this.tabPage2.Controls.Add(this.btnDirt);
            this.tabPage2.Controls.Add(this.btnGrass);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Blöcke";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSky
            // 
            this.btnSky.BackgroundImage = global::projectlf6.Properties.Resources.Sky;
            this.btnSky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSky.Location = new System.Drawing.Point(30, 128);
            this.btnSky.Name = "btnSky";
            this.btnSky.Size = new System.Drawing.Size(50, 50);
            this.btnSky.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnSky, "Himmel");
            this.btnSky.UseVisualStyleBackColor = true;
            this.btnSky.Click += new System.EventHandler(this.btnSky_Click);
            // 
            // btnNoBrocken
            // 
            this.btnNoBrocken.BackgroundImage = global::projectlf6.Properties.Resources.No_Brocken;
            this.btnNoBrocken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoBrocken.Location = new System.Drawing.Point(86, 72);
            this.btnNoBrocken.Name = "btnNoBrocken";
            this.btnNoBrocken.Size = new System.Drawing.Size(50, 50);
            this.btnNoBrocken.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnNoBrocken, "Nicht abbaubar");
            this.btnNoBrocken.UseVisualStyleBackColor = true;
            this.btnNoBrocken.Click += new System.EventHandler(this.btnNoBrocken_Click);
            // 
            // btnStone
            // 
            this.btnStone.BackgroundImage = global::projectlf6.Properties.Resources.Stone;
            this.btnStone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStone.Location = new System.Drawing.Point(30, 72);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(50, 50);
            this.btnStone.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnStone, "Stein");
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnDirt
            // 
            this.btnDirt.BackgroundImage = global::projectlf6.Properties.Resources.Dirt;
            this.btnDirt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirt.Location = new System.Drawing.Point(86, 16);
            this.btnDirt.Name = "btnDirt";
            this.btnDirt.Size = new System.Drawing.Size(50, 50);
            this.btnDirt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnDirt, "Erde");
            this.btnDirt.UseVisualStyleBackColor = true;
            this.btnDirt.Click += new System.EventHandler(this.btnDirt_Click);
            // 
            // btnGrass
            // 
            this.btnGrass.BackgroundImage = global::projectlf6.Properties.Resources.Grass;
            this.btnGrass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrass.Location = new System.Drawing.Point(30, 16);
            this.btnGrass.Name = "btnGrass";
            this.btnGrass.Size = new System.Drawing.Size(50, 50);
            this.btnGrass.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnGrass, "Gras");
            this.btnGrass.UseVisualStyleBackColor = true;
            this.btnGrass.Click += new System.EventHandler(this.btnGrass_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDiamond);
            this.tabPage3.Controls.Add(this.btnGold);
            this.tabPage3.Controls.Add(this.btnSilver);
            this.tabPage3.Controls.Add(this.btnIron);
            this.tabPage3.Controls.Add(this.btnCopper);
            this.tabPage3.Controls.Add(this.btnCoal);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(192, 324);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Erze";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDiamond
            // 
            this.btnDiamond.BackgroundImage = global::projectlf6.Properties.Resources.Diamond;
            this.btnDiamond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiamond.Location = new System.Drawing.Point(86, 128);
            this.btnDiamond.Name = "btnDiamond";
            this.btnDiamond.Size = new System.Drawing.Size(50, 50);
            this.btnDiamond.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnDiamond, "Diamant");
            this.btnDiamond.UseVisualStyleBackColor = true;
            this.btnDiamond.Click += new System.EventHandler(this.btnDiamond_Click);
            // 
            // btnGold
            // 
            this.btnGold.BackgroundImage = global::projectlf6.Properties.Resources.Gold;
            this.btnGold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGold.Location = new System.Drawing.Point(30, 128);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(50, 50);
            this.btnGold.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnGold, "Gold");
            this.btnGold.UseVisualStyleBackColor = true;
            this.btnGold.Click += new System.EventHandler(this.btnGold_Click);
            // 
            // btnSilver
            // 
            this.btnSilver.BackgroundImage = global::projectlf6.Properties.Resources.Silver;
            this.btnSilver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSilver.Location = new System.Drawing.Point(86, 72);
            this.btnSilver.Name = "btnSilver";
            this.btnSilver.Size = new System.Drawing.Size(50, 50);
            this.btnSilver.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnSilver, "Silber");
            this.btnSilver.UseVisualStyleBackColor = true;
            this.btnSilver.Click += new System.EventHandler(this.btnSilver_Click);
            // 
            // btnIron
            // 
            this.btnIron.BackgroundImage = global::projectlf6.Properties.Resources.Iron;
            this.btnIron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIron.Location = new System.Drawing.Point(30, 72);
            this.btnIron.Name = "btnIron";
            this.btnIron.Size = new System.Drawing.Size(50, 50);
            this.btnIron.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnIron, "Eisen");
            this.btnIron.UseVisualStyleBackColor = true;
            this.btnIron.Click += new System.EventHandler(this.btnIron_Click);
            // 
            // btnCopper
            // 
            this.btnCopper.BackgroundImage = global::projectlf6.Properties.Resources.Copper;
            this.btnCopper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopper.Location = new System.Drawing.Point(86, 16);
            this.btnCopper.Name = "btnCopper";
            this.btnCopper.Size = new System.Drawing.Size(50, 50);
            this.btnCopper.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnCopper, "Kupfer");
            this.btnCopper.UseVisualStyleBackColor = true;
            this.btnCopper.Click += new System.EventHandler(this.btnCopper_Click);
            // 
            // btnCoal
            // 
            this.btnCoal.BackgroundImage = global::projectlf6.Properties.Resources.Coal;
            this.btnCoal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCoal.Location = new System.Drawing.Point(30, 16);
            this.btnCoal.Name = "btnCoal";
            this.btnCoal.Size = new System.Drawing.Size(50, 50);
            this.btnCoal.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnCoal, "Kohle");
            this.btnCoal.UseVisualStyleBackColor = true;
            this.btnCoal.Click += new System.EventHandler(this.btnCoal_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblLocation,
            this.toolStripStatusLblRAM,
            this.toolStripStatusLblCPU});
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLblLocation
            // 
            this.toolStripStatusLblLocation.Name = "toolStripStatusLblLocation";
            this.toolStripStatusLblLocation.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLblLocation.Text = "X: 0 Y: 0";
            // 
            // toolStripStatusLblRAM
            // 
            this.toolStripStatusLblRAM.Name = "toolStripStatusLblRAM";
            this.toolStripStatusLblRAM.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLblRAM.Text = "RAM: -- MB";
            // 
            // toolStripStatusLblCPU
            // 
            this.toolStripStatusLblCPU.Name = "toolStripStatusLblCPU";
            this.toolStripStatusLblCPU.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLblCPU.Text = "CPU: --%";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Level";
            this.openFileDialog1.Filter = "Level-Datei|*.lvl";
            this.openFileDialog1.Title = "Level laden...";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Level";
            this.saveFileDialog1.Filter = "Level-Datei|*.lvl";
            this.saveFileDialog1.Title = "Level speichern...";
            // 
            // pnlLevel
            // 
            this.pnlLevel.Location = new System.Drawing.Point(256, 49);
            this.pnlLevel.Name = "pnlLevel";
            this.pnlLevel.Size = new System.Drawing.Size(513, 513);
            this.pnlLevel.TabIndex = 7;
            this.pnlLevel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLevel_Paint);
            this.pnlLevel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLevel_MouseDown);
            this.pnlLevel.MouseEnter += new System.EventHandler(this.pnlLevel_MouseEnter);
            this.pnlLevel.MouseLeave += new System.EventHandler(this.pnlLevel_MouseLeave);
            this.pnlLevel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlLevel_MouseMove);
            this.pnlLevel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlLevel_MouseUp);
            // 
            // saveFileDialogExport
            // 
            this.saveFileDialogExport.FileName = "Level_Export";
            this.saveFileDialogExport.Filter = "Bitmap|*.bmp";
            this.saveFileDialogExport.Title = "Level als Bild exportieren";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // LevelEditorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.pnlLevel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlSelection);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LevelEditorMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelection)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelLadenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorBeendenToolStripMenuItem;
        private System.Windows.Forms.Panel pnlSelection;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnGrass;
        private System.Windows.Forms.Button btnDirt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNoBrocken;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Button btnDiamond;
        private System.Windows.Forms.Button btnGold;
        private System.Windows.Forms.Button btnSilver;
        private System.Windows.Forms.Button btnIron;
        private System.Windows.Forms.Button btnCopper;
        private System.Windows.Forms.Button btnCoal;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.PictureBox pbSelection;
        private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mauszeigerToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel pnlLevel;
        private System.Windows.Forms.ToolStripMenuItem levelExportierenToolStripMenuItem;
        private System.Windows.Forms.Button btnSky;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblRAM;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblCPU;
    }
}