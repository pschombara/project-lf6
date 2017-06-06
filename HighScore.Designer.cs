namespace projectlf6
{
    partial class HighScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScore));
            this.dgvHighscore = new System.Windows.Forms.DataGridView();
            this.place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCloseHighscore = new System.Windows.Forms.Button();
            this.btnResetHighscore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighscore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHighscore
            // 
            this.dgvHighscore.AllowUserToAddRows = false;
            this.dgvHighscore.AllowUserToDeleteRows = false;
            this.dgvHighscore.AllowUserToResizeColumns = false;
            this.dgvHighscore.AllowUserToResizeRows = false;
            this.dgvHighscore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHighscore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHighscore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.place,
            this.player,
            this.game,
            this.levels,
            this.rounds,
            this.points});
            this.dgvHighscore.Location = new System.Drawing.Point(12, 12);
            this.dgvHighscore.Name = "dgvHighscore";
            this.dgvHighscore.ReadOnly = true;
            this.dgvHighscore.RowHeadersVisible = false;
            this.dgvHighscore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHighscore.Size = new System.Drawing.Size(756, 262);
            this.dgvHighscore.TabIndex = 0;
            // 
            // place
            // 
            this.place.FillWeight = 50F;
            this.place.HeaderText = "Platz";
            this.place.Name = "place";
            this.place.ReadOnly = true;
            this.place.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // player
            // 
            this.player.FillWeight = 300F;
            this.player.HeaderText = "Spieler";
            this.player.Name = "player";
            this.player.ReadOnly = true;
            this.player.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // game
            // 
            this.game.FillWeight = 275F;
            this.game.HeaderText = "Spiel";
            this.game.Name = "game";
            this.game.ReadOnly = true;
            this.game.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // levels
            // 
            this.levels.FillWeight = 150F;
            this.levels.HeaderText = "Anzahl Levels";
            this.levels.Name = "levels";
            this.levels.ReadOnly = true;
            this.levels.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rounds
            // 
            this.rounds.FillWeight = 150F;
            this.rounds.HeaderText = "Anzahl Runden";
            this.rounds.Name = "rounds";
            this.rounds.ReadOnly = true;
            this.rounds.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // points
            // 
            this.points.HeaderText = "Punkte";
            this.points.Name = "points";
            this.points.ReadOnly = true;
            this.points.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnCloseHighscore
            // 
            this.btnCloseHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseHighscore.Location = new System.Drawing.Point(12, 280);
            this.btnCloseHighscore.Name = "btnCloseHighscore";
            this.btnCloseHighscore.Size = new System.Drawing.Size(169, 40);
            this.btnCloseHighscore.TabIndex = 1;
            this.btnCloseHighscore.Text = "Beenden";
            this.btnCloseHighscore.UseVisualStyleBackColor = true;
            this.btnCloseHighscore.Click += new System.EventHandler(this.btnCloseHighscore_Click);
            // 
            // btnResetHighscore
            // 
            this.btnResetHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetHighscore.Location = new System.Drawing.Point(586, 280);
            this.btnResetHighscore.Name = "btnResetHighscore";
            this.btnResetHighscore.Size = new System.Drawing.Size(182, 40);
            this.btnResetHighscore.TabIndex = 2;
            this.btnResetHighscore.Text = "Zurücksetzen";
            this.btnResetHighscore.UseVisualStyleBackColor = true;
            this.btnResetHighscore.Click += new System.EventHandler(this.btnResetHighscore_Click);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 323);
            this.Controls.Add(this.btnResetHighscore);
            this.Controls.Add(this.btnCloseHighscore);
            this.Controls.Add(this.dgvHighscore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(796, 362);
            this.MinimumSize = new System.Drawing.Size(796, 362);
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highscore";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HighScore_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighscore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHighscore;
        private System.Windows.Forms.DataGridViewTextBoxColumn place;
        private System.Windows.Forms.DataGridViewTextBoxColumn player;
        private System.Windows.Forms.DataGridViewTextBoxColumn game;
        private System.Windows.Forms.DataGridViewTextBoxColumn levels;
        private System.Windows.Forms.DataGridViewTextBoxColumn rounds;
        private System.Windows.Forms.DataGridViewTextBoxColumn points;
        private System.Windows.Forms.Button btnCloseHighscore;
        private System.Windows.Forms.Button btnResetHighscore;
    }
}