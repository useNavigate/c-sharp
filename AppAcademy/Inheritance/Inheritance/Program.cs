using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Media media = new Blog();
            media.Author = "John doe";
            media.Title = "Identify one's self";

            media.PrintContext();
            //Media book = new Book();
            //we currently boxed the book so we do not have access to Pages nor ISBN

            Media book = new Book()
            {
                Pages = 380,
                ISBN = "121212121212121212111"
            };
            book.Title = "He who fights with Monsters";
            book.Author = "Shirtaloo";
            
            Console.WriteLine(book);
            Console.ReadKey();
        }
    }


    public abstract class Media
    { 
        public string Title;
        public string Author;

        public decimal Price { get; set; }

        public Media(decimal price = 0)
        {
            Price = price;    
        }

        public abstract void PrintContext();

        public virtual void PickMe()
        {
            Console.WriteLine("Thank you for picking me");
        }

        public override string ToString()
        {
            return $"{Title}, by {Author}";
        }
    }

    public class Blog : Media
    {
        public string url { get; set; }
        public Blog() : base(0)
        { 
        
        }

        public override void PrintContext()
        {
            Console.WriteLine("This is a blog");
        }
    }
    public class Book : Media
    {
        public int Pages { get; set; }
        public string ISBN { get; set; }

        public Book(decimal price) : base(price)
        { 
            
        }

        public Book() : base(0)
        { 
        }
        public override string ToString()
        {
            return base.ToString() + $" : ISBN {ISBN}";
        }

        public override void PickMe()
        {
            Console.WriteLine("I am the best book");
        }
        public override void PrintContext()
        {
            Console.WriteLine("this is the book");
        }
    }


}