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

        public Games()
        {
            this.gameList = new List<string>();
            this.gameListLevelCount = new List<int>();
            this.fillGameList();
        }

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

        public int getNumberOfGames()
        {
            return this.gameList.Count;
        }

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

        public List<string> getGameList()
        {
            return this.gameList;
        }
    }
}
