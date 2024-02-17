class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe.");

        do
        {
            Play();
        } while (playAgain());

        Console.WriteLine("Goodbye!");
    }

    static void Play()
    {
        string playerOne = GetRequiredString("Player #1, what is your name?: ");
        string playerTwo = GetRequiredString("Player #2, what is your name?: ");

        char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        bool keepPlaying = true;

        Random rng = new Random();
        bool playerOnesTurn = rng.Next(1, 101) <= 50;

        char symbol;

        if (playerOnesTurn)
        {
            Console.WriteLine($"{playerOne} goes first.");
            symbol = 'X';
        }
        else
        {
            Console.WriteLine($"{playerTwo} goes first.");
            symbol = 'O';
        }


        do
        {
            DisplayBoard(board);

            if (playerOnesTurn)
            {
                keepPlaying = TakeTurn(playerOne, symbol, board);
                playerOnesTurn = false;
                symbol = 'O';
            }
            else
            {
                keepPlaying = TakeTurn(playerTwo, symbol, board);
                playerOnesTurn = true;
                symbol = 'X';
            }

        } while (keepPlaying);

        DisplayBoard(board);
    }

    static void DisplayBoard(char[] board)
    {
        Console.WriteLine("         Column");
        Console.WriteLine("       1   2   3");
        Console.WriteLine("       _   _   _");
        Console.WriteLine($"Row 1: {board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine("       _   _   _");
        Console.WriteLine($"Row 2: {board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine("       _   _   _");
        Console.WriteLine($"Row 3: {board[6]} | {board[7]} | {board[8]}");
    }

    static bool TakeTurn(string name, char symbol, char[] board)
    {

        Console.WriteLine(name + ", it's your move.");
        bool isValid = false;
        int row;
        int col;

        do
        {
            row = GetRowOrColumn("Select a row [1-3]: ");
            col = GetRowOrColumn("Select a column [1-3]: ");

            if (board[row * 3 + col] != ' ')
            {
                Console.WriteLine("That position is taken. Try again.");
            }
            else
            {
                board[row * 3 + col] = symbol;
                isValid = true;
            }
        } while (!isValid);

        return !IsGameOver(name, row, col, board);
    }

    static int GetRowOrColumn(string prompt)
    {

        int value;

        do
        {
            Console.Write(prompt);

            if (int.TryParse(Console.ReadLine(), out value))
            {
                if (value >= 1 && value <= 3)
                {
                    return value - 1; // convert to 0 based
                }
            }
            else
            {
                Console.WriteLine("Please enter 1, 2, or 3.");
            }

        } while (true);
    }

    static bool IsGameOver(string name, int row, int col, char[] board)
    {

        char symbol = board[row * 3 + col];

        if ((board[row * 3] == board[row * 3 + 1] && board[row * 3] == board[row * 3 + 2]) // check row
                || (board[col] == board[3 + col] && board[col] == board[6 + col]) // check column
                || (symbol == board[0] && symbol == board[4] && symbol == board[8]) // diagonal down
                || (symbol == board[6] && symbol == board[4] && symbol == board[2]) // diagonal up
        )
        {
            Console.WriteLine(name + " wins!");
            return true;
        }


        if (!board.Any(c => c == ' '))
        {
            Console.WriteLine("It's a tie.");
            return true;
        }

        return false;
    }

    static string GetRequiredString(string prompt)
    {
        string result;

        do
        {
            Console.Write(prompt);
            result = Console.ReadLine();
            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("Error: value is required.");
            }
            else
            {
                return result;
            }
        } while (true);
    }

    static bool playAgain()
    {
        return GetRequiredString("Play again? [y/n]: ").ToUpper() == "Y";
    }
}