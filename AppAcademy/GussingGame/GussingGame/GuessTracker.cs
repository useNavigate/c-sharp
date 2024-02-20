using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    public class GuessTracker
    {
        private Random _rng = new Random();

        public int MaxNumber { get; set; }
        public int NumberToGuess { get; set; }
        public int GuessCount { get; set; }

        public virtual void GenerateRandom(int max)
        {
            MaxNumber = max;
            NumberToGuess = _rng.Next(1, max + 1);
        }
    }
}
