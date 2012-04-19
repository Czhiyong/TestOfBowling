using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestOfBowling
{
    public class Frame
    {
        private int score;
        
        public int Score
        {
            get { return score; }
        }

        internal void Add(int pins)
        {
            score += pins;
        }
    }
}
