using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace minesHunter
{
	public class Level
	{
		private int[,] map;
		private int[,] ways;
		private Location startOne;
		private Location startTwo;
		private string name;

        /**
         * Class constructor
         * 
         * @param string name level name
         */
		public Level(string name)
		{
			this.name = name;
			this.map = new int[32,32];
			this.ways = new int[32,32];
			this.startOne = new Location();
			this.startTwo = new Location();
		}

        /**
         * @param string strSource
         * @param string strStart
         * @param string strEnd
         * 
         * @return string
         */
		private static string getBetween(string strSource, string strStart, string strEnd)
		{
			int Start, End;
			if (strSource.Contains(strStart) && strSource.Contains(strEnd))
			{
				Start = strSource.IndexOf(strStart, 0) + strStart.Length;
				End = strSource.IndexOf(strEnd, Start);
				return strSource.Substring(Start, End - Start);
			}
			else
			{
				return "";
			}
		}

        /**
         * Load level from file
         * 
         * @param string file file name
         */
		public void loadLevelFromFile(string file)
		{
			String datei = File.ReadAllText(file);
			startOne.setX(Convert.ToInt16(getBetween(datei, "Player_1_X=", "\r")));
			startOne.setY(Convert.ToInt16(getBetween(datei, "Player_1_Y=", "\r")));
			startTwo.setX(Convert.ToInt16(getBetween(datei, "Player_2_X=", "\r")));
			startTwo.setY(Convert.ToInt16(getBetween(datei, "Player_2_Y=", "\r")));

			datei = getBetween(datei, "<Map>", "</Map>");
			string[] str = datei.Split(';');
			//Level
			for (int x = 0; x < 32; x++)
			{
				for (int y = 0; y < 32; y++)
				{
					map[x,y] = Convert.ToInt16(str[(32 * x) + y]);
				}
			}
		}

        /**
         * Get field at location
         * 
         * @param Location location location
         * 
         * @return Field
         */
		public Field getFieldAtLocation(Location location)
		{
			Field field = new Field(this.map[location.getX(),location.getY()]);
			return field;
		}

        /**
         * Get way location for player
         * 
         * @param Player player player
         * 
         * @return List<Location>
         */
		public List<Location> getWayLocationsForPlayer(Player player)
		{
			List<Location> wayPoints = new List<Location>();
			for (int x = 0; x < 32; x++)
			{
				for (int y = 0; y < 32; y++)
				{
					if (ways[x,y] == player.getNumber())
					{
						wayPoints.Add(new Location(x, y));
					}
				}
			}
			return wayPoints;
		}

        /**
         * Get start location for player
         * 
         * @return List<Location>
         */
		public List<Location> getStartLocations()
		{
			List<Location> locations = new List<Location>();
			locations.Add(startOne);
			locations.Add(startTwo);
			return locations;
		}

        /**
         * Set field type on location
         * 
         * @param Location location location
         * @param Field    field    field type
         */
		public void setFieldAtLocation(Location location, Field field)
		{
			this.map[location.getX(),location.getY()] = field.getFieldType();
		}

        /**
         * Set start location for player
         * 
         * @param Location startLocation start location
         * @param int      player        player 1 or 2
         */
		public void setStartLocationForPlayer(Location startLocation, int player)
		{
			if (player == 1)
				startOne = startLocation;
			else if (player == 2)
				startTwo = startLocation;
		}

        /**
         * Set level name
         * 
         * @param string name level name
         */
		public void setName(string name)
		{
			this.name = name;
		}

        /**
         * Get level name
         * 
         * @return string
         */
		public string getName()
		{
			return this.name;
		}

        /**
         * Get level map
         * 
         * @return int[,]
         */
		public int[,] getMap()
		{
			return this.map;
		}
	}
}