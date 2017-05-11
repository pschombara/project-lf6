using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectlf6
{
	public static class Global
	{
		public static string MAIN_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\projectlf6\\";
		public static string PATH_GAME_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\projectlf6\\games\\";
		public static string PATH_PLAYER_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\projectlf6\\player\\";
		public static string PATH_SAVE_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\projectlf6\\save\\";

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
