using System;

namespace RogueLike
{
    public class Game
    {

        // constants
        private const int Width = 10;
        private const char WallCharacter = 'M';
        private const string EmptyCharacter = " ";

        private Hero _hero;
        private Treasure _treasure;
        private Monster _monster;
        private bool _isOver;
        private int _level;

        public void Run()
        {
            SetUp();
            while (!_isOver)
            {
                PrintWorld();
                Move();
            }
            PrintWorld();

        }

        private void SetUp()
        {
            Random rand = new Random();
            int x = rand.Next(Width);
            int y = rand.Next(Width);
            Console.Write("Enter your hero's name: ");
            string name = Console.ReadLine();
            _hero = new Hero(x, y, name);
            _hero.HP = 10;

            _treasure = GenerateTreasure();
            _monster = GenerateMonster();

        }
        private Treasure GenerateTreasure()
        {
            Random rnd = new Random();
            int x = rnd.Next(Width);
            int y = rnd.Next(Width);

            do
            {
                x = rnd.Next(Width);
                y = rnd.Next(Width);
            } while (x == _hero.X && y == _hero.Y);
            return new Treasure(x, y);
        }

        private Monster GenerateMonster()
        {
            Random rnd = new Random();
            int x = rnd.Next(Width);
            int y = rnd.Next(Width);

            do
            {
                x = rnd.Next(Width);
                y = rnd.Next(Width);
            } while (x == _hero.X && y == _hero.Y || x == _treasure.X && y == _treasure.Y);
            return new Monster(x, y, 2 + (_level * 2));
        }

        private void PrintWorld()
        {
            Console.Clear();
            // top wall border
            Console.WriteLine(new string(WallCharacter, Width + 2));
            //it will print out 'M' * (Width(10) +2)
            //=> "MMMMMMMMMMMM" prints m 12 times. 

            for (int row = 0; row < Width; row++)
            {
                // left wall border
                Console.Write(WallCharacter);
                for (int col = 0; col < Width; col++)
                {
                    if (row == _hero.Y && col == _hero.X)
                    {
                        Console.Write(_hero.Symbol);
                    }
                    else if (_monster != null && row == _monster.Y && col == _monster.X)
                    {
                        Console.Write("X");
                    }
                    else if (row == _treasure.Y && col == _treasure.X)
                    {
                        Console.Write("T");
                    }
                    else
                    {
                        Console.Write(EmptyCharacter);
                    }
                }

                // right wall border
                Console.WriteLine(WallCharacter);
            }

            // bottom wall border
            Console.WriteLine(new string(WallCharacter, Width + 2));
        }

        private void Move()
        {

            Console.Write(_hero.Name + ", move [WASD]: ");
            string move = Console.ReadKey().KeyChar.ToString().ToUpper();

            switch (move)
            {
                case "W":
                    {
                        _hero.MoveUp();
                        break;
                    }
                case "A":
                    {
                        _hero.MoveLeft();
                        break;
                    }
                case "S":
                    {
                        _hero.MoveDown();
                        break;
                    }
                case "D":
                    {
                        _hero.MoveRight();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        break;
                    }
            }

            if (_hero.X < 0 || _hero.X >= Width
                    || _hero.Y < 0 || _hero.Y >= Width)
            {
                Console.WriteLine(_hero.Name + " touched lava! You lose.");
                _isOver = true;
                Console.ReadLine();
            }
            else if (_monster != null && _hero.X == _monster.X && _hero.Y == _monster.Y)
            {
                _hero.HP -= 1;
                _monster.HP -= 2;

                if (_monster.HP > 0)
                {
                    MoveBack(move);
                    Console.WriteLine("\nYou've fought a monster and each taken 2 hits!");
                    Console.ReadKey();
                }
                else if (_hero.HP > 0)
                {
                    Console.WriteLine($"\n{_hero.Name} has slain the monster! you ow have {_hero.HP} HP left");
                    Console.ReadKey();
                    _monster = null;
                }
                else
                {
                    Console.WriteLine("\nYou've been slain. Game over!");
                    Console.ReadKey();
                    _isOver = true;
                }
            }
            else if (_hero.X == _treasure.X && _hero.Y == _treasure.Y)
            {
                if (_monster == null)
                {
                    Console.WriteLine($"\n{_hero.Name} found the treasrue! Gain {_treasure.Restore}HP !");
                    Console.ReadKey();
                    _level++;
                    _hero.HP += _treasure.Restore;
                    _treasure = GenerateTreasure();
                    _monster = GenerateMonster();

                }
                else
                {
                    MoveBack(move);
                    Console.WriteLine("\nThe treasure is locked, slay the monster in the room.");
                    Console.ReadKey();

                }


            }
        }
        private void MoveBack(string move)
        {
            switch (move)
            {
                case "W":
                    {
                        _hero.MoveDown();
                        break;
                    }
                case "A":
                    {
                        _hero.MoveRight();
                        break;
                    }
                case "S":
                    {
                        _hero.MoveUp();
                        break;
                    }
                case "D":
                    {
                        _hero.MoveLeft();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        break;
                    }
            }

        }
    }

}
