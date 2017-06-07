using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace minesHunter
{
	public class Game
    {
		#region Memberarea

		private List<Level> levels;
		private int activeLevel;
		private string name;

		#endregion Memberarea

		#region Constructors

        /**
         * Class constructor Game
         * 
         * @param string name name of game
         */
		public Game(string name)
		{
			this.name = name;
			this.levels = new List<Level>();
			this.activeLevel = 0;
		}

		#endregion Constructors

		#region Getter/Setter

        /**
         * Return list of levels
         * 
         * @return List<Level>
         */
		public List<Level> getLevels()
		{
			return this.levels;
		}

        /**
         * Get active level
         * 
         * @return Level
         */
		public Level getActiveLevel()
		{
			return this.levels[activeLevel];
		}

        /**
         * Get game name
         * 
         * @return string
         */
		public string getName()
		{
			return this.name;
		}

		#endregion Getter/Setter

		#region Methods

        /**
         * Change the active level, increase active level and return level
         * 
         * @return Level
         */
		public Level changeActiveLevel()
		{
			this.activeLevel++;
			return getActiveLevel();
		}

        /**
         * Check if game has next level
         * 
         * @return bool
         */
		public bool hasNext()
		{
			return (activeLevel + 1 >= levels.Count) ? false : true;
		}

        /**
         * load class from file
         */
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
				level.loadLevelFromFile(Global.PATH_GAME_FOLDER + this.name + "\\" + levelName);
				this.levels.Add(level);
			}
		}

        /**
         * Save class to xml file
         */
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
				MessageBox.Show("Fehler beim Speichern !", "Spiel konnte nicht gespeichert werden. " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
			}

			return retvar;
		}

        /**
         * Serialize class to xml element
         * 
         * @return XmlElement
         */
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