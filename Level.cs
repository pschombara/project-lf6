using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public void loadLevelFromFile()
        {
            //ToDo
        }

        public bool saveLevelToFile()
        {
            //ToDo
            return true;
        }

        public Field getFieldAtLocation(Location location)
        {
            Field field = new Field(this.map[location.getX(), location.getY()]);
            return field;
        }

        public List<Location> getWayLocationsForPlayer(int player)
        {
            //ToDo
            return null;
        }

        public bool isLocationFreeForWay(Location location)
        {
            //ToDo
            return true;
        }

        public void setWayAtLocation(Location location, int player)
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
            this.map[location.getX(), location.getY()] = field.getFieldType();
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

        private bool isNameTaken()
        {
            //ToDo
            return true;
        }

        private bool isMapComplete()
        {
            //ToDo
            return true;
        }
    }
}
