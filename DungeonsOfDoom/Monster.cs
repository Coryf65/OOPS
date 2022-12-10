namespace DungeonsOfDoom
{
    abstract class Monster : Character, ICarryable
    {
        public string Name { get; set; }
        
        public Monster(string name, int health) : base(health)
        {
            Name = name;
        }
    }
}