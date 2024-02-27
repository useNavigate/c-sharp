
using System.Threading.Channels;

namespace Threadd
{
    public class Program
    {

        static void Print1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }



        static void CountTo(int maxNum,string name)
        {

            for (int i = 0; i <= maxNum; i++)
            {
                Console.WriteLine(i.ToString() + $"____{name}");
            }
        }
        static void Main(string[] args)
        {
            //sharing resources
            //Thread t = new Thread(Print1);
            //t.Start();
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write(0);
            //}


            //int num = 1;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(num);
            //    Thread.Sleep(1000);
            //    num++;
            //}
            //Console.WriteLine("-------------------------------Thread sleep ends\n");

            //BankAccount acct = new BankAccount(10);
            //Thread[] threads = new Thread[15];
            //Thread.CurrentThread.Name = "main"; //current executing thread name.

            //for (int i = 0; i < 15; i++)
            //{
            //    Thread t = new Thread(new ThreadStart(acct.IssueWithdraw)); => you could only pass down method without arguments that return nothing.
            //    t.Name = i.ToString();
            //    threads[i] = t; 
            //}

            //for (int i = 0; i < 15; i++)
            //{
            //    //checking if thread has started 
            //    Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
            //    threads[i].Start();
            //    Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
            //}

            //Console.WriteLine("Current Priority : {0}", Thread.CurrentThread.Priority);
            //Console.WriteLine("Thread Name : {0}", Thread.CurrentThread.Name);


            Thread t = new Thread(() => CountTo(10,"one"));
            t.Start();

            //multi thread
            new Thread(() =>
            {

                CountTo(5,"two");
                CountTo(6,"three");
            }).Start();



            

            Console.ReadLine();
        }

    }

}