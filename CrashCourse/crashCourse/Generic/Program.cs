// We focus on Generic Collections, Generic Methods,
// Generic Structs, and more on Delegates

using System.Net.Security;

namespace Generic
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            List<int> numList = new List<int>();
            numList.Add(24);
            animalList.Add(new Animal() { Name = "Doug" });
            animalList.Add(new Animal() { Name = "Paul" });
            animalList.Add(new Animal() { Name = "Sally" });

            animalList.Insert(1, new Animal() { Name = "steve" });
            animalList.RemoveAt(1);
            Console.WriteLine("num of animals :{0}", animalList.Count());

            foreach (Animal a in animalList)
            {
                Console.WriteLine(a.Name);
            }


            int x = 5, y = 4;
            Animal.GetSum<int>(ref x, ref y);

            string strX = "5", strY = "4";
            Animal.GetSum<string>(ref strX, ref strY);




            Rectangle<int> rec1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rec1.GetArea());

            Rectangle<string> rec2 = new Rectangle<string>("20", "50");
            Console.WriteLine(rec2.GetArea());

            //Arithmetic add, sub, addSub;
            //add = new Arithmetic(Add);
            //sub = new Arithmetic(Subtract);
            //addSub = add + sub;

            Arithmetic add = new Arithmetic(Add);
            Arithmetic sub = new Arithmetic(Subtract);
            Arithmetic addSub = add + sub;


            Console.WriteLine($"Add {6} & {10}");
            add(6, 10);
            Console.WriteLine($"Add & subtract {10} & {4}");
            addSub(10, 4);

            Console.ReadLine();
        }

        public struct Rectangle<T>
        {
            private T width;
            private T height;
            public T Width
            {
                get { return width; }
                set { width = value; }
            }
            public T Height
            {
                get { return height; }
                set { height = value; }
            }


            //generic constructor
            public Rectangle(T w, T h)
            {
                width = w;
                height = h;

            }


            public string GetArea()
            {

                double dblWidth = Convert.ToDouble(width);
                double dblHeight = Convert.ToDouble(height);
                return string.Format($"{Width} * {height} = {dblWidth * dblHeight}");
            }
        }

        public delegate void Arithmetic(double num1, double num2);

       
           
        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
    }
}