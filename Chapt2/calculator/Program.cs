Console.WriteLine("Hello! input the first number: ");
int userInput_a = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number:");
int userInput_b = int.Parse(Console.ReadLine());




Console.WriteLine("What do you want to do with thosse numbers?\n[A]dd\n[S]ubtract\n[M]multiply");
string userMethod = Console.ReadLine();

int Calc (string scenario,int val1,int val2)
{
    if (scenario.ToLower() == "a")
    {
        return val1 + val2;
    }
    else if (scenario.ToLower() == "s")
    {
        return val1 - val2;
    }
    else
    {
        return val1 * val2;
    }
    
   
}
Console.WriteLine(Calc(userMethod,userInput_a,userInput_b));
Console.WriteLine("Press any key to close");



Console.ReadKey();
