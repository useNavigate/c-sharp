using System;
using System.Diagnostics;
using System.Linq;
namespace CrashCourse
{
    public class Program
    {
        static double DoDivision(double x, double y)
        {
            if (y == 0)
            { 
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
        static void Main(string[] args)
        {
            double num1 = 5;
            double num2 = 0;
            try
            {
                Console.WriteLine("5/0 ={0}", DoDivision(num1, num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            //we can also catch multiple different exceptions 
            //this is the default exception so we should only use it at last because this is going to catch every single  potential problem

            catch (Exception ex)
            {
                Console.WriteLine("an error occurred");//an error occurred
                Console.WriteLine(ex.GetType().Name); //DivideByZeroException
                Console.WriteLine(ex.Message);//a datatype misalignment was detected in a load or store instruction.
            }
            finally
            {
                
                Console.WriteLine("Cleaning up");
            }

            Console.ReadKey();
        }
    }
}