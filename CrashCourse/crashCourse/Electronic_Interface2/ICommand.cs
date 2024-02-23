using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Interface2
{
     interface ICommand
    {
        void Execute();
        void Undo();
    }
}
