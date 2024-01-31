using System; // this is going to import namespace called system 

namespace ConsoleApp1 
{
    public class Program 
    {
        static void Main(string[] args) 
        {

            //1.basic hello world 

            /*Console.ForegroundColor = ConsoleColor.Black; //text color
            Console.BackgroundColor = ConsoleColor.White; //this will only change the background of the text 
            Console.Clear();
            Console.WriteLine("Hello World");
            Console.ReadKey();*/


            /* Console.Write("What is your name? ");
             string name = Console.ReadLine();
             Console.WriteLine($"hello {name}");
             Console.ReadKey();  */



            /* data types
            - int (Int32): 32 bits
            - long (Int64): 64 bits
            - float: 32 bits => 6 digits
            - double: 64 bits => 14 decimal digits => float type 
            - decimal: 128 bits

            Other Data Types
            - byte : 8-bit unsigned int 0 to 255 
            - char : 16-bit unicode character
            - sbyte : 8-bit signed int 128 to 127
            - short : 16-bit signed int [-32,768] to [32,767]
            - uint : 32-bit unsigned int 0 to [4,294,967,295]
            - ulong : 64-bit unsigned int 0 to [18,446,744,073,709,551,615]
            - ushort : 16-bit unsigned int 0 to [65,535]
             */

            /* bool canIVote = true
             Console.WriteLine("Bigget Interger : {0}", int.MaxValue); 
             Console.WriteLine("smallest Interger : {0}", int.MinValue);

             Console.WriteLine("Biggest Long : {0}", long.MaxValue);
             Console.WriteLine("Smallest Long : {0}", long.MinValue);

             decimal decPiVal = 3.141592653589793238462643383279502884197169399375105820974944592307816406M;
             decimal decBigNum = 3.0000000000000000000000000000000000000000000000000000000000000000000000000000011M;
             Console.WriteLine("DEC : PI + bigNUM = {0}",decPiVal + decBigNum);
             Console.WriteLine("Biggest Decimal :{0}", Decimal.MaxValue);


             Console.WriteLine("Biggest Float : {0}", float.MaxValue);
             double fltPiVal = 3.141592F;
             double fltBigNum = 3.00002F;
             Console.WriteLine("FLT : PI + bigNum = {0}",fltPiVal + fltBigNum );

             Console.ReadKey();*/

            //how to convert data types 
            /* bool boolFromStr = bool.Parse("true");
             int intFromStr = int.Parse("100");
             double dblFromStr = double.Parse("1.2344");

             string strVal = dblFromStr.ToString();

             Console.WriteLine($"data type : {strVal.GetType()}");

             //double to interger =>  explicit conversion whenever you are losing some data by converting 
             double dblNum = 12.345;
             Console.WriteLine($"Integer :{(int)dblNum}");

             //implicit conversion whenever you are gaining some data by converting
             int intNum = 10;
             long longNum = intNum;
             Console.WriteLine(longNum);*/

            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            Console.WriteLine("3 Decimals : {0:f3}", 23.456);
            Console.WriteLine("Commas :{0:n4}",2300);




            Console.ReadKey();





        }
    }
}