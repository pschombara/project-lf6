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
			this.lblLevel = new System.Windows.Forms.Label();
			this.txtNameP1 = new System.Windows.Forms.TextBox();
			this.txtNameP2 = new System.Windows.Forms.TextBox();
			this.txtScoreP1 = new System.Windows.Forms.TextBox();
			this.txtScoreP2 = new System.Windows.Forms.TextBox();
			this.txtLevel = new System.Windows.Forms.TextBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.txtTotalScoreP1 = new System.Windows.Forms.TextBox();
			this.txtTotalScoreP2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblLevel
			// 
			this.lblLevel.AutoSize = true;
			this.lblLevel.Location = new System.Drawing.Point(168, 9);
			this.lblLevel.Name = "lblLevel";
			this.lblLevel.Size = new System.Drawing.Size(33, 13);
			this.lblLevel.TabIndex = 2;
			this.lblLevel.Text = "Level";
			// 
			// txtNameP1
			// 
			this.txtNameP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNameP1.Location = new System.Drawing.Point(12, 9);
			this.txtNameP1.Name = "txtNameP1";
			this.txtNameP1.ReadOnly = true;
			this.txtNameP1.Size = new System.Drawing.Size(150, 13);
			this.txtNameP1.TabIndex = 99999;
			this.txtNameP1.TabStop = false;
			this.txtNameP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtNameP2
			// 
			this.txtNameP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNameP2.Location = new System.Drawing.Point(207, 9);
			this.txtNameP2.Name = "txtNameP2";
			this.txtNameP2.ReadOnly = true;
			this.txtNameP2.Size = new System.Drawing.Size(149, 13);
			this.txtNameP2.TabIndex = 99999;
			this.txtNameP2.TabStop = false;
			// 
			// txtScoreP1
			// 
			this.txtScoreP1.BackColor = System.Drawing.SystemColors.Control;
			this.txtScoreP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtScoreP1.Location = new System.Drawing.Point(12, 28);
			this.txtScoreP1.Multiline = true;
			this.txtScoreP1.Name = "txtScoreP1";
			this.txtScoreP1.ReadOnly = true;
			this.txtScoreP1.Size = new System.Drawing.Size(150, 20);
			this.txtScoreP1.TabIndex = 99999;
			this.txtScoreP1.TabStop = false;
			this.txtScoreP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtScoreP2
			// 
			this.txtScoreP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtScoreP2.Location = new System.Drawing.Point(207, 28);
			this.txtScoreP2.Multiline = true;
			this.txtScoreP2.Name = "txtScoreP2";
			this.txtScoreP2.ReadOnly = true;
			this.txtScoreP2.Size = new System.Drawing.Size(150, 20);
			this.txtScoreP2.TabIndex = 99999;
			this.txtScoreP2.TabStop = false;
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
			this.btnNext.Location = new System.Drawing.Point(112, 115);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(144, 23);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "nächster Level";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// txtTotalScoreP1
			// 
			this.txtTotalScoreP1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.txtTotalScoreP1.BackColor = System.Drawing.SystemColors.Control;
			this.txtTotalScoreP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTotalScoreP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalScoreP1.Location = new System.Drawing.Point(12, 89);
			this.txtTotalScoreP1.Multiline = true;
			this.txtTotalScoreP1.Name = "txtTotalScoreP1";
			this.txtTotalScoreP1.ReadOnly = true;
			this.txtTotalScoreP1.Size = new System.Drawing.Size(150, 20);
			this.txtTotalScoreP1.TabIndex = 100000;
			this.txtTotalScoreP1.TabStop = false;
			this.txtTotalScoreP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotalScoreP2
			// 
			this.txtTotalScoreP2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.txtTotalScoreP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTotalScoreP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalScoreP2.Location = new System.Drawing.Point(207, 89);
			this.txtTotalScoreP2.Multiline = true;
			this.txtTotalScoreP2.Name = "txtTotalScoreP2";
			this.txtTotalScoreP2.ReadOnly = true;
			this.txtTotalScoreP2.Size = new System.Drawing.Size(150, 20);
			this.txtTotalScoreP2.TabIndex = 100002;
			this.txtTotalScoreP2.TabStop = false;
			// 
			// ScoreView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 150);
			this.Controls.Add(this.txtTotalScoreP2);
			this.Controls.Add(this.txtTotalScoreP1);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.txtLevel);
			this.Controls.Add(this.txtScoreP2);
			this.Controls.Add(this.txtScoreP1);
			this.Controls.Add(this.txtNameP2);
			this.Controls.Add(this.txtNameP1);
			this.Controls.Add(this.lblLevel);
			this.Name = "ScoreView";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ScoreView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLevel;
		private System.Windows.Forms.TextBox txtNameP1;
		private System.Windows.Forms.TextBox txtNameP2;
		private System.Windows.Forms.TextBox txtScoreP1;
		private System.Windows.Forms.TextBox txtScoreP2;
		private System.Windows.Forms.TextBox txtLevel;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.TextBox txtTotalScoreP1;
		private System.Windows.Forms.TextBox txtTotalScoreP2;
	}
}