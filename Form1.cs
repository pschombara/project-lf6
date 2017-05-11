using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace projectlf6
{
	public partial class Form1 : Form
	{
		private string MAIN_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\projectlf6\\";

		public Form1()
		{
			InitializeComponent();
			CreateFolderTree();
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
			Form gameEditor = new GameEditor();
			gameEditor.ShowDialog();

			//TODO nachfolgendes entfernen wenn, game editor fähig ist level editor aufzurufen
			Form LevelEditorMain = new LevelEditorMain();
			LevelEditorMain.ShowDialog();
		}

		private void CreateFolderTree()
		{
			if (!Directory.Exists(MAIN_PATH))
			{
				Directory.CreateDirectory(MAIN_PATH);
			}

			if (!Directory.Exists(MAIN_PATH + "games\\"))
			{
				Directory.CreateDirectory(MAIN_PATH + "games\\");
			}

			if (!Directory.Exists(MAIN_PATH + "player\\"))
			{
				Directory.CreateDirectory(MAIN_PATH + "player\\");
			}

			if (!Directory.Exists(MAIN_PATH + "save\\"))
			{
				Directory.CreateDirectory(MAIN_PATH + "save\\");
			}
		}
	}
}