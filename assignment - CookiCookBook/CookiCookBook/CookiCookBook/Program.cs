using System.Net;
using System.Net.NetworkInformation;


public enum FileFormat
{
    Txt,
    Json
}


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            new CookieCookBook().Generate();
            Console.ReadKey();
        }
    }
}