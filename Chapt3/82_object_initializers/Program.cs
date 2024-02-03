Console.ReadKey();


//normal way to do (this way we need constructor)
//var person = new Person("John",1981)

//object initialize // we commented the constructur

// when we initiaize with object initizalize we do not need to pass down all the parameter,
// it will set default value of each type that is missing 



var person = new Person("John")
{
    Name = "John",
    YearOfBirth = 1981
};

person.Name = "Adam";
//person.YearOfBirth = 1992; only can initialize we cannot reassign 


/*if you do this, if will initialize with contructor first assign name John, 
 * then we do object initializing which will re assign the name to Adam, 
 */


//var person = new Person("John")
//{   Name = "Adam"
//    YearOfBirth = 1981
//};
class Person
{ 
    public string Name { get; set; }
    public int YearOfBirth { get; init; }

    public Person(string name)
    {
        Name = name;
    }
}