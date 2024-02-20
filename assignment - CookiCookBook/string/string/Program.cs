using System;
using System.Text; // StringBuilder type lives in this namespace

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Banana");
            sb.AppendLine("Grape");
            sb.AppendLine("Apple");
            sb.AppendLine("Orange");
            sb.AppendLine("Mango");

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}