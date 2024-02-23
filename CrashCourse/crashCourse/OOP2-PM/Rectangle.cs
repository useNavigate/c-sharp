using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_PM
{
    class Rectangle : Shape
    { 
        public double Length { get; set; }
        public double Width { get; set; }


        public Rectangle(double length, double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
            
        }

        public override void GetInfo()
        { 
            base.GetInfo();
            Console.WriteLine($"It has  length{Length} and  width {Width}");
        }



    }
}
