using System;
namespace conditional
{
    public class Program
    {
        //functions go here 

        static void Main(string[] args)
        {
            //Relaional operators : > < >= <= == != 
            // Logical Operators : && || !

            int age = 17;
            if ((age >= 5) && (age <= 7)) 
            {
                Console.WriteLine("Go to elementary school");
            }

            if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle School");
            }
            if ((age > 13) && (age < 19))
            {
                Console.WriteLine("Go to highschool");
            }
            else {
                Console.WriteLine("Go to college");
            }

            if ((age < 14) || (age > 67)) 
            {
                Console.WriteLine("You should not be working");
            }

            Console.WriteLine("! true = " + (!true));

            bool canDrive = age >= 16 ? true:false;

            switch (age) 
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to Day Care");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to Preschool");
                    break;
                case 5:
                    Console.WriteLine("Go to Kindergarten");
                    break;
                default:
                    Console.WriteLine("Go to another school");
                    goto OtherSchool;

            }
        OtherSchool:
            Console.WriteLine("Elementary, Middle, High School");

            string name2 = "Derek";
            string name3 = "DEREK";
            //if (name2.Equals(name3, StringComparison.Ordinal))

            // if (name2.Equals(name3, StringComparison.OrdinalIgnoreCase))
            if (name2.Equals(name3, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are equal");
            }
            else
            {
                Console.WriteLine("names are not equal");
                Console.WriteLine(String.Compare(name2, name3, StringComparison.Ordinal)); //this will return the number of code 32 is D
            }
            Console.ReadKey();
        }

    }
}