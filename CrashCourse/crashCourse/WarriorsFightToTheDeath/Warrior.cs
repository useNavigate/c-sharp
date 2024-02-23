using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsFightToTheDeath
{
    class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttakMax { get; set; }
        public double BlockMax { get; set; }

        /*
         * you always want to create a single random instance and reuse it 
           if you dont do that  you are going to get the same value over and over again.
         */
        Random rnd = new Random();

        public Warrior(string name="Warrior", double health=100, double attakMax=100, double blockMax = 100)
        {
            Name = name;
            Health = health;
            AttakMax = attakMax;
            BlockMax = blockMax;
        }

        public double Attack()
        {
            return rnd.Next(1, (int)AttakMax);
        }
        public virtual double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}
