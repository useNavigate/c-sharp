namespace IE
{
    class Program
    { 
        static void Main(string[] args) 
        {

            AnimalFarm myAnimals = new AnimalFarm();
            myAnimals[0] = new Animal("Wilbur");
            myAnimals[0] = new Animal("Templeton");
            myAnimals[0] = new Animal("Gander");
            myAnimals[0] = new Animal("Charlotte");
            foreach (Animal i in myAnimals)
            {
                Console.WriteLine(i.Name);
            }
            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(5, 6, 7);

            Box box3 = box1 + box2;
            Console.WriteLine($"Box3 : {box3}");
            Console.WriteLine($"Box Int : {(int)box3}");
            Box box4 = (Box)4;

            var shopkins = new { Name = "Shopkins", Price = 4.99 };

            Console.WriteLine("{0} cost ${1}", shopkins.Name,shopkins.Price);

            var toyArray = new[] {
                new { Name="Yo Kai Pack", Price = 4.00},
                new { Name="Legos", Price = 9.99}
            };

            foreach (var item in toyArray)
            {
                Console.WriteLine("{0} cost ${1}", item.Name, item.Price);
            }
            //an instance of this anonymous type

            Console.ReadLine();
        }
    }
}