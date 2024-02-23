namespace MyPlayground
{

    class Playground {


        static void Main(string[] args)
        {
            //Console.WriteLine("hello world");
            Person john = new Person("John",18,"Joker","USA");
            //Console.WriteLine(john.Name);
            //Console.WriteLine(john.nickname);
            ////we are able to change it without setting property because this is public
            //john.nickname = "new nickname";
            //Console.WriteLine(john.nickname);
            //Console.WriteLine(john.nationality);
            //Console.WriteLine(Person.TotalPeople);


            Property wallet = new Property("wallet", 1.50,"John");
            Console.WriteLine(wallet.Age);
            Console.WriteLine(wallet.nickname);

            //who ownes this wallet? we are converting the derive type to parents type to access to parents field
            Console.WriteLine(((Person)wallet).Name);


            Console.ReadKey();
        }
    
    }

    class Property : Person
    {
        public string Name;
        public double Price;
        public string Owner;
        public Property( string name, double price, string owner = "No Owner"):base(owner,19)
        {
            Owner = owner;
            Name = name;
            Price = price;
        }
    
    }

}