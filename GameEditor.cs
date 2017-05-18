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
        #region Konstruktor
        public GameEditor()
		{
			InitializeComponent();

            //refreshDataGridView();
		}
        #endregion

        #region Activated Event
        private void GameEditor_Activated(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
        #endregion

        #region Buttons
        private void btnNewGame_Click(object sender, EventArgs e)
		{
			string path = Global.PATH_GAME_FOLDER + txtNewGameName.Text;
            Game g = new Game(txtNewGameName.Text);
            if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
				LevelEditorMain levelEditorMain = new LevelEditorMain(path);
				levelEditorMain.ShowDialog();
			}
			else
				MessageBox.Show("Spielname existiert bereits!", "Fehler: Spielname!");

            g.saveToFile();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Hide();
		}

        private void btnStartLevelEditor_Click(object sender, EventArgs e)
        {
            LevelEditorMain levelEditorMain = new LevelEditorMain();
            levelEditorMain.ShowDialog();
        }
        #endregion

        #region DataGridView Events
        private void dataGridViewGames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
            if (dataGridViewGames.SelectedCells.Count > 0)
            {
                LevelEditorMain levelEditorMain = new LevelEditorMain(dataGridViewGames.SelectedCells[0].Value.ToString());
                levelEditorMain.ShowDialog();
            }
            else
                MessageBox.Show("Zuerst ein Spiel auswählen bzw. neu erstellen", "Fehler: Kein Spiel ausgewählt");
		}
        #endregion

        #region Kontextmenü
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            dataGridViewGames_CellDoubleClick(null, null);
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
		{
            if (dataGridViewGames.SelectedCells.Count > 0)
            {
                Directory.Delete(Global.PATH_GAME_FOLDER + dataGridViewGames.SelectedCells[0].Value, true);
                dataGridViewGames.Rows.Remove(dataGridViewGames.SelectedRows[0]);
                dataGridViewGames.ClearSelection();
            }
            else
                MessageBox.Show("Zuerst ein Spiel auswählen bzw. neu erstellen", "Fehler: Kein Spiel ausgewählt");
        }
        #endregion

        private void refreshDataGridView()
        {
            dataGridViewGames.Rows.Clear();
            Games games = new Games();
           
            //DataGridView füllen
            for (int i = 0; i < games.getNumberOfGames(); i++)
            {
                dataGridViewGames.Rows.Add(games.getGameName(i), games.getNumberOfLevelForGame(i));
            }

            txtNewGameName.Text = string.Empty;
        }
    }
}
