namespace DungeonsOfDoom
{
    internal class Player
    {
        public int Health { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Player(int health, int x, int y)
        {
            Health = health;
            X = x;
            Y = y;
        }
    }
}