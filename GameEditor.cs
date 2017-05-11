using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace projectlf6
{
    public partial class GameEditor : Form
    {
        private string path;

        public GameEditor()
        {
            InitializeComponent();

            string[] folders = Directory.GetDirectories(Global.PATH_GAME_FOLDER);
            //DataGridView füllen
            for (int i = 0; i < folders.Length; i++)
            {
                string[] num = Directory.GetFiles(this.path + "\\" + folders[i]);
                dataGridViewGames.Rows.Add(folders[i], num.Length);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // TODO check if game name already exist
            // TODO create folder
            // start level editor
            string path = this.path + "\\" + txtNewGameName.Text;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                LevelEditorMain levelEditorMain = new LevelEditorMain(path);
                levelEditorMain.ShowDialog();
            }
            else
                MessageBox.Show("Spielname existiert bereits!", "Fehler: Spielname!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dataGridViewGames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
