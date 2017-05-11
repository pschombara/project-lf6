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

			DirectoryInfo directoryInfo = new DirectoryInfo(Global.PATH_GAME_FOLDER);
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
			string path = Global.PATH_GAME_FOLDER + "\\" + txtNewGameName.Text;
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
			LevelEditorMain levelEditorMain = new LevelEditorMain(dataGridViewGames.SelectedCells[0].Value.ToString());
			levelEditorMain.ShowDialog();
		}

		private void tsmiDelete_Click(object sender, EventArgs e)
		{
			Directory.Delete(Global.PATH_GAME_FOLDER + dataGridViewGames.SelectedCells[0].Value, true);

			if (dataGridViewGames.SelectedRows.Count > 0)
			{
				dataGridViewGames.Rows.RemoveAt(dataGridViewGames.SelectedRows[0].Index);
			}
			else if (dataGridViewGames.SelectedCells.Count > 0)
			{
				dataGridViewGames.Rows.RemoveAt(dataGridViewGames.SelectedCells[0].RowIndex);
			}
			dataGridViewGames.ClearSelection();
		}

		private void btnStartLevelEditor_Click(object sender, EventArgs e)
		{
			LevelEditorMain levelEditorMain = new LevelEditorMain();
			levelEditorMain.ShowDialog();
		}
	}
}
