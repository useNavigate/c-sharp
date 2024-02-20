using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLike
{
    public class Monster
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int HP { get; set; }

        public Monster(int x, int y, int hp)
        {
            X = x;
            Y = y;
            HP = hp;

        }
    }
}
