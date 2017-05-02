﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectlf6
{
    class Score
    {
        private int score;
        private List<int> gameScores;

        public Score()
        {
            this.score = 0;
            this.gameScores = new List<int>();
        }

        public void setScore(int score)
        {
            this.score = score;
        }

        public int getScore()
        {
            return this.score;
        }

        public void addScoreToScoreList(int score)
        {
            this.gameScores.Add(score);
        }

        public List<int> getScoreList()
        {
            return this.gameScores;
        }

        public int getTotalscore()
        {
            return this.gameScores.Count;
        }

        public int getMinScore()
        {
            int min = this.gameScores[0];
            for (int i = 0; i < this.gameScores.Count; i++)
            {
                if (this.gameScores[i] < min)
                    min = this.gameScores[i];
            }
            return min;
        }

        public int getMaxScore()
        {
            int max = this.gameScores[0];
            for (int i = 0; i < this.gameScores.Count; i++)
            {
                if (this.gameScores[i] > max)
                    max = this.gameScores[i];
            }
            return max;
        }

        public int incrementScore(int points)
        {
            this.score += points;
            return score;
        }

        public int decrementScore(int score)
        {
            this.score -= score;
            return score;
        }
    }
}
