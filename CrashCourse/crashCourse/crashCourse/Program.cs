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
        static void Main(string[] args) {

            StringBuilder ssb = new StringBuilder("Same");
            StringBuilder ssb1 = new StringBuilder("Same");

            Console.WriteLine(ssb.Equals(ssb1)); //True because it has same string 
            Console.WriteLine(ssb == ssb1); //False because memory location are different. 




            StringBuilder sb = new StringBuilder("Random text");
            StringBuilder sb2 = new StringBuilder("More stuff that is very important",256);

            Console.WriteLine("Capacity : {0}",sb2.Capacity); //256
            Console.WriteLine("Capacity : {0}", sb.Capacity); //16
            Console.WriteLine(sb2.Length); //33 thre are exactly 33 chars in sb2
            sb2.AppendLine("\nMore important text"); // adding a line 

            /*
             StringBuilder automatically increases its capacity to accommodate 
             larger strings when necessary. If the initial capacity provided is insufficient, 
             StringBuilder dynamically reallocates memory to increase its capacity.
             
            
             example code 👇
             */

            Console.WriteLine("---------------------------------");
            StringBuilder sb3 = new StringBuilder("definately has more than 1 char", 1);

            Console.WriteLine("Capacity : {0}", sb3.Capacity); //31
            Console.WriteLine(sb3.Length); //31 sb3
            sb3.AppendLine();//adding an empty line \n
            sb3.AppendLine("Adding More Line "); // appendingn text
            sb3.AppendLine("\nanother line with \\n ");
            Console.WriteLine("Capacity : {0}", sb3.Capacity); //124

            Console.WriteLine("sb3 : \n" + sb3);

            

            Console.WriteLine("-----------------| Culture specific format");
            //culture specific format 
            CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");
            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUs, "Best Customer : {0}", bestCust);
            Console.WriteLine(sb2.ToString()); // same as  Console.WriteLine(sb2);
            Console.WriteLine("==================================");


            //replace
            Console.WriteLine("-----------------| Replace");
            sb2.Replace("text", "REPLACED");

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("after replace :" + sb2.ToString());
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("~_~_~_~_~~_~_~_~~_~_~_~_~_");
            sb2.Clear();//clearing
            Console.WriteLine(sb2); //nothing. literally prints nothing
            Console.WriteLine(sb2.Capacity); //256 capacity still remains the same. 
           
            
            Console.WriteLine("-----------------| appending && inserting text");

            //appending / inserting text
            sb2.Append(" Random Text\n");
            sb2.Insert(0, "that's great");//StringBuilder.Insert(idx,string value)
                                          //now sb2 =>  that's great Random Text

            //checking if those two stringbuilder are equal 
            Console.WriteLine(sb.Equals(sb2)); //False 

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(sb2); //that's great Random Text
  

            //Removing

            sb2.Remove(0, 7);// removing "that's " 7 chars including space after s 
            Console.WriteLine(sb2.ToString()); //great Random Text
            Console.ForegroundColor = ConsoleColor.White;






            Console.WriteLine("\n------------|  en-US");
            // Format a number (currency) using enUs culture
            double price = 1234.56;
            string formattedPrice = price.ToString("C", enUs); // Formatted price: $1,234.56
            Console.WriteLine("Formatted price: " + formattedPrice);

            // Format a date using enUs culture
            DateTime date = DateTime.Now;
            string formattedDate = date.ToString("D", enUs); // Formatted date: Wednesday, February 21, 2024
            Console.WriteLine("Formatted date: " + formattedDate);


            Console.WriteLine();
            Console.WriteLine("\n------------|  ko-KOR");//Formatted price: ?1,235
            CultureInfo koKr = CultureInfo.CreateSpecificCulture("ko-KOR");//Formatted date: 2024? 2? 21? ???
            double pr = 1234.56;
            string fPrice = pr.ToString("C", koKr); // Currency format
            Console.WriteLine("Formatted price: " + fPrice);

            DateTime dt = DateTime.Now;
            string fDate = dt.ToString("D", koKr); // Long date format
            Console.WriteLine("Formatted date: " + fDate);



            Console.ReadKey();
        }
    }
}