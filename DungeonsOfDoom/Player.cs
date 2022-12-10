namespace DungeonsOfDoom
{
    internal class Player : Character
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<ICarryable> Backpack { get; set; }

        public Player(int health, int x, int y) : base(health)
        {
            X = x;
            Y = y;
            Backpack = new();
        }
    }
}