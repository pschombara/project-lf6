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

namespace minesHunter
{
	public partial class GameEditor : Form
	{
        #region Konstruktor
        /**
         * Class constructor GameEditor
         */
        public GameEditor()
		{
			InitializeComponent();
		}
        #endregion

        #region Activated Event
        /**
         * Refresh data gried view if game editor activated
         *
         * @param object   sender sender
         * @param EventArg e     event arguments
         */
        private void GameEditor_Activated(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
        #endregion

        #region Buttons
        /**
         * Event handler button new game
         *   
         * @param object   sender sender
         * @param EventArg e     event arguments
         */
        private void btnNewGame_Click(object sender, EventArgs e)
		{
			string path = Global.PATH_GAME_FOLDER + txtNewGameName.Text;
            Game g = new Game(txtNewGameName.Text);
            if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
                g.saveToFile();
                LevelEditorMain levelEditorMain = new LevelEditorMain(path);
				levelEditorMain.ShowDialog();
			}
			else
				MessageBox.Show("Spielname existiert bereits!", "Fehler: Spielname!");

            //g.saveToFile();
		}

        /**
         * Event handler button click back
         * 
         * @param object   sender sender
         * @param EventArg e     event arguments
         */
        private void btnBack_Click(object sender, EventArgs e)
		{
            Close();
		}

        /**
         * Event handler button start level editor
         * 
         * @param object   sender sender
         * @param EventArg e     event arguments 
         */
        private void btnStartLevelEditor_Click(object sender, EventArgs e)
        {
            LevelEditorMain levelEditorMain = new LevelEditorMain();
            levelEditorMain.ShowDialog();
        }
        #endregion

        #region DataGridView Events
        /**
         * Open game on double click
         * 
         * @param object                    sender sender
         * @param DataGridViewCellEventArgs e      event arguments
         */
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

        /**
         * Event handler key down data grid view
         * 
         * @param object   sender sender
         * @param EventArg e      event arguments 
         */
        private void dataGridViewGames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dataGridViewGames_CellDoubleClick(null, null);
            else if (e.KeyCode == Keys.Delete)
                tsmiDelete_Click(null, null);
        }
        #endregion

        #region Kontextmenü
        /**
         * Event handler contextmenu data grid view open game
         * 
         * @param object   sender sender
         * @param EventArg e      event arguments 
         */
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            dataGridViewGames_CellDoubleClick(null, null);
        }

        /**
         * Event handler contextmenu data grid view delete game
         * 
         * @param object   sender sender
         * @param EventArg e      event arguments 
         */
        private void tsmiDelete_Click(object sender, EventArgs e)
		{
            if (dataGridViewGames.SelectedCells.Count > 0)
            {
                File.Delete(Global.PATH_GAME_FOLDER + dataGridViewGames.SelectedCells[0].Value + ".xml");
                Directory.Delete(Global.PATH_GAME_FOLDER + dataGridViewGames.SelectedCells[0].Value, true);
                dataGridViewGames.Rows.Remove(dataGridViewGames.SelectedRows[0]);
                dataGridViewGames.ClearSelection();
            }
            else
                MessageBox.Show("Zuerst ein Spiel auswählen bzw. neu erstellen", "Fehler: Kein Spiel ausgewählt");
        }
        #endregion

        /**
         * Fill data grid view with games
         */
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

        /**
         * Event handler press enter on new game name text field perform click on button
         *
         * @param object      sender sender
         * @param KeyEventArg e      event arguments 
         */
        private void txtNewGameName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnNewGame.PerformClick();
        }

        /**
         * Open global help
         * 
         * @param object      sender sender
         * @param KeyEventArg e      event arguments 
         */
        private void GameEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Form Help = new Help();
                Help.ShowDialog();
            }
        }
    }
}
