using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsFightToTheDeath
{
    class CantTeleport : Teleport
    {
        public string teleport()
        {
            return "Fails at Teleporting";
        }
    }
}
