using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE
{
    class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        public Box() : this(1, 1, 1) { }
        public Box(double length, double width, double breadth)
        {
            Length = length;
            Width = width;
            Breadth = breadth;
        }

        //operator overloading
        /*
         Box box1 = new Box(2, 3, 4);
         Box box2 = new Box(1, 2, 3);
         Box sumBox = box1 + box2;

         */

        //defining operator we are working with 
        public static Box operator +(Box box1, Box box2)
        {
            Box box = new Box()
            { 
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth
            };
            return box;
        }

        public static Box operator - (Box box1, Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };
            return box;
        }


        public static bool operator ==(Box box1, Box box2)
        {
            if ((box1.Length == box2.Length) && (box1.Width == box2.Width) 
                && (box1.Breadth == box2.Breadth))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Length != box2.Length) || (box1.Width != box2.Width) || (box1.Breadth != box2.Breadth))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return String.Format("Box heigth : {0}  width: {1} and Breadth:{2}", Length, Width, Breadth);

        }

        //convrt box to different data type = int
        /*
         Box myBox = new Box(2, 3, 4);
         int averageDimension = (int)myBox;
         */
        public static explicit operator int(Box b)
        {
            return (int)(b.Length + b.Width + b.Breadth) / 3;
        }


        /*
         int intValue = 5;
         Box boxFromInt = intValue; // Implicit conversion
         */
        public static implicit operator Box(int i)
        {
            return new Box(i, i, i);
        }



    }
}
