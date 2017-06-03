using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectlf6
{
    class HighscoreItem
    {
        private string player;
        private string game;
        private int score;
        private int levels;
        private int rounds;

        public HighscoreItem(string player, string game, int score, int levels, int rounds)
        {
            this.player = player;
            this.game = game;
            this.score = score;
            this.levels = levels;
            this.rounds = rounds;
        }

        public string getPlayer()
        {
            return this.player;
        }

        public string getGame()
        {
            return this.game;
        }

        public int getScore()
        {
            return this.score;
        }

        public int getLevels()
        {
            return this.levels;
        }

        public int getRounds()
        {
            return this.rounds;
        }
    }
}
