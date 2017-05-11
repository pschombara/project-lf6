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
        public GameEditor()
        {
            InitializeComponent();

            DirectoryInfo directoryInfo = new DirectoryInfo(Game.SAVE_PATH);
            DirectoryInfo[] folders = directoryInfo.GetDirectories();
            //DataGridView füllen
            for (int i = 0; i < folders.Length; i++)
            {
                FileInfo[] fileInfo = folders[i].GetFiles();
                dataGridViewGames.Rows.Add(folders[i].Name, fileInfo.Length);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            string path = Game.SAVE_PATH + "\\" + txtNewGameName.Text;
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
