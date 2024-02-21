namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        
        
        }
        static void CallPrint(IPrintable printable)
        {
            printable.Print("Message");
        }
    }

    public class Fasmaxhine : IPrintable, IReadable
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
        public string Read()
        {
            return Console.ReadLine();
        }
    }

    public interface IReadable
    {
        string Read();
    }
    public interface IPrintable
    {
        void Print(string message);
    }
}