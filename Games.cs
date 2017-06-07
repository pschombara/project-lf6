using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace minesHunter
{
    class Games
    {
        private List<string> gameList;
        private List<int> gameListLevelCount;

        /**
         * Class constructor Games
         */
        public Games()
        {
            this.gameList = new List<string>();
            this.gameListLevelCount = new List<int>();
            this.fillGameList();
        }

        /**
         * Fill game list load games from files
         */
        private void fillGameList()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Global.PATH_GAME_FOLDER);
            DirectoryInfo[] folders = directoryInfo.GetDirectories();

            for (int i = 0; i < folders.Length; i++)
            {
                FileInfo[] fileInfo = folders[i].GetFiles();

                this.gameList.Add(folders[i].Name);
                this.gameListLevelCount.Add(fileInfo.Length);
            }
        }

        /**
         * Return the number of games
         * 
         * @return int
         */
        public int getNumberOfGames()
        {
            return this.gameList.Count;
        }

        /**
         * Get name of game from position
         * 
         * @param int index position in list
         * 
         * @return string
         */
        public string getGameName(int index)
        {
            if (index < this.gameList.Count)
            {
                return this.gameList.ElementAt(index);
            }
            else
            {
                return "";
            }
        }

        /**
         * Get number of game levels from position
         * 
         * @param int index position in list
         * 
         * @return int
         */
        public int getNumberOfLevelForGame(int index)
        {
            if (index < this.gameListLevelCount.Count)
            {
                return this.gameListLevelCount.ElementAt(index);
            }
            else
            {
                return 0;
            }
        }

        /**
         * Get list of games
         * 
         * @return List<string>
         */
        public List<string> getGameList()
        {
            return this.gameList;
        }
    }
}
