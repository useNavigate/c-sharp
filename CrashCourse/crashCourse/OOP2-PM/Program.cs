using OOP2_PM;

namespace OOP2
{
    //abtract
    class Program
    { 
    
        static void Main(string[] args) 
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };
            foreach (Shape s in shapes) 
            {
                s.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());
                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("This isn't a circle");
                }

                if (s is Circle)
                {
                    Console.WriteLine("This is a circle");
                }
            }

            Console.ReadLine();
        
        }


        
    }
}