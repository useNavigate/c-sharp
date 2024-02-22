using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "GRRR";

        public Dog(string name = "No Name", string sound = "No Sound", string sound2 = "No Sound2") : base(name, sound) 
        {
            Sound2 = sound2;
        }
        public override void MakeSound() 
        {
            Console.WriteLine($"{Name} says {Sound} and  {Sound2}");
        }
    }


}
