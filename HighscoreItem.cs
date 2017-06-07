using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesHunter
{
    class HighscoreItem
    {
        private string player;
        private string game;
        private int score;
        private int levels;
        private int rounds;

        /**
         * Class constructor HighscoreItem
         * 
         * @param string player player name
         * @param string game   game name
         * @param int    score  player total score
         * @param int    levels levels of game
         * @param int    rounds rounds per level 
         */
        public HighscoreItem(string player, string game, int score, int levels, int rounds)
        {
            this.player = player;
            this.game = game;
            this.score = score;
            this.levels = levels;
            this.rounds = rounds;
        }

        /**
         * Get player name
         * 
         * @return string
         */
        public string getPlayer()
        {
            return this.player;
        }

        /**
         * Get game name
         * 
         * @return string
         */
        public string getGame()
        {
            return this.game;
        }

        /**
         * Get score
         * 
         * @return int
         */
        public int getScore()
        {
            return this.score;
        }

        /**
         * Get levels
         * 
         * @return int
         */
        public int getLevels()
        {
            return this.levels;
        }

        /**
         * Get rounds
         * 
         * @return int
         */
        public int getRounds()
        {
            return this.rounds;
        }
    }
}
