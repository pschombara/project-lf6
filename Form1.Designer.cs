namespace projectlf6
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnLevelEditor = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(-2, 1);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(285, 48);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "Neues Spiel";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnLevelEditor
            // 
            this.btnLevelEditor.Location = new System.Drawing.Point(-2, 55);
            this.btnLevelEditor.Name = "btnLevelEditor";
            this.btnLevelEditor.Size = new System.Drawing.Size(285, 48);
            this.btnLevelEditor.TabIndex = 1;
            this.btnLevelEditor.Text = "Level Editor";
            this.btnLevelEditor.UseVisualStyleBackColor = true;
            this.btnLevelEditor.Click += new System.EventHandler(this.btnLevelEditor_Click);
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(-2, 109);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(285, 48);
            this.btnOption.TabIndex = 2;
            this.btnOption.Text = "Optionen";
            this.btnOption.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(-2, 163);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(285, 48);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Beenden";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnLevelEditor);
            this.Controls.Add(this.btnNewGame);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnLevelEditor;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Button btnClose;
    }
}

