namespace projectlf6
{
    partial class GameEditor
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
            this.dataGridViewGames = new System.Windows.Forms.DataGridView();
            this.gameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNewGameName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grbAddGame = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
            this.grbAddGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewGames
            // 
            this.dataGridViewGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameName,
            this.levelCount});
            this.dataGridViewGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewGames.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGames.Name = "dataGridViewGames";
            this.dataGridViewGames.Size = new System.Drawing.Size(744, 171);
            this.dataGridViewGames.TabIndex = 0;
            this.dataGridViewGames.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGames_CellDoubleClick);
            // 
            // gameName
            // 
            this.gameName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gameName.HeaderText = "Spielname";
            this.gameName.Name = "gameName";
            this.gameName.ReadOnly = true;
            // 
            // levelCount
            // 
            this.levelCount.FillWeight = 150F;
            this.levelCount.HeaderText = "Anzahl Level";
            this.levelCount.Name = "levelCount";
            this.levelCount.ReadOnly = true;
            // 
            // txtNewGameName
            // 
            this.txtNewGameName.Location = new System.Drawing.Point(50, 34);
            this.txtNewGameName.Name = "txtNewGameName";
            this.txtNewGameName.Size = new System.Drawing.Size(100, 20);
            this.txtNewGameName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(156, 32);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(151, 23);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "Neues Spiel erstellen";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 282);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grbAddGame
            // 
            this.grbAddGame.Controls.Add(this.label1);
            this.grbAddGame.Controls.Add(this.txtNewGameName);
            this.grbAddGame.Controls.Add(this.btnNewGame);
            this.grbAddGame.Location = new System.Drawing.Point(0, 187);
            this.grbAddGame.Name = "grbAddGame";
            this.grbAddGame.Size = new System.Drawing.Size(744, 66);
            this.grbAddGame.TabIndex = 5;
            this.grbAddGame.TabStop = false;
            this.grbAddGame.Text = "Spiel hinzufügen";
            // 
            // GameEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 317);
            this.Controls.Add(this.grbAddGame);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewGames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
            this.grbAddGame.ResumeLayout(false);
            this.grbAddGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelCount;
        private System.Windows.Forms.TextBox txtNewGameName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grbAddGame;
    }
}