string input;

int number=0;

bool isValid = false;

while (!isValid)
{
    Console.Write("Enter a number: ");
    input = Console.ReadLine();

    if (int.TryParse(input, out number))
    {
        isValid = true;
    }
    else
    {
        Console.WriteLine("That is not a valid number, try again!");
    }
}

Console.WriteLine($"You entered the number {number}.");