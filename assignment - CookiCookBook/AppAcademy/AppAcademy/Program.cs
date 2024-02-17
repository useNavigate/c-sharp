namespace Animals
{
    public class Canine
    {
        public void Bark()
        {
            Console.WriteLine("Woof");
        }
    }
}

namespace Teeth
{
    public class Canine
    {
        public void Chew()
        {
            Console.WriteLine("Chomp");
        }
    }
}

//this will not work 
//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Canine c = new Canine();  // which canine???
//        }
//    }
//}

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animals.Canine dog = new Animals.Canine();
            //Teeth.Canine tooth = new Teeth.Canine();
            //Console.WriteLine("hi");
            //Console.WriteLine(dog);
            //Console.ForegroundColor = ConsoleColor.Cyan;

            //Console.WriteLine(tooth);
            //var x = 1;
            //Console.WriteLine(++x);
            //float money = 0.0000008f;

            string name;

            Console.Write("Enter Your name : ");
            name = Console.ReadLine();
            Console.WriteLine($"hello {name}");

     

            ConsoleKeyInfo keypress;

                Console.Write("Press the Z key to quit...");
            do
            {
                keypress = Console.ReadKey();
            } while (keypress.Key != ConsoleKey.Z);
            Console.WriteLine();
            Console.WriteLine(ConsoleKey.Z);


            //Using Parse to Change String Input to Numbers
            int a, b;
            string input;

            Console.Write("Enter a number: ");
            input = Console.ReadLine();

            a = int.Parse(input);

            Console.Write("Enter another number: ");
            input = Console.ReadLine();

            b = int.Parse(input);

            // Console.WriteLine("The sum is: " + (a+b).ToString());
            int sum = a + b;
            Console.WriteLine("The sum is: " + sum.ToString());


            Console.ReadLine();
        }
    }
}