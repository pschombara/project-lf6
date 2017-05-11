using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace projectlf6
{
	public class Game
    {
		#region Memberarea

		private List<Level> levels;
		private int activeLevel;
		private string name;

		#endregion Memberarea

		#region Constructors

		public Game(string name)
		{
			this.name = name;
			this.levels = new List<Level>();
			this.activeLevel = -1;
		}

		#endregion Constructors

		#region Getter/Setter

		public List<Level> getLevels()
		{
			return this.levels;
		}

		public Level getActiveLevel()
		{
			return this.levels[activeLevel];
		}

		public string getName()
		{
			return this.name;
		}

		public void setLevels(List<Level> newLevels)
		{
			this.levels = newLevels;
		}

		public void setName(string newName)
		{
			this.name = newName;
		}

		#endregion Getter/Setter

		#region Methods

		public Level changeActiveLevel()
		{
			this.activeLevel++;
			return getActiveLevel();
		}

		public void loadFromFile()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(this.name.ToXmlGamePath());
			XmlNodeList nodeName = doc.GetElementsByTagName("name");

			if (nodeName.Count == 1)
			{
				this.name = nodeName.Item(0).InnerText;
			}

			XmlNodeList activeLevel = doc.GetElementsByTagName("activeLevel");

			if (activeLevel.Count == 1)
			{
				this.activeLevel = Convert.ToInt16(activeLevel.Item(0).InnerText);
			}

			XmlNodeList nodeLevels = doc.GetElementsByTagName("level");

			for (int i = 0; i < nodeLevels.Count; i++)
			{
				string levelName = nodeLevels.Item(i).InnerText;
				Level level = new Level(levelName);
				level.loadLevelFromFile();
				this.levels.Add(level);
			}
		}

		public bool saveToFile()
		{
			bool retvar = false;
			try
			{
				Directory.CreateDirectory(Global.PATH_GAME_FOLDER);

				XmlDocument doc = new XmlDocument();

				doc.AppendChild(doc.ImportNode(this.serialize(), true));

				doc.Save(this.name.ToXmlGamePath());

				retvar = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Fehler beim Speichern !", "Spiel konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
			}

			return retvar;
		}

		public XmlElement serialize()
		{
			XmlDocument document = new XmlDocument();
			XmlElement game = document.CreateElement("game");
			XmlElement name = document.CreateElement("name");
			XmlElement activeLevel = document.CreateElement("activeLevel");
			XmlElement levels = document.CreateElement("levels");
			name.InnerText = this.name.ToString();
			activeLevel.InnerText = this.activeLevel.ToString();

			game.AppendChild(name);
			game.AppendChild(activeLevel);

			FileInfo[] files = new DirectoryInfo(Global.PATH_GAME_FOLDER + this.name).GetFiles();
			foreach (FileInfo fi in files)
			{
				XmlElement level = document.CreateElement("level");
				level.InnerText = fi.Name;
				levels.AppendChild(level);
			}

			game.AppendChild(levels);

			return game;
		}

		#endregion Methods
	}
}