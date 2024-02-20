using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    public class GuessingGameWorkflow
    {
        private GuessTracker _tracker;
        private ConsoleIO _io;
        public GuessingGameWorkflow(ConsoleIO io, GuessTracker tracker)
        {
            _io = io;
            _tracker = tracker;
        }

        public GuessingGameWorkflow()
        {
            _io = new ConsoleIO();
            _tracker = new GuessTracker();
        }
        public void Run()
        {
            // Get the max range from the user
            var maxRange = _io.GetMaxRange();
            // Generate a random number
            _tracker.GenerateRandom(maxRange);
            // Loop until the user guesses the number

            bool isOver = false;

            while (!isOver)
            {

                isOver = EvaluateGuess();
            }



        }

        private bool EvaluateGuess()
        {

            // Get a guess from the user

            var userGuess = _io.GetGuess(_tracker.MaxNumber);
            // Increment the guess count
            _tracker.GuessCount++;
            // Evaluate the guess

            if (_tracker.NumberToGuess == userGuess)
            {
                _io.DisplayMessage($"Your guess is correct It was {_tracker.NumberToGuess}! You WON!\n you took {_tracker.GuessCount} guesses");
                return true;
            }
            if (userGuess > _tracker.NumberToGuess)
            {
                _io.DisplayMessage($"Try to Guess lower number!");
            }
            else
            {
                _io.DisplayMessage($"Try to Guess higher number!");
            }
            // If the guess is correct, tell the user they won and how many guesses it took
            // return true to indicate that the user has guessed the number
            // Guess is too low, tell the user to guess higher
            // Guess is too high, tell the user to guess lower
            // return false to indicate that the user has not guessed the number yet
            return false;
        }
    }
}
