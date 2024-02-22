# Crash Course 
 **Link :** https://www.youtube.com/watch?v=M5ugY7fWydE&t=8959s
 - skipped few fundamental such as var,primitive types,conditional and etc
 # 1. Casting 
 ```csharp
 using System;


//casting 
bool boolFromStr = bool.Parse("true");
int intFromStr = int.Parse("100");
double dblFROmSTR = double.Parse("1.234");
string strVal = dblFROmSTR.ToString();
Console.WriteLine($"Data Type :{strVal.GetType()}");

//explicit conversion => whenever you are losing data 
double dblNum = 12.345;
Console.WriteLine($"Interger : {(int)dblNum}");

//implicit conversion = > occus anytime you convert  from one data type to another in which the smaller size type is being converted in to a larger 
int intNum = 10;
long longNum = intNum;


```

# 2. Formatting
```cSharp
//formatting 
Console.WriteLine("Currency : {0:c}", 23.455);       //Currency : $23.45
Console.WriteLine("Pad with 0s : {0:d4}", 23);      // Pad with 0s: 0023
Console.WriteLine("3 Decimals : {0:f3}", 23.45555); //3 Decimals: 23.456
Console.WriteLine("commas : {0:n2}", 2300);        //commas: 2,300.0000 뒤에 영이 몇개 붙는지 
```

# 3.string 
```csharp

//string 
string randString = "This is a string";
Console.WriteLine("String Length :{0}", 
    randString.Length);//String Length :16

Console.WriteLine("String Contains is :{0}", 
    randString.Contains("is")); //String Contains is :True

Console.WriteLine("Index of is : {0}",
    randString.IndexOf("is")); //Index of is : 2

Console.WriteLine("Remove String :{0}", 
    randString.Remove(10,6)); //remove string :This is a

Console.WriteLine("Insert String : {0}",
    randString.Insert(10,"short ")); //Insert String : This is a short string

Console.WriteLine("Replace String :{0}",
    randString.Replace("string", "sentence"));//Replace String :This is a sentence

/*
    
    If the two strings are equal, String.Compare returns 0.
    If the first string comes before the second string in alphabetical order, String.Compare returns a value less than 0.
    If the first string comes after the second string in alphabetical order, String.Compare returns a value greater than 0

    Compaare string and ignore case 
< 0 : str1 preceeds str2 
= : zero 
> 0 : str2 preceeds str1 
    */

//INT - COMPARISON 
//case insensntive 
Console.WriteLine("Compare A to a :{0}", 
    String.Compare("A", "a", StringComparison.OrdinalIgnoreCase)); //0 meaning they are same returns int

//case sensitive 
Console.WriteLine("Compare A to a :{0}", 
    String.Compare("A", "a")); //1  meaning 'A' comes after 'a'

//case sensitive 
Console.WriteLine("Compare c to B :{0}",
    String.Compare("c", "B")); //1  meaning 'c' comes after 'B'

//case sensitive 
Console.WriteLine("Compare B to c :{0}",
    String.Compare("B", "c")); //-1  meaning 'B' comes before 'c'


Console.WriteLine(randString);//"This is a string" => immutable 
Console.WriteLine("----------------------------");

//----BOOL EQUALS
Console.WriteLine("A = a :{0}",
    String.Equals("A", "a", StringComparison.OrdinalIgnoreCase)); //true returns bool

Console.WriteLine("A = a :{0}",
    String.Equals("A", "a")); //false / case sensitive 


//----Adding paddings to string 
//string randString = "This is a string"; from line 10.
Console.WriteLine("Pad Left : {0}", 
    randString.PadLeft(20,'.'));//Pad Left : ....This is a string

Console.WriteLine("Pad right : {0}", 
    randString.PadRight(20, '^')); //Pad right : This is a string^^^^

//---TRIM white space 
Console.WriteLine("Trim : {0}",
    "   hello   ".Trim()); //Trim : hello

//--uppercase 
Console.WriteLine("Uppercase : {0}",randString.ToUpper());//Uppercase : THIS IS A STRING

//--lowercase
Console.WriteLine("Lowercase : {0}", randString.ToLower());//Uppercase : THIS IS A STRING

//fomatting
var zero = "paul";
var one = "rabbit";
var two = "eating";
var three = "field";
string newString = String.Format("{0} saw a {1} {2} in the {3}", zero,one,two,three);//paul saw a rabbit eating in the field
Console.Write(newString + "\n");
Console.WriteLine($"{zero} saw a {one} {two} in the {three}");//paul saw a rabbit eating in the field


//-- escape characters 
/*
    \', \", \\, \t ,\a
    */

Console.WriteLine(@"exactly how i type
enter.");/*exactly how i type
enter.*/

```
# 4. Array 
```csharp
//Arrays 
//Array only can store same type values that has been defined 

int[] favNums = new int[3];
Console.WriteLine(favNums.Length); //3
favNums[0] = 23;

//strings
string[] names = { "Sara", "Bob", "Rick" };
var employees = new[] { "Mike", "Paul", "Rick" };

//object type 
object[] randomArray = { "Paul", 45, 1.234 };
Console.WriteLine("RandomArray 0 : {0}", randomArray[0].GetType());//System.String

int x = 10;

// cannot do obj + obj           
// Console.WriteLine(randomArray[1] + x);
Console.WriteLine((int)randomArray[1] + x); //55

Console.ReadKey();
```

# MORE ARRAY loop and function 

```csharp
using System;
using System.Diagnostics;
using System.Linq;
namespace CrashCourse
{
    public class Program
    {
        //---------functions---------
        static void PrintArray(int[] intArray, string message) 
        { 
            foreach (int i in intArray) 
            {
                Console.WriteLine("{0} :{1}", message , i );
            }
        }


        static void Main(string[] args)
        {
            //For loop

            int[] favNums = new int[3];
            favNums[0] = 5;

            for (int i = 0; i < favNums.Length; i++)
            {
                Console.WriteLine(favNums[i]);// 5, 0 , 0 default is not null but its zero 
            }

            Console.WriteLine("--------------------------------------------");

            string[] favStrings = new string[3];
            favStrings[1] = "sara";
            for (int i = 0; i < favStrings.Length; i++)
            {
                Console.WriteLine(favStrings[i]);// empty sara empty 
            }


            /*
             Numeric Types (int, float, double, etc.): The default value for numeric types is 0.
             Boolean Type (bool): The default value for boolean types is false.
             Character Type (char): The default value for the character type is \0 (null character).
             Reference Types (including string): The default value for reference types is null.
             Structs and Custom Types: The default value for structs and custom types is a struct or object
                                       where all fields are initialized to their default values. 
                                       For example, if you have a custom struct with fields int, bool, and string, 
                                      the default value for an array of this struct type would be an array of structs 
                                       where each field is set to its default value (0, false, null, respectively).

            Numeric types: 0
            Boolean type: false
            Character type: \0
            Reference types (including string): null
             
             */
            Console.WriteLine("below should be printing unicode \\0");
            Console.WriteLine('\0');
            Console.WriteLine("--------------------------------------------");
   
            //multi dimensional array 
            //3 rows 2 columns
            string[,] customerNames = new string[3, 2] { { "Simon", "Andy" },{ "Bob", "Jack" }, { "Sally", "Smith" } };
            Console.WriteLine("MD value :{0}", customerNames.GetValue(2, 1)); //MD value :Smith
            Console.WriteLine(customerNames.Length); // 6 it actually returns all the amount of lement 
            Console.WriteLine($"1d :{customerNames.GetLength(0)}"); // 1d = row.length => 3
            Console.WriteLine($"2d :{customerNames.GetLength(1)}");//  2d.= col.length => 2


           // Console.WriteLine($"3d :{customerNames.GetLength(2)}"); //System.IndexOutOfRangeException: 'Array does not have 3rd dimension.'
         
           //.Length returns amount of element so we need to use GetLEngth instead.
           
            for (int i = 0; i < customerNames.GetLength(0); i++)
            {
                Console.WriteLine($"---ROW  : {i}");
                for (int j = 0; j < customerNames.GetLength(1); j++)
                {
                    Console.WriteLine($"---COL  : {j}");
                    Console.WriteLine($"item   : {customerNames[i, j]}");
                }
            }
            /*
             ---ROW  : 0
            ---COL  : 0
            item   : Simon
            ---COL  : 1
            item   : Andy
            ---ROW  : 1
            ---COL  : 0
            item   : Bob
            ---COL  : 1
            item   : Jack
            ---ROW  : 2
            ---COL  : 0
            item   : Sally
            ---COL  : 1
            item   : Smith
             */

            //3D
            int[] randNums = { 1, 4, 9, 2 };
            PrintArray(randNums, "ForEach");/*  ForEach :1
                                                ForEach :4
                                                ForEach :9
                                                ForEach :2 */


            Console.WriteLine("--------------------------------------------");


            //Array sort  they mutate the original array 
            Array.Sort(randNums);
            Array.Reverse(randNums);
            PrintArray(randNums, "ForEach"); /*  ForEach:9
                                                ForEach :4
                                                ForEach :2
                                                ForEach :1 */


            //indexOF

            Console.WriteLine("1 at index : {0}", Array.IndexOf(randNums,1)); //3
            randNums.SetValue(99, 1); //input vale , pos

            Console.WriteLine(randNums[1]);//99 

            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[3];

            int startIdx = 0;
            int length = 3;

            var copied = randNums;
            Console.WriteLine(copied == randNums); // it returns true so as we know its only refferencing it 

            //HOW TO COPY AN ARRAY 
            //       copyingfrom,  start  ,whereTo, where starting,length
            Array.Copy(srcArray, startIdx, destArray, 0, length);
           
            PrintArray(destArray, "dest- copid"); //1,2,3
            PrintArray(destArray, "src-org");//1,2,3

            Console.WriteLine(destArray == srcArray);//false


            //creating an array by usng createInstane 
            Array anotherArray = Array.CreateInstance(typeof(int), 10);


            //copying an array this has less control. it copis from starting int to all.
            srcArray.CopyTo(anotherArray, 5);

            foreach (int i in anotherArray)
            { 
                Console.WriteLine(i);//0,0,0,0,0,1,2,3,0,0
            }
            //PrintArray wont work for printing anotherArray because anotherArray type is Array while the function takes int[] as an argument. 

            Console.WriteLine("--------------------------------------------");
            //find => returns first element that is truthy.
            int[] numArray = { 1,2,4, 11, 22 };
            int result = Array.Find(numArray, n=> n%2==0) ;
            Console.WriteLine(result); //2

            var validated = numArray.FirstOrDefault(n => n % 2 == 0);
            Console.WriteLine(validated); //2
            Console.ReadKey();
        }
    }
}
```

# 5 Random 
```csharp
using System;
using System.Diagnostics;
using System.Linq;
namespace CrashCourse
{
    public class Program
    {
        //---------functions---------
      
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;
            Console.WriteLine("Random Num : "+secretNumber);

            do
            {
                Console.WriteLine("Enter a number between 1 & 10 : ");
                numberGuessed = Convert.ToInt32(Console.ReadLine());
            } while (secretNumber != numberGuessed);

            Console.WriteLine($"You guessed it correct it was {secretNumber}");
            Console.ReadKey();
        }
    }
}
```

# 6 Exception Handling
```csharp
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
```

# 7 String Builder 
> - every time you change a string what you are actually doing is creating a brand new string and this is very `inefficient` 
> - `stringBuilder` however actually allow you to change the text directly in memory. 
```csharp

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
            /*  sb3:
                definately has more than 1 char
                Adding More Line

                another line with \n
             */


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
```
# 8 Functions 
```csharp

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
        /*
         Ensure different parameter types: 
            Overload methods with different parameter types or 
            different numbers of parameters to distinguish between them.


         Use the same return type: 
              While it's not required,it's common practice to keep the return type 
              the same across overloaded methods to maintain consistency.
         
         */
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
```

# DateTime /TimeSpan

```csharp
DateTime awesomeDate = new DateTime(1974, 12, 21);
Console.WriteLine("Day of the week : {0}", awesomeDate.DayOfWeek);//Day of the week : Saturday

//changing value 
awesomeDate = awesomeDate.AddDays(1);
awesomeDate = awesomeDate.AddMonths(1);
awesomeDate = awesomeDate.AddYears(1);

Console.WriteLine("New Date : {0}", awesomeDate.Date);//New Date : 1/22/1976 12:00:00 AM

//time span 
TimeSpan lunchTime = new TimeSpan(12, 30, 0);
lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
Console.WriteLine("new Time :{0}", lunchTime.ToString());//new Time :12:15:00

Console.ReadLine();
``` 
