using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectlf6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Form newGame = new newGame();
            newGame.ShowDialog();
        }

        private void btnLevelEditor_Click(object sender, EventArgs e)
        {
            Form LevelEditorMain = new LevelEditorMain();
            LevelEditorMain.ShowDialog();
        }
    }
}
