using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestOfBowling
{
    public class Game
    {
        private int score;
        private int[] throws = new int[21];
        private int currentThrow;

        public int Score
        {
            get { return score; }

        }

        public void Add(int pins)
        {
            throws[currentThrow++] = pins;
            score += pins;
        }

        internal object ScoreForFrame(int theFrame)
        {
            int ball = 0;
            int score = 0;
            for (int currentFrame = 0; currentFrame < theFrame; currentFrame++)
            {
                int firstThrow =  throws[ball++];
                int secondThrow = throws[ball++];
                int frameScore = firstThrow + secondThrow;

                //分瓶时需要知道后面一轮的第一投
                if(frameScore == 10)
                {
                    score += frameScore + throws[ball++];
                    
                }
                else
                    score += frameScore;

            }
            return score;
        }
    }
}
