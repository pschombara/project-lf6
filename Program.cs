using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectlf6
{
	static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new Form1());

			//TestForGameWindow
			Player p1 = new Player();
			p1.setWayColor(Field.WAY_RED);
			p1.setName("LoLSpieler");
			p1.setNumber(1);
			p1.setOrientation(2);
			p1.setSkin(Field.FIELD_Player_1);

			Player p2 = new Player();
			p2.setWayColor(Field.WAY_BLUE);
			p2.setName("LoLGamer");
			p2.setNumber(2);
			p2.setOrientation(2);
			p2.setSkin(Field.FIELD_Player_2);

			Game testgame = new Game("LOL");
			testgame.loadFromFile();

			Application.Run(new GameMain(p1, p2, testgame));
		}
	}
}
