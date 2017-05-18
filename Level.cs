using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace projectlf6
{
	public class Level
	{
		private int[,] map;
		private int[,] ways;
		private Location startOne;
		private Location startTwo;
		private string name;

		public Level(string name)
		{
			this.name = name;
			this.map = new int[32,32];
			this.ways = new int[32,32];
			this.startOne = new Location();
			this.startTwo = new Location();
		}
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

		public bool saveLevelToFile()
		{
			//ToDo
			return true;
		}

		public Field getFieldAtLocation(Location location)
		{
			Field field = new Field(this.map[location.getX(),location.getY()]);
			return field;
		}

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

		public bool isLocationFreeForWay(Location location)
		{
			//ToDo
			return true;
		}

		public void setWayAtLocation(Location location, Player player)
		{
			//ToDo
		}

		public List<Location> getStartLocations()
		{
			List<Location> locations = new List<Location>();
			locations.Add(startOne);
			locations.Add(startTwo);
			return locations;
		}

		public void setFieldAtLocation(Location location, Field field)
		{
			this.map[location.getX(),location.getY()] = field.getFieldType();
		}

		public void setStartLocationForPlayer(Location startLocation, int player)
		{
			if (player == 1)
				startOne = startLocation;
			else if (player == 2)
				startTwo = startLocation;
		}

		public void setName(string name)
		{
			this.name = name;
		}

		public string getName()
		{
			return this.name;
		}

		public int[,] getMap()
		{
			return this.map;
		}

		private bool isNameTaken()
		{
			//ToDo
			return true;
		}
	}
}