using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }


        void Move();
        void Stop();

    }
}
