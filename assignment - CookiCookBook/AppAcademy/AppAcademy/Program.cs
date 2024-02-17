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
            Animals.Canine dog = new Animals.Canine();
            Teeth.Canine tooth = new Teeth.Canine();
            Console.WriteLine("hi");
            Console.WriteLine(dog);
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.WriteLine(tooth);
            var x = 1;
            Console.WriteLine(++x);
            Console.ReadLine();
        }
    }
}