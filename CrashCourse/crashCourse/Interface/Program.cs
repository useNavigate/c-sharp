namespace Interface 
{
    class Program
    { 
        static void Main(string[] args) 
        {
            Vehicle buick = new Vehicle("Buick", 4, 160);
            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven",buick.Brand);
            }



            Console.ReadLine();
        }
    
    }

}