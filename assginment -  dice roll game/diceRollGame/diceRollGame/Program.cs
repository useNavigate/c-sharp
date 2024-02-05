
/*
Dice:
- dice read only ( user does not need to see)


validate:
- validate:  
    - if input value is digit
        - checks if input value and dice value are same

GussingGame:
- should play the game and CW prompts 
 */

public class Dice
{
    private readonly Random random = new Random();
    public int _dice { get; }
    public Dice()
    {
        _dice = random.Next(1, 7);
    }
}
public static class Validate {
    public static bool IsValidInput(string userInput)
    {//we are not using res but we want to use tryParse so it wont throw loud error
        return int.TryParse(userInput, out int res) ;
    }
    public static bool IsCorrectGuess(int userGuess, int diceValue)
    {
        return userGuess == diceValue;
    }
}

public class GuessingGame
{
    private readonly Dice dice;
    private readonly int maxTrials = 3;
    public GuessingGame()
    {
        this.dice = new Dice();
 
    }
    public void PlayGame()
    {
        Console.WriteLine($"Dice rolled. Guess what number it shows in {maxTrials} tries.");
        int trialsLeft = maxTrials;

        while (trialsLeft > 0)
        {
            Console.WriteLine($"Please enter your guess. You have {trialsLeft} attempts left.");
            var userInput = Console.ReadLine();

            if (Validate.IsValidInput(userInput))
            {
                var userGuess = int.Parse(userInput);

                if (Validate.IsCorrectGuess(userGuess, dice._dice))
                {
                    Console.WriteLine("You WON!");
                    return;
                }
                else
                {
                    Console.WriteLine("Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            trialsLeft--;
        }

        Console.WriteLine("You Lose");
    }
}

class Program
{
    static void Main()
    {
        var guessingGame = new GuessingGame();
        guessingGame.PlayGame();

        Console.ReadKey();
    }
}
