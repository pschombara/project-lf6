using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			//TODO: implement methodbody
		}

		public bool saveToFile()
		{
			//TODO: implement methodbody
			return true;
		}

		#endregion Methods
	}
}
