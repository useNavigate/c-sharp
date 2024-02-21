# Crash Course 
 **Link :** https://www.youtube.com/watch?v=M5ugY7fWydE&t=8959s
 
 ### 1. Casting 
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

### 2. Formatting
```cSharp
//formatting 
Console.WriteLine("Currency : {0:c}", 23.455);       //Currency : $23.45
Console.WriteLine("Pad with 0s : {0:d4}", 23);      // Pad with 0s: 0023
Console.WriteLine("3 Decimals : {0:f3}", 23.45555); //3 Decimals: 23.456
Console.WriteLine("commas : {0:n2}", 2300);        //commas: 2,300.0000 뒤에 영이 몇개 붙는지 
```

### 3.string 
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
### 4. Array 
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

### MORE ARRAY loop and function 

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

### 5 Random 
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

### 6 Exception Handling
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
