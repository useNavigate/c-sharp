using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Interface2
{
    interface IElectronicDevice
    {
        void On();
        void Off();
        void VolumnUp();
        void VolumnDown();

    }
}
