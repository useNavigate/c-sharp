using System.Collections;
using System.Dynamic;

class Program
{       //first in first out 
     static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine("1 in queue:{0}",queue.Contains(1));
        Console.WriteLine("1 in Dequeue:{0}", queue.Dequeue());//removed 1
        Console.WriteLine("Peek 1:{0}", queue.Peek());//returns first element 
        object[] numArray = queue.ToArray();//convert to Array


        Console.WriteLine(String.Join(",",numArray));//2,3

        foreach(object o in queue)
        {
            Console.WriteLine($"Queue : {o}");
        }

        queue.Clear();//clearing queue;
        Console.ReadLine();
    }
}