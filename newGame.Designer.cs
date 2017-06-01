namespace projectlf6
{
    partial class newGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPlayerTwoFigure = new System.Windows.Forms.PictureBox();
            this.btnPlayerOneFigureBack = new System.Windows.Forms.Button();
            this.btnPlayerOneFigureForward = new System.Windows.Forms.Button();
            this.btnPlayerTwoFigureForward = new System.Windows.Forms.Button();
            this.btnPlayerTwoFigureBack = new System.Windows.Forms.Button();
            this.cbPlayerOneProfile = new System.Windows.Forms.ComboBox();
            this.cbPlayerTwoProfile = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGames = new System.Windows.Forms.ComboBox();
            this.cbPlayerOneColor = new System.Windows.Forms.ComboBox();
            this.cbPlayerTwoColor = new System.Windows.Forms.ComboBox();
            this.pbPlayerOneFigure = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudGameRounds = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerTwoFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerOneFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGameRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spieler 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(597, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spieler 2";
            // 
            // pbPlayerTwoFigure
            // 
            this.pbPlayerTwoFigure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayerTwoFigure.Location = new System.Drawing.Point(577, 103);
            this.pbPlayerTwoFigure.Name = "pbPlayerTwoFigure";
            this.pbPlayerTwoFigure.Size = new System.Drawing.Size(100, 111);
            this.pbPlayerTwoFigure.TabIndex = 5;
            this.pbPlayerTwoFigure.TabStop = false;
            // 
            // btnPlayerOneFigureBack
            // 
            this.btnPlayerOneFigureBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerOneFigureBack.Location = new System.Drawing.Point(12, 220);
            this.btnPlayerOneFigureBack.Name = "btnPlayerOneFigureBack";
            this.btnPlayerOneFigureBack.Size = new System.Drawing.Size(46, 29);
            this.btnPlayerOneFigureBack.TabIndex = 2;
            this.btnPlayerOneFigureBack.Text = "<<";
            this.btnPlayerOneFigureBack.UseVisualStyleBackColor = true;
            this.btnPlayerOneFigureBack.Click += new System.EventHandler(this.btnPlayerOneFigureBack_Click);
            // 
            // btnPlayerOneFigureForward
            // 
            this.btnPlayerOneFigureForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerOneFigureForward.Location = new System.Drawing.Point(66, 220);
            this.btnPlayerOneFigureForward.Name = "btnPlayerOneFigureForward";
            this.btnPlayerOneFigureForward.Size = new System.Drawing.Size(46, 29);
            this.btnPlayerOneFigureForward.TabIndex = 3;
            this.btnPlayerOneFigureForward.Text = ">>";
            this.btnPlayerOneFigureForward.UseVisualStyleBackColor = true;
            this.btnPlayerOneFigureForward.Click += new System.EventHandler(this.btnPlayerOneFigureForward_Click);
            // 
            // btnPlayerTwoFigureForward
            // 
            this.btnPlayerTwoFigureForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerTwoFigureForward.Location = new System.Drawing.Point(631, 220);
            this.btnPlayerTwoFigureForward.Name = "btnPlayerTwoFigureForward";
            this.btnPlayerTwoFigureForward.Size = new System.Drawing.Size(46, 29);
            this.btnPlayerTwoFigureForward.TabIndex = 7;
            this.btnPlayerTwoFigureForward.Text = ">>";
            this.btnPlayerTwoFigureForward.UseVisualStyleBackColor = true;
            this.btnPlayerTwoFigureForward.Click += new System.EventHandler(this.btnPlayerTwoFigureForward_Click);
            // 
            // btnPlayerTwoFigureBack
            // 
            this.btnPlayerTwoFigureBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerTwoFigureBack.Location = new System.Drawing.Point(577, 220);
            this.btnPlayerTwoFigureBack.Name = "btnPlayerTwoFigureBack";
            this.btnPlayerTwoFigureBack.Size = new System.Drawing.Size(46, 29);
            this.btnPlayerTwoFigureBack.TabIndex = 6;
            this.btnPlayerTwoFigureBack.Text = "<<";
            this.btnPlayerTwoFigureBack.UseVisualStyleBackColor = true;
            this.btnPlayerTwoFigureBack.Click += new System.EventHandler(this.btnPlayerTwoFigureBack_Click);
            // 
            // cbPlayerOneProfile
            // 
            this.cbPlayerOneProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlayerOneProfile.FormattingEnabled = true;
            this.cbPlayerOneProfile.Items.AddRange(new object[] {
            ""});
            this.cbPlayerOneProfile.Location = new System.Drawing.Point(12, 44);
            this.cbPlayerOneProfile.Name = "cbPlayerOneProfile";
            this.cbPlayerOneProfile.Size = new System.Drawing.Size(121, 28);
            this.cbPlayerOneProfile.TabIndex = 1;
            this.cbPlayerOneProfile.SelectedIndexChanged += new System.EventHandler(this.cbPlayerOneProfile_SelectedIndexChanged);
            // 
            // cbPlayerTwoProfile
            // 
            this.cbPlayerTwoProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlayerTwoProfile.FormattingEnabled = true;
            this.cbPlayerTwoProfile.Location = new System.Drawing.Point(556, 44);
            this.cbPlayerTwoProfile.Name = "cbPlayerTwoProfile";
            this.cbPlayerTwoProfile.Size = new System.Drawing.Size(121, 28);
            this.cbPlayerTwoProfile.TabIndex = 5;
            this.cbPlayerTwoProfile.SelectedIndexChanged += new System.EventHandler(this.cbPlayerTwoProfile_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name/Profile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Figur auswählen";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(577, 319);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(100, 40);
            this.btnStartGame.TabIndex = 11;
            this.btnStartGame.Text = "Starten";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 319);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Spiel auswählen";
            // 
            // cbGames
            // 
            this.cbGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGames.FormattingEnabled = true;
            this.cbGames.Location = new System.Drawing.Point(291, 167);
            this.cbGames.Name = "cbGames";
            this.cbGames.Size = new System.Drawing.Size(121, 28);
            this.cbGames.TabIndex = 10;
            // 
            // cbPlayerOneColor
            // 
            this.cbPlayerOneColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayerOneColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlayerOneColor.FormattingEnabled = true;
            this.cbPlayerOneColor.Items.AddRange(new object[] {
            "Blau",
            "Dunkel Grau",
            "Hell Blau",
            "Grün",
            "Orange",
            "Pink",
            "Lila",
            "Rot",
            "Gelb"});
            this.cbPlayerOneColor.Location = new System.Drawing.Point(12, 270);
            this.cbPlayerOneColor.Name = "cbPlayerOneColor";
            this.cbPlayerOneColor.Size = new System.Drawing.Size(121, 28);
            this.cbPlayerOneColor.TabIndex = 4;
            this.cbPlayerOneColor.SelectedIndexChanged += new System.EventHandler(this.cbPlayerOneColor_SelectedIndexChanged);
            // 
            // cbPlayerTwoColor
            // 
            this.cbPlayerTwoColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayerTwoColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlayerTwoColor.FormattingEnabled = true;
            this.cbPlayerTwoColor.Items.AddRange(new object[] {
            "Blau",
            "Dunkel Grau",
            "Hell Blau",
            "Grün",
            "Orange",
            "Pink",
            "Lila",
            "Rot",
            "Gelb"});
            this.cbPlayerTwoColor.Location = new System.Drawing.Point(556, 270);
            this.cbPlayerTwoColor.Name = "cbPlayerTwoColor";
            this.cbPlayerTwoColor.Size = new System.Drawing.Size(121, 28);
            this.cbPlayerTwoColor.TabIndex = 8;
            this.cbPlayerTwoColor.SelectedIndexChanged += new System.EventHandler(this.cbPlayerTwoColor_SelectedIndexChanged);
            // 
            // pbPlayerOneFigure
            // 
            this.pbPlayerOneFigure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayerOneFigure.Location = new System.Drawing.Point(12, 103);
            this.pbPlayerOneFigure.Name = "pbPlayerOneFigure";
            this.pbPlayerOneFigure.Size = new System.Drawing.Size(100, 111);
            this.pbPlayerOneFigure.TabIndex = 4;
            this.pbPlayerOneFigure.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Anzahl Spielrunden";
            // 
            // nudGameRounds
            // 
            this.nudGameRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGameRounds.Location = new System.Drawing.Point(293, 104);
            this.nudGameRounds.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudGameRounds.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGameRounds.Name = "nudGameRounds";
            this.nudGameRounds.ReadOnly = true;
            this.nudGameRounds.Size = new System.Drawing.Size(118, 26);
            this.nudGameRounds.TabIndex = 9;
            this.nudGameRounds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Wegfarbe auswählen";
            // 
            // newGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 369);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudGameRounds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPlayerTwoColor);
            this.Controls.Add(this.cbPlayerOneColor);
            this.Controls.Add(this.cbGames);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPlayerTwoProfile);
            this.Controls.Add(this.cbPlayerOneProfile);
            this.Controls.Add(this.btnPlayerTwoFigureForward);
            this.Controls.Add(this.btnPlayerTwoFigureBack);
            this.Controls.Add(this.btnPlayerOneFigureForward);
            this.Controls.Add(this.btnPlayerOneFigureBack);
            this.Controls.Add(this.pbPlayerTwoFigure);
            this.Controls.Add(this.pbPlayerOneFigure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "newGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neues Spiel";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerTwoFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerOneFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGameRounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPlayerTwoFigure;
        private System.Windows.Forms.Button btnPlayerOneFigureBack;
        private System.Windows.Forms.Button btnPlayerOneFigureForward;
        private System.Windows.Forms.Button btnPlayerTwoFigureForward;
        private System.Windows.Forms.Button btnPlayerTwoFigureBack;
        private System.Windows.Forms.ComboBox cbPlayerOneProfile;
        private System.Windows.Forms.ComboBox cbPlayerTwoProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGames;
        private System.Windows.Forms.ComboBox cbPlayerOneColor;
        private System.Windows.Forms.ComboBox cbPlayerTwoColor;
        private System.Windows.Forms.PictureBox pbPlayerOneFigure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudGameRounds;
        private System.Windows.Forms.Label label7;
    }
}