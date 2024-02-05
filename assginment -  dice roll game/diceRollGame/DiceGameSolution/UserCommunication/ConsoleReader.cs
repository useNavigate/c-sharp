
namespace DiceGameSolution.UserCommunication
{
    public static class ConsoleReader
    {
        //static class only can  have static methods
        public static int ReadInteger(string message)
        {
            int result;
            do
            {
                Console.WriteLine(message);
            }
            while (!int.TryParse(Console.ReadLine(), out result));
            return result;
        }
    }
}
