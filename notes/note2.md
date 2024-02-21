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
