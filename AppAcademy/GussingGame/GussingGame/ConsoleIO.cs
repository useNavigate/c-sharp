using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    public class ConsoleIO
    {
        public int GetMaxRange()
        {
            // loop until we get a valid number
            do
            {
                Console.WriteLine("Please input a number for the max range");
                int userNumber;
                bool userInput = int.TryParse(Console.ReadLine(), out userNumber);

                if (userInput)
                {
                    if (userNumber > 0)
                    {
                        Console.WriteLine($"you have pick {userNumber}");
                        return userNumber;
                    }
                }
                else
                {
                    Console.WriteLine("It must be a number");
                }
            } while (true);
            // prompt the user for a number
            // read the user's input and try to parse it into an int
            // if the value is greater than 0, return it, otherwise tell the user it must be positive
            // if the user's input could not be parsed into an int, tell them it must be a number
            ;
        }

        public int GetGuess(int maxNumber)
        {

            // loop until we get a valid number
            while (true)
            {
                DisplayMessage($"Guess a number between 1 and {maxNumber}");
                int userNumber;
                bool userInput = int.TryParse(Console.ReadLine(), out userNumber);


                if (userInput)
                {
                    if (userNumber <= 0)
                    {
                        DisplayMessage("The guessing number must be positive.");
                    }
                    else if (userNumber > maxNumber)
                    {
                        DisplayMessage($"The guessing number must be less than {maxNumber}");
                    }
                    else
                    {
                        return userNumber;
                    }

                }
                else
                {
                    DisplayMessage("The input must be a number");
                }
            }

            // read the user's input and try to parse it into an int, 
            // if the value is greater than 0, return it, otherwise tell the user it must be positive
            // if the value is greater than the max number, tell the user it must be less than the max number
            // if the user's input could not be parsed into an int, tell them it must be a number

        }

        // just because we're going to keep the workflow from directly using the console.
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
            // display the message to the user

        }
    }
}
