
using crashCourse;
using System.Runtime.InteropServices;

namespace CrashCourse
{
    public class Program
    {
       static void Main(string[] args)
       {
            // as long as the parameters are different it works. 
            var animal = new Animal();
            var cat = new Animal("cat");
            var dog = new Animal("dog", "wolf wolf"); 

            Console.WriteLine("without argument : "+animal);
            Console.WriteLine("with name argument : " + cat);
            Console.WriteLine("with name argument : " + dog);

           var qty =  Animal.GetNumAnimals();
            Console.WriteLine(qty);//3
                                   // Console.WriteLine(Animal.numOfAnimals); inaccessible. 


            //struct 
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine($"Area of rect1 : {rect1.Area()}");//10000
            Rectangle rect2 = new Rectangle(100, 40);

            rect2 = rect1;
            rect1.length = 33;

            Console.WriteLine("rect2.length : {0}",rect2.length); //200 
            Console.ReadKey();
        }

        //struct 
        struct Rectangle
        {
            public double length;
            public double width;
            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }
            public double Area()
            {
                return length * width;
            }
        }


    }
}