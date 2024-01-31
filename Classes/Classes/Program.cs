using Classes;
using System;

namespace creatingClass
{
    public class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();

            Console.WriteLine("Please enter your car manufacturer : ");
            string m = myCar.manufacturer(Console.ReadLine());

            Console.WriteLine("Please enter car model :");
            string mo = myCar.model(Console.ReadLine());

           
            Console.WriteLine("Please enter car colour");
            string c = myCar.color(Console.ReadLine());

            Console.WriteLine("Your car details : \n" + m + "\n" + mo + "\n" + c);

            Console.ReadLine();
        }
    }
}