
var sara = new Person("sara");
Console.WriteLine(sara.Name);
//sara.Name = "suzu";
//Console.WriteLine(sara.Name);
Console.ReadKey();

public class Person
{
    public string Name { get; private set; }

    public Person(string name)
    {
        Name = name;
    }
}


