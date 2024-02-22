using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashCourse
{
    class Animal
    {
        //field value must be assigned 
        public string name;
        public string sound;
        static int numOfAnimals = 0;
        //you initialize with constructor
        public Animal()
        {
            
            name = "NO name";
            sound = "NO Sound";
            //only increment when user instantiated without arguments 
            numOfAnimals++; 
        }


        public Animal(string name = "default Name")
        {
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name", string sound = "No Sound") 
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}",name,sound);
        
        }

        public override string ToString()
        {
            return $"name => {name}\tsound => {sound}";
        }

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
}
