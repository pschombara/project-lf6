using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesHunter
{
	public static class Global
	{
		public static string MAIN_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\minesHunter\\";
		public static string PATH_GAME_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\minesHunter\\games\\";
		public static string PATH_PLAYER_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\minesHunter\\player\\";
		public static string PATH_SAVE_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\minesHunter\\save\\";

        /**
         * Return path to game folder with name of xml
         * 
         * @param string str xml file name
         */
		public static string ToXmlGamePath(this string str)
		{
			return PATH_GAME_FOLDER + str + ".xml";
		}

        /**
         * Return path to player folder with name of xml
         * 
         * @param string str xml file name
         */
        public static string ToXmlPlayerPath(this string str)
		{
			return PATH_PLAYER_FOLDER + "player_" + str + ".xml";
		}

        /**
         * Return path to save folder with name of xml
         * 
         * @param string str xml file name
         */
        public static string ToXmlSavePath(this string str)
		{
			return PATH_SAVE_FOLDER + str + ".xml";
		}
	}
}
