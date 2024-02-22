using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
namespace CrashCourse
{
    public class Program
    {
        //FUNCTIONS
        /*
         <Access Specifier> <Return Type> <Method Name>(Parameters)
          { <Body> }
        

        Access Specifier determines weather the function can be called from another class
        - public : can be accessed from another class 
        - private : can't be accessed from another class 
        - protected : can't be accessed by class and derived classes 
         */

        static double GetSum(double x = 1, double y = 1)
        {
           //traditional way to swap
            //double temp = x;
            //x = y;
            //y = temp;

           //new way to swap[ 
            (x, y) = (y, x);
            return x + y;
        }

        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp; 
        }

        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (var i in nums)
            {
                sum += i;
            }
            return sum;
        }

        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }

        //METHOD OVERLOADING
        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }

        static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);

            return dblX + dblY;
        }


        static void Main(string[] args) {
            //GetSum
            double x = 6;
            double y = 4;
            Console.WriteLine("6 + 4 = " + GetSum(x,y));//10

            //DoubleIt
            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2  = " + solution); //30

            //REF / swapping
            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before Swap num1 : {0},{1}",num3,num4);//10,20


            /*
             Passing by reference: Allows a method to modify the original variable directly rather than a copy.
             Performance considerations: Can improve performance by avoiding unnecessary copying of large data structures.
             Usage: Both caller and callee must use ref keyword; parameters must be initialized before passing.
             */
            Swap(ref num3, ref num4);
            Console.WriteLine("After Swap num1 : {0},{1}", num3, num4); //20,10 its mutated 



            //GetSumMore
            short num11 = 1;
            short num12 = 2;
            short num13 = 3;

            Console.WriteLine("1+2+3 ={0}", GetSumMore(num11,num12,num13));
            /*
             as you see we never parse it or converted 
            this is c# magic if same type is implicit convertable it will just do it 
            so as you see eventhough num11 num12 num13 are short type because our method 
            GetSumMore supposed to take double value, C#'s magical implicit numeric converesion happend here
            and thats why its not erroing. 
             */



            //PrintInfo
            //this code demonstrates how to pass down arguments into parameter without following its order 
            PrintInfo(zipCode: 11324, name:"Faker Park");


            //Method overload 
            Console.WriteLine("5.0 + 4.0 = {0}",GetSum2(5.0,4.0));
            Console.WriteLine("5.0 + 4.0 = {0}", GetSum2("5", "4"));
            Console.ReadKey();
        }
    }
}