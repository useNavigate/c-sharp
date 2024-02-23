using System;

namespace WarriorsFightToTheDeath
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * beauty of oop :) keep it simple 
             thor = new Warrior("Thor",100,26,10);
             hulk = new Warrior("Hulk",100,26,10);
             Battle.StartFight(thor,hulk)
             */

            Warrior thor = new Warrior("Thor", 100, 26, 10);
            Warrior loki = new MagicWarrior("Loki", 75, 20, 10,50);
            Battle.StartFight(thor, loki);
            Console.ReadKey();
        }

    }

}