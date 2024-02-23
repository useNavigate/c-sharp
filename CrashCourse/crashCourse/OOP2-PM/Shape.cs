using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_PM
{
    //this will neverbe instantiated
    public abstract class Shape
    {
        public string Name { get; set; }

        //non-abstract methods
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }
        public abstract double Area();

    }
}
