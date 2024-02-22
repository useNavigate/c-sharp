
namespace CrashCourse
{
    public class Program
    {
        static void Main(string[] args) {

            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of the week : {0}", awesomeDate.DayOfWeek);

            //changing value 
            awesomeDate = awesomeDate.AddDays(1);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);

            Console.WriteLine("New Date : {0}", awesomeDate.Date);

            //time span 
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));

            Console.WriteLine("new Time :{0}", lunchTime.ToString());
            Console.ReadLine();
        }
    }
}