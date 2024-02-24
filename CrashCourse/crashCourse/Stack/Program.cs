using System.Collections;

namespace Stacking
{
    class Program 
    { 
        //last in first  out
        static void Main(string[] args) 
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Peek 1 =>{0}",stack.Peek());
            Console.WriteLine("Pop 1 =>{0}", stack.Pop());
            Console.WriteLine("Contains 1 =>{0}", stack.Contains(1));
            object[] numArray2 = stack.ToArray();

            Console.WriteLine(string.Join(",",numArray2));

            foreach (object obj2 in numArray2) 
            {
                Console.WriteLine($"Stack : {obj2}");
            }


            Console.ReadKey();
        }

    }
}