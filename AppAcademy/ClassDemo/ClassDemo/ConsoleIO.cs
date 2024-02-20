using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class ConsoleIO
    {

        public static void Display(string message)
        {
            Console.WriteLine(message);
        }

        public static string Prompt(string message)
        {
            Display(message);
            return Console.ReadLine();
        }
    }
}
