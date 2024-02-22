namespace MyPlayground
{

    class Playground {


        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Person john = new Person("John",18,"Joker","USA");
            Console.WriteLine(john.Name);
            Console.WriteLine(john.nickname);
            //we are able to change it without setting property because this is public
            john.nickname = "new nickname";
            Console.WriteLine(john.nickname);
            Console.WriteLine(john.nationality);
            Console.WriteLine(Person.TotalPeople);




            Console.ReadKey();
        }
    
    }

}