namespace ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleIO.Display("Hello world");
            Person p = new Person("Sara","Ryu");
            //referebce
            Person p2 = p;

            Console.WriteLine(p.FirstName);//sally 
            Console.ReadLine();
        }
    }
}