using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsFightToTheDeath
{//this is going to be a utility class so we are going to set static
     class Battle
    {
        //startFight 
        //Warrior1 attacks warr2 and warr2 is damaged and health decreass

        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        //Get Attack Result 
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warA_attackAmount = warriorA.Attack();
            double warB_attackAmount = warriorB.Block();
            double dmgToWarB = warA_attackAmount - warB_attackAmount;
            if (dmgToWarB > 0)
            {
                warriorB.Health = warriorB.Health - dmgToWarB;
            }
            else dmgToWarB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", warriorA.Name,warriorB.Name,dmgToWarB);
            Console.WriteLine("{0} has {1} health\n ", warriorB.Name,  warriorB.Health);


            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorious\n ", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else return "Fight Again";
        }

    }
}
