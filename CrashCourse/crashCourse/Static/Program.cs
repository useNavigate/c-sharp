/*
 
 
static variables

int a = 10;
static int a = 10; 

[---Simple Explanation---]
1.Regular variables are destroyed once the function call ends.
2.However, variables declared as static remain in memory even after the function call ends.

[--Background Story--]
Background Story:
Assistant Manager Kim diligently reported to work every day, only to find that with each passing day,
her workload increased while her salary remained stagnant. 
The reason? Her workload was declared as static, causing it to persist even after the function call ended, 
while her salary, being a regular variable, disappeared once the function ended, leaving her empty-handed. 😢
 
 
 */



public class GoToWork
{
    static int workload = 0;
    int salary = 0;


    public GoToWork() 
    {
        Console.WriteLine("Punched Timecard");
        workload++;
        salary++;
    }

    public void StartWorking()
    {
        Console.WriteLine("======| workload {0}",workload);
        Console.WriteLine("======| salary {0}\n", salary);
    }
}


public class Company
{
    public static void Main()
    {
        
        int i;
        for (i = 0; i <= 5; i++)
        {
           Console.WriteLine("-----a {0}-year{1} veteran office worker Kim's yearly report-----", i,i>1 ? "s":"");
           GoToWork  MsKim = new GoToWork();
           MsKim.StartWorking();
        }


        Console.ReadKey();
    }

}