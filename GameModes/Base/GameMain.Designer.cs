using minesHunter.Properties;

namespace minesHunter
{
    partial class GameMain
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
            this.lbl_playerone = new System.Windows.Forms.Label();
            this.lbl_playertwo = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl_scoreplayerone = new System.Windows.Forms.Label();
            this.lbl_scoreplayertwo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menueSound = new System.Windows.Forms.ToolStripMenuItem();
            this.spielBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbBoard = new System.Windows.Forms.PictureBox();
            this.pbxPlayerOneSkin = new System.Windows.Forms.PictureBox();
            this.pbxPlayerTwoSkin = new System.Windows.Forms.PictureBox();
            this.pbxMoves = new System.Windows.Forms.PictureBox();
            this.pbxLower = new System.Windows.Forms.PictureBox();
            this.pbxMidd = new System.Windows.Forms.PictureBox();
            this.pbxUpper = new System.Windows.Forms.PictureBox();
            this.lblRollTheDice = new System.Windows.Forms.Label();
            this.lblPlayerOneActive = new System.Windows.Forms.Label();
            this.lblPlayerTwoActive = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pB_F1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerOneSkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerTwoSkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMidd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpper)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_F1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_playerone
            // 
            this.lbl_playerone.AutoSize = true;
            this.lbl_playerone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerone.Location = new System.Drawing.Point(57, 28);
            this.lbl_playerone.Name = "lbl_playerone";
            this.lbl_playerone.Size = new System.Drawing.Size(61, 20);
            this.lbl_playerone.TabIndex = 1;
            this.lbl_playerone.Text = "Player1";
            // 
            // lbl_playertwo
            // 
            this.lbl_playertwo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_playertwo.AutoSize = true;
            this.lbl_playertwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playertwo.Location = new System.Drawing.Point(848, 28);
            this.lbl_playertwo.Name = "lbl_playertwo";
            this.lbl_playertwo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_playertwo.Size = new System.Drawing.Size(61, 20);
            this.lbl_playertwo.TabIndex = 2;
            this.lbl_playertwo.Text = "Player2";
            this.lbl_playertwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(57, 208);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(61, 20);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Score:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(848, 208);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(61, 20);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "Score:";
            // 
            // lbl_scoreplayerone
            // 
            this.lbl_scoreplayerone.AutoSize = true;
            this.lbl_scoreplayerone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreplayerone.Location = new System.Drawing.Point(115, 208);
            this.lbl_scoreplayerone.Name = "lbl_scoreplayerone";
            this.lbl_scoreplayerone.Size = new System.Drawing.Size(51, 20);
            this.lbl_scoreplayerone.TabIndex = 7;
            this.lbl_scoreplayerone.Text = "label1";
            // 
            // lbl_scoreplayertwo
            // 
            this.lbl_scoreplayertwo.AutoSize = true;
            this.lbl_scoreplayertwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreplayertwo.Location = new System.Drawing.Point(906, 208);
            this.lbl_scoreplayertwo.Name = "lbl_scoreplayertwo";
            this.lbl_scoreplayertwo.Size = new System.Drawing.Size(51, 20);
            this.lbl_scoreplayertwo.TabIndex = 8;
            this.lbl_scoreplayertwo.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menueSound,
            this.spielBeendenToolStripMenuItem});
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.optionenToolStripMenuItem.Text = "Optionen";
            // 
            // menueSound
            // 
            this.menueSound.Checked = true;
            this.menueSound.CheckOnClick = true;
            this.menueSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menueSound.Name = "menueSound";
            this.menueSound.Size = new System.Drawing.Size(152, 22);
            this.menueSound.Text = "Sound";
            // 
            // spielBeendenToolStripMenuItem
            // 
            this.spielBeendenToolStripMenuItem.Name = "spielBeendenToolStripMenuItem";
            this.spielBeendenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.spielBeendenToolStripMenuItem.Text = "Spiel Beenden";
            this.spielBeendenToolStripMenuItem.Click += new System.EventHandler(this.spielBeendenToolStripMenuItem_Click);
            // 
            // pbBoard
            // 
            this.pbBoard.Location = new System.Drawing.Point(205, 27);
            this.pbBoard.Name = "pbBoard";
            this.pbBoard.Size = new System.Drawing.Size(600, 512);
            this.pbBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBoard.TabIndex = 12;
            this.pbBoard.TabStop = false;
            // 
            // pbxPlayerOneSkin
            // 
            this.pbxPlayerOneSkin.Location = new System.Drawing.Point(61, 77);
            this.pbxPlayerOneSkin.Name = "pbxPlayerOneSkin";
            this.pbxPlayerOneSkin.Size = new System.Drawing.Size(75, 123);
            this.pbxPlayerOneSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxPlayerOneSkin.TabIndex = 13;
            this.pbxPlayerOneSkin.TabStop = false;
            this.toolTip1.SetToolTip(this.pbxPlayerOneSkin, "Spieler 1");
            // 
            // pbxPlayerTwoSkin
            // 
            this.pbxPlayerTwoSkin.Location = new System.Drawing.Point(852, 77);
            this.pbxPlayerTwoSkin.Name = "pbxPlayerTwoSkin";
            this.pbxPlayerTwoSkin.Size = new System.Drawing.Size(75, 123);
            this.pbxPlayerTwoSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxPlayerTwoSkin.TabIndex = 14;
            this.pbxPlayerTwoSkin.TabStop = false;
            this.toolTip1.SetToolTip(this.pbxPlayerTwoSkin, "Spieler 2");
            // 
            // pbxMoves
            // 
            this.pbxMoves.Location = new System.Drawing.Point(205, 533);
            this.pbxMoves.Name = "pbxMoves";
            this.pbxMoves.Size = new System.Drawing.Size(600, 80);
            this.pbxMoves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxMoves.TabIndex = 15;
            this.pbxMoves.TabStop = false;
            // 
            // pbxLower
            // 
            this.pbxLower.Location = new System.Drawing.Point(205, 533);
            this.pbxLower.Name = "pbxLower";
            this.pbxLower.Size = new System.Drawing.Size(600, 80);
            this.pbxLower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLower.TabIndex = 16;
            this.pbxLower.TabStop = false;
            // 
            // pbxMidd
            // 
            this.pbxMidd.Location = new System.Drawing.Point(205, 533);
            this.pbxMidd.Name = "pbxMidd";
            this.pbxMidd.Size = new System.Drawing.Size(600, 80);
            this.pbxMidd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxMidd.TabIndex = 17;
            this.pbxMidd.TabStop = false;
            // 
            // pbxUpper
            // 
            this.pbxUpper.Location = new System.Drawing.Point(205, 533);
            this.pbxUpper.Name = "pbxUpper";
            this.pbxUpper.Size = new System.Drawing.Size(600, 80);
            this.pbxUpper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxUpper.TabIndex = 18;
            this.pbxUpper.TabStop = false;
            // 
            // lblRollTheDice
            // 
            this.lblRollTheDice.AutoSize = true;
            this.lblRollTheDice.BackColor = System.Drawing.SystemColors.Control;
            this.lblRollTheDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollTheDice.Location = new System.Drawing.Point(348, 562);
            this.lblRollTheDice.Name = "lblRollTheDice";
            this.lblRollTheDice.Size = new System.Drawing.Size(334, 20);
            this.lblRollTheDice.TabIndex = 19;
            this.lblRollTheDice.Text = "Spieler 1 ist dran .. Mit Leertaste würfeln";
            // 
            // lblPlayerOneActive
            // 
            this.lblPlayerOneActive.AutoSize = true;
            this.lblPlayerOneActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneActive.Location = new System.Drawing.Point(84, 48);
            this.lblPlayerOneActive.Name = "lblPlayerOneActive";
            this.lblPlayerOneActive.Size = new System.Drawing.Size(34, 26);
            this.lblPlayerOneActive.TabIndex = 20;
            this.lblPlayerOneActive.Text = "▼";
            this.lblPlayerOneActive.Visible = false;
            // 
            // lblPlayerTwoActive
            // 
            this.lblPlayerTwoActive.AutoSize = true;
            this.lblPlayerTwoActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoActive.Location = new System.Drawing.Point(871, 48);
            this.lblPlayerTwoActive.Name = "lblPlayerTwoActive";
            this.lblPlayerTwoActive.Size = new System.Drawing.Size(34, 26);
            this.lblPlayerTwoActive.TabIndex = 21;
            this.lblPlayerTwoActive.Text = "▼";
            this.lblPlayerTwoActive.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(864, 310);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(132, 279);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "200";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "100";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "60";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "40";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "20";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::minesHunter.Properties.Resources.Copper;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(4, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 34);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Kupfer");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Erz";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Punkte";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::minesHunter.Properties.Resources.Coal;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(4, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Kohle");
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "10";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::minesHunter.Properties.Resources.Iron;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(4, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 34);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Eisen");
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::minesHunter.Properties.Resources.Silver;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(4, 158);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 34);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Silber");
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::minesHunter.Properties.Resources.Gold;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Location = new System.Drawing.Point(4, 199);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 34);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Gold");
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::minesHunter.Properties.Resources.Diamond;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Location = new System.Drawing.Point(4, 240);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(58, 34);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "Diamant");
            // 
            // pB_F1
            // 
            this.pB_F1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pB_F1.Location = new System.Drawing.Point(12, 310);
            this.pB_F1.Name = "pB_F1";
            this.pB_F1.Size = new System.Drawing.Size(50, 50);
            this.pB_F1.TabIndex = 23;
            this.pB_F1.TabStop = false;
            this.pB_F1.Paint += new System.Windows.Forms.PaintEventHandler(this.pB_F1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Steuerung";
            // 
            // GameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 602);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pB_F1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblPlayerTwoActive);
            this.Controls.Add(this.lblPlayerOneActive);
            this.Controls.Add(this.lblRollTheDice);
            this.Controls.Add(this.pbxPlayerTwoSkin);
            this.Controls.Add(this.pbxPlayerOneSkin);
            this.Controls.Add(this.pbBoard);
            this.Controls.Add(this.lbl_scoreplayertwo);
            this.Controls.Add(this.lbl_scoreplayerone);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl_playertwo);
            this.Controls.Add(this.lbl_playerone);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbxMoves);
            this.Controls.Add(this.pbxUpper);
            this.Controls.Add(this.pbxMidd);
            this.Controls.Add(this.pbxLower);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::minesHunter.Properties.Resources.Icon;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1024, 640);
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Name = "GameMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameMain_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerOneSkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerTwoSkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMidd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpper)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_F1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_playerone;
        private System.Windows.Forms.Label lbl_playertwo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl_scoreplayerone;
        private System.Windows.Forms.Label lbl_scoreplayertwo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menueSound;
		private System.Windows.Forms.PictureBox pbBoard;
		private System.Windows.Forms.PictureBox pbxPlayerOneSkin;
		private System.Windows.Forms.PictureBox pbxPlayerTwoSkin;
		private System.Windows.Forms.PictureBox pbxMoves;
		private System.Windows.Forms.PictureBox pbxLower;
		private System.Windows.Forms.PictureBox pbxMidd;
		private System.Windows.Forms.PictureBox pbxUpper;
        private System.Windows.Forms.Label lblRollTheDice;
        private System.Windows.Forms.ToolStripMenuItem spielBeendenToolStripMenuItem;
        private System.Windows.Forms.Label lblPlayerOneActive;
        private System.Windows.Forms.Label lblPlayerTwoActive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pB_F1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}