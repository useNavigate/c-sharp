
/*
Dice:
- dice read only ( user does not need to see)
- roll dice

validate:
- validate:  
    - if input value is digit
        - checks if input value and dice value are same

 */

class Dice
{
    private readonly Random random = new Random();
    public int _dice { get; }

    public Dice()
    {

        _dice = random.Next(1, 7);
    }
}
static class Validate {
    public static bool IsValidInput(string userInput)
    {//we are not using res but we want to use tryParse so it wont throw loud error
        return int.TryParse(userInput, out int res) ;
    }
    public static bool IsCorrectGuess(int userGuess, int diceValue)
    {
        return userGuess == diceValue;
    }
}


class Program
{
    static void Main()
    {

        var newGame = new Dice();
        var diceVal = newGame._dice;
        int i = 0;
        int maxTrials = 3;

        Console.WriteLine(diceVal);
        while (i < maxTrials)
        {
            Console.WriteLine($"Please enter your guess you have {maxTrials - i} attemps");
            var userInput = Console.ReadLine();

            if (Validate.IsValidInput(userInput))
            {
                var userGuess = int.Parse(userInput);

                if (Validate.IsCorrectGuess(userGuess, diceVal))
                {
                    Console.WriteLine("You WON!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Try again");
                }
            }
            else 
            {
                Console.WriteLine($"invalid input try again");
                continue;
            }
            i++;
        }

        Console.WriteLine("You Lose");
        Console.ReadKey();
    }
}