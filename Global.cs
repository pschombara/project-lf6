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

		public static string ToXmlGamePath(this string str)
		{
			return PATH_GAME_FOLDER + str + ".xml";
		}

		public static string ToXmlPlayerPath(this string str)
		{
			return PATH_PLAYER_FOLDER + "player_" + str + ".xml";
		}

		public static string ToXmlSavePath(this string str)
		{
			return PATH_SAVE_FOLDER + str + ".xml";
		}
	}
}
