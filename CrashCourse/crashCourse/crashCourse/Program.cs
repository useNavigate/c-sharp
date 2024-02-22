
namespace CrashCourse
{
    public class Program
    {

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine($"The car was painted {cc} with the code {(int)cc}");

        }
        enum CarColor : byte
        { 
            Orange=1,
            Blue, 
            Green, 
            Red, 
            Yellow 
        }
        static void Main(string[] args) {

            CarColor car1 = CarColor.Blue;  
            PaintCar(car1);
            Console.ReadLine();
        }
    }
}