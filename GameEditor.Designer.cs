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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGames
            // 
            this.dataGridViewGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameName,
            this.levelCount});
            this.dataGridViewGames.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewGames.Name = "dataGridViewGames";
            this.dataGridViewGames.Size = new System.Drawing.Size(708, 112);
            this.dataGridViewGames.TabIndex = 0;
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
            this.txtNewGameName.Location = new System.Drawing.Point(67, 285);
            this.txtNewGameName.Name = "txtNewGameName";
            this.txtNewGameName.Size = new System.Drawing.Size(100, 20);
            this.txtNewGameName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(173, 283);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(151, 23);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "Neues Spiel erstellen";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // GameEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 317);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewGameName);
            this.Controls.Add(this.dataGridViewGames);
            this.Name = "GameEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelCount;
        private System.Windows.Forms.TextBox txtNewGameName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewGame;
    }
}