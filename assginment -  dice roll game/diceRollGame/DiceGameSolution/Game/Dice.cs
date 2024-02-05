
namespace DiceGameSolution.Game
{

    public class Dice
    {
        private readonly Random _random;
        private const int SidesCount = 6;

       /*
        this is how we call this property 
        var random = new Random();
        var dice = new Dice(random);
        */
        public Dice(Random random)
        {
            _random = random;
        }

        public int Roll() => _random.Next(1, SidesCount + 1);
        
        

        public void Describe() => Console.WriteLine($"this is a dice with {SidesCount} sides");

    }

}
