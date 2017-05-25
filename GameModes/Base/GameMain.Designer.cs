namespace projectlf6
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
			this.lbl_playerone = new System.Windows.Forms.Label();
			this.lbl_playertwo = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl_scoreplayerone = new System.Windows.Forms.Label();
			this.lbl_scoreplayertwo = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menue_mute = new System.Windows.Forms.ToolStripMenuItem();
			this.pbBoard = new System.Windows.Forms.PictureBox();
			this.pbxPlayerOneSkin = new System.Windows.Forms.PictureBox();
			this.pbxPlayerTwoSkin = new System.Windows.Forms.PictureBox();
			this.pbxMoves = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbBoard)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxPlayerOneSkin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxPlayerTwoSkin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxMoves)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_playerone
			// 
			this.lbl_playerone.AutoSize = true;
			this.lbl_playerone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_playerone.Location = new System.Drawing.Point(57, 28);
			this.lbl_playerone.Name = "lbl_playerone";
			this.lbl_playerone.Size = new System.Drawing.Size(56, 17);
			this.lbl_playerone.TabIndex = 1;
			this.lbl_playerone.Text = "Player1";
			// 
			// lbl_playertwo
			// 
			this.lbl_playertwo.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lbl_playertwo.AutoSize = true;
			this.lbl_playertwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_playertwo.Location = new System.Drawing.Point(824, 43);
			this.lbl_playertwo.Name = "lbl_playertwo";
			this.lbl_playertwo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl_playertwo.Size = new System.Drawing.Size(56, 17);
			this.lbl_playertwo.TabIndex = 2;
			this.lbl_playertwo.Text = "Player2";
			this.lbl_playertwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1.Location = new System.Drawing.Point(57, 208);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(44, 13);
			this.lbl1.TabIndex = 5;
			this.lbl1.Text = "Score:";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl2.Location = new System.Drawing.Point(824, 208);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(44, 13);
			this.lbl2.TabIndex = 6;
			this.lbl2.Text = "Score:";
			// 
			// lbl_scoreplayerone
			// 
			this.lbl_scoreplayerone.AutoSize = true;
			this.lbl_scoreplayerone.Location = new System.Drawing.Point(115, 208);
			this.lbl_scoreplayerone.Name = "lbl_scoreplayerone";
			this.lbl_scoreplayerone.Size = new System.Drawing.Size(35, 13);
			this.lbl_scoreplayerone.TabIndex = 7;
			this.lbl_scoreplayerone.Text = "label1";
			// 
			// lbl_scoreplayertwo
			// 
			this.lbl_scoreplayertwo.AutoSize = true;
			this.lbl_scoreplayertwo.Location = new System.Drawing.Point(882, 208);
			this.lbl_scoreplayertwo.Name = "lbl_scoreplayertwo";
			this.lbl_scoreplayertwo.Size = new System.Drawing.Size(35, 13);
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
            this.menue_mute});
			this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
			this.optionenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.optionenToolStripMenuItem.Text = "Optionen";
			// 
			// menue_mute
			// 
			this.menue_mute.Name = "menue_mute";
			this.menue_mute.Size = new System.Drawing.Size(165, 22);
			this.menue_mute.Text = "Stumm (Ein/Aus)";
			// 
			// pbBoard
			// 
			this.pbBoard.Location = new System.Drawing.Point(249, 27);
			this.pbBoard.Name = "pbBoard";
			this.pbBoard.Size = new System.Drawing.Size(512, 512);
			this.pbBoard.TabIndex = 12;
			this.pbBoard.TabStop = false;
			// 
			// pbxPlayerOneSkin
			// 
			this.pbxPlayerOneSkin.Location = new System.Drawing.Point(60, 75);
			this.pbxPlayerOneSkin.Name = "pbxPlayerOneSkin";
			this.pbxPlayerOneSkin.Size = new System.Drawing.Size(75, 123);
			this.pbxPlayerOneSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbxPlayerOneSkin.TabIndex = 13;
			this.pbxPlayerOneSkin.TabStop = false;
			// 
			// pbxPlayerTwoSkin
			// 
			this.pbxPlayerTwoSkin.Location = new System.Drawing.Point(827, 75);
			this.pbxPlayerTwoSkin.Name = "pbxPlayerTwoSkin";
			this.pbxPlayerTwoSkin.Size = new System.Drawing.Size(75, 130);
			this.pbxPlayerTwoSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbxPlayerTwoSkin.TabIndex = 14;
			this.pbxPlayerTwoSkin.TabStop = false;
			// 
			// pbxMoves
			// 
			this.pbxMoves.Location = new System.Drawing.Point(205, 554);
			this.pbxMoves.Name = "pbxMoves";
			this.pbxMoves.Size = new System.Drawing.Size(600, 50);
			this.pbxMoves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbxMoves.TabIndex = 15;
			this.pbxMoves.TabStop = false;
			// 
			// GameMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 616);
			this.Controls.Add(this.pbxMoves);
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
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "GameMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GameMain";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameMain_KeyDown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbBoard)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxPlayerOneSkin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxPlayerTwoSkin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxMoves)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem menue_mute;
		private System.Windows.Forms.PictureBox pbBoard;
		private System.Windows.Forms.PictureBox pbxPlayerOneSkin;
		private System.Windows.Forms.PictureBox pbxPlayerTwoSkin;
		private System.Windows.Forms.PictureBox pbxMoves;
	}
}