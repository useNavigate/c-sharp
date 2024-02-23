using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Interface2
{
    class Television : IElectronicDevice
    {
        public int Volumn { get; set; }

        public void Off()
        {
            Console.WriteLine("The TV is OFF");
        }

        public void On()
        {
            Console.WriteLine("The TV is ON");
        }

        public void VolumnDown()
        {
            if (Volumn != 0)
            {
                Volumn--;
                Console.WriteLine($"The TV Volumn is at {Volumn}");
            }
        }

        public void VolumnUp()
        {
            if (Volumn != 100)
            {
                Volumn++;
                Console.WriteLine($"The TV Volumn is at {Volumn}");
            }
        }
    }
}
