namespace projectlf6
{
	partial class ScoreView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreView));
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvScoreView = new System.Windows.Forms.DataGridView();
            this.scorePlayerOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scorePlayerTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLevel
            // 
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLevel.Location = new System.Drawing.Point(168, 28);
            this.txtLevel.Multiline = true;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(33, 20);
            this.txtLevel.TabIndex = 99999;
            this.txtLevel.TabStop = false;
            this.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(134, 173);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(144, 29);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "nächster Level";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgvScoreView
            // 
            this.dgvScoreView.AllowUserToAddRows = false;
            this.dgvScoreView.AllowUserToDeleteRows = false;
            this.dgvScoreView.AllowUserToResizeColumns = false;
            this.dgvScoreView.AllowUserToResizeRows = false;
            this.dgvScoreView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvScoreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoreView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scorePlayerOne,
            this.scoreLevel,
            this.scorePlayerTwo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScoreView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScoreView.Location = new System.Drawing.Point(12, 12);
            this.dgvScoreView.MultiSelect = false;
            this.dgvScoreView.Name = "dgvScoreView";
            this.dgvScoreView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScoreView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScoreView.RowHeadersVisible = false;
            this.dgvScoreView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvScoreView.ShowEditingIcon = false;
            this.dgvScoreView.Size = new System.Drawing.Size(404, 150);
            this.dgvScoreView.TabIndex = 100000;
            // 
            // scorePlayerOne
            // 
            this.scorePlayerOne.HeaderText = "Punkte Spieler1";
            this.scorePlayerOne.Name = "scorePlayerOne";
            this.scorePlayerOne.ReadOnly = true;
            this.scorePlayerOne.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.scorePlayerOne.Width = 150;
            // 
            // scoreLevel
            // 
            this.scoreLevel.HeaderText = "Level";
            this.scoreLevel.Name = "scoreLevel";
            this.scoreLevel.ReadOnly = true;
            this.scoreLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // scorePlayerTwo
            // 
            this.scorePlayerTwo.HeaderText = "Punkte Spieler2";
            this.scorePlayerTwo.Name = "scorePlayerTwo";
            this.scorePlayerTwo.ReadOnly = true;
            this.scorePlayerTwo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.scorePlayerTwo.Width = 150;
            // 
            // ScoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 214);
            this.Controls.Add(this.dgvScoreView);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScoreView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ScoreView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtLevel;
		private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvScoreView;
        private System.Windows.Forms.DataGridViewTextBoxColumn scorePlayerOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn scorePlayerTwo;
    }
}