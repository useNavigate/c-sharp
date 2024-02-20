namespace RogueLike
{
    public class Hero
    {

        public string Name { get; }
        public char Symbol { get; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public int HP { get; set; }
        // Create a hero with a name and an initial position.
        public Hero(int x, int y, string name)
        {
            Symbol = '@';
            X = x;
            Y = y;
            Name = name;
        }
        // movement
        public void MoveLeft()
        {
            X--;
        }

        public void MoveRight()
        {
            X++;
        }

        public void MoveUp()
        {
            Y--;
        }

        public void MoveDown()
        {
            Y++;
        }
    }

}
