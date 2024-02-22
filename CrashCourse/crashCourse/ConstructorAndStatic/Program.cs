/*
 
Constructor
A constructor function is the first function called immediately after memory is allocated.
Whenever an object is created, the constructor function with the same name as the class is called first.

[Default Constructor]
If the developer does not create a constructor,
the compiler automatically generates an empty default constructor (although it is invisible to us).
 
[Purpose of Constructors]
Just as every employee must check in when they arrive at work,
if there is something that needs to be done immediately upon calling a function, such as initializing values,
that task should be placed in the constructor function.

[Background Story]
// The first thing Ms. Kim needs to do when she starts her day at work is to punch her timecard.
 */


public class StartWorking
{
    int amountOfWork;
    // constructor : When memory is allocated, it is executed once first.
    public StartWorking()
    {
        amountOfWork = 100;

        Console.WriteLine("Punched timeLine!");
    }

    //normal method 

    public void Working()
    {
        amountOfWork -= 10;
        Console.WriteLine($"you have {amountOfWork} amount of work left");
        Console.WriteLine($"Im so tired..");

    }
}

public class Company
{
    public static void Main()
    { 
        StartWorking MsKim = new StartWorking();// only allocating the memory atm but we clearly see Punched timeLine!
        MsKim.Working();
        MsKim.Working();
        MsKim.Working();
        MsKim.Working();
        Console.ReadKey();
    }
}