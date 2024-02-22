using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Animal
    {
        //------------------[1] FIELD
        //field value must be assigned 
        private string name;
        protected string sound;

        protected AnimalIDInfo animalIdInfo = new AnimalIDInfo();
        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIdInfo.IDNum = idNum;
            animalIdInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIdInfo.IDNum} and is owned by {animalIdInfo.Owner}" );
        }

        //overriding 
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }


        //------------------[2] CONSTRUCTOR

        //chained constructor 
        /*
        Animal lion = new Animal(); // this will CW errors 
         When using a default constructor in C# that chains to another constructor using the "this" keyword,
        it's important to understand that direct field initialization occurs before property setters are invoked.
        This means that any validation logic or additional operations within property setters won't be applied 
        during this initialization process. Therefore, when relying on property setters to enforce constraints 
        or perform specific actions during initialization, be aware of how constructor chaining affects object 
        initialization to ensure expected behavior.

        [Simple Summary]

        1.You create an instance of the Animal class with Animal lion = new Animal();.

        2.Since you don't provide any arguments, the default constructor is invoked. This default constructor chains to another constructor using the this keyword: public Animal() : this("No name", "No sound") { }.

        3.The chained constructor (Animal(string name, string sound)) is invoked with "No name" and "No sound" as arguments.

        4.Inside the chained constructor, the fields name and sound are directly initialized with the provided values "No name" and "No sound".

        5.The property setters for Name and Sound are not invoked because the fields are initialized directly. This means any validation logic within the property setters is bypassed.

        6.When the property setters are eventually invoked later, they try to access the uninitialized fields, which results in a null reference exception or unexpected behavior.

        7.In summary, the error occurs because the property setters are not invoked during initialization due to the direct field initialization in the constructor chaining process, leading to uninitialized properties when the property setters are eventually invoked later.

         */

        //chained constructor => recursive 
        public Animal() : this("No name", "No sound"){ }
        public Animal(string name) : this(name, "No Sound!") { }

        //parameterized constructor
        public Animal(string name, string sound)
        {
            Name=name;
            Sound = sound;
 
        }

        //------------------[3] PROPERTY
        public string Sound 
        { 
            get { return sound; }
            set 
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("length must be less than 10 ");
                }
                else if (value.Any(char.IsDigit))
                {
                    Console.WriteLine("You cannot add any int values");
                }
                else
                {
                    sound = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                //this validation wont work because if the name is "123" it will pass
                //if (value is string)
                //{
                //    name = value;

                //}
                //this checks if each char has any digit value 
                if (value.Any(char.IsDigit))
                { 
                    name = "No Name";
                    Console.WriteLine("value type must be string");
                
                }

                    name = value;
                
            }
        }
        //------------------[4]  Inner Class 
        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if (calc >= 0.8 && (calc <= .27))
                {
                    return true;
                }
                return false;
            }
        }

    }


}
