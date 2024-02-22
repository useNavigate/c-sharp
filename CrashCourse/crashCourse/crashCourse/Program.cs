
using crashCourse;
using System.Runtime.InteropServices;

namespace OOP
{
    public class Program
    {
       static void Main(string[] args)
       {



            //struct 
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine($"Area of rect1 : {rect1.Area()}");//10000
            Rectangle rect2 = new Rectangle(100, 40);

            rect2 = rect1;
            rect1.length = 33;

            Console.WriteLine("rect2.length : {0}",rect2.length); //200  if it was class it would have output 33
            Console.WriteLine("rect1.length : {0}", rect1.length); //33

            /*
             정확히 말씀드리면, 구조체(struct)를 사용한 경우에도 rect2 = rect1을 하면 rect2가 rect1의 값을 복사합니다. 그러나 이 복사는 값 자체를 복사하는 것이 아니라, 
             구조체가 가지고 있는 값들을 하나씩 복사하는 것이므로 메모리 상에는 서로 다른 두 개의 구조체가 존재합니다. 
             따라서 이후에 rect1의 속성을 변경해도 rect2는 변하지 않습니다.
             따라서 Console.WriteLine($"rect2의 길이: {rect2.length}");에서는 200이 출력됩니다. 
             이는 rect2가 rect1의 값을 복사한 후에 변경되지 않았기 때문입니다.

            When you use a struct in C#, doing rect2 = rect1 makes a copy of the values from rect1 to rect2. 
            So, rect2 and rect1 end up having separate copies of the values. This means that changing rect1 afterwards won't affect rect2.
            So when you print rect2.length, it remains 200, because rect2 keeps its own separate copy of the original values from rect1
             */

      

            //nullable type

            /*
             data types by defualt cannot have null value ( remember it was always set to zero?)   
             so how do we create nullable type 
             */

            int? randNum = null; // yes add question mark!
            string? randString = null;

            //if (!randNum) // this does not work! cannot be front of  ? nullable value 
            
            if(randNum == null)
            {
                Console.WriteLine("randNum is Null");
            }
            if (!randNum.HasValue) //only works for int
            {
                Console.WriteLine("RandNum is indeeed null!");
            }


            //----Animal object 

            // Animal lion = new Animal(); => will break the app it will error  please check Animal.cs line 


            // lion.Name = "1"+23; // string + int implicitly convert to string + string so the result would be "123" and this will error because of the validation 

            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Groover",
                Sound = "Woof Woof",
                Sound2 = "melong"
            };

            grover.Sound = "Wooooof";
            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIDInfo(12345, "Sally Smith");
            grover.SetAnimalIDInfo(12346, "Simon Mai");
            whiskers.GetAnimalIDInfo();

            //inner class 
            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            Console.WriteLine("Is my animal healthy ? :{0}",getHealth.HealthyWeight(11,46));
            
            Animal Moneky = new Animal()
            { 
                Name = "Happy",
                Sound = "Eeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Woff",
                Sound2 = "lololol"
            };
            spot.MakeSound();

            Console.ReadKey();
        }



        //struct 
        struct Rectangle
        {
            public double length;
            public double width;
            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }
            public double Area()
            {
                return length * width;
            }
        }


    }
}