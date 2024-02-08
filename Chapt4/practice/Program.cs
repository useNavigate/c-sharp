using System.Text.Json;



// you need a constructor to initiate like this. 
//var person = new Person("Sara", "Ryu", 1993);

//you do not need constructor to initialize instance like this. 
var person = new Person { FirstName = "Sara", LastName = "Ryu", YearOfBirth = 1993 };

var asJson = JsonSerializer.Serialize(person);// returns object as JSON string 
//{"FirstName":"Sara","LastName":"Ryu","YearOfBirth":1993}


Console.WriteLine("As Json: ");
Console.WriteLine(asJson);

var personJson = "{\"FirstName\":\"Sara\",\"LastName\":\"Ryu\",\"YearOfBirth\":1993}";
var personFromJson = JsonSerializer.Deserialize<Person>(personJson);
Console.ReadKey();
public class Person {
    //public Person(string firstName, string lastName, int yearOfBirth)
    //{
    //    FirstName = firstName;
    //    LastName = lastName;
    //    YearOfBirth = yearOfBirth;
    //}

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }

}