using DungeonsOfDoom.Core.Items;

namespace DungeonsOfDoom.Core.Characters
{
    public abstract class Monster : Character, ICarryable
    {
        public string Name { get; set; }
        public static int TotalMonsters { get; set; }
        public override int Health
        {
            get => base.Health;
            set
            {
                base.Health = value;

                if (base.Health <= 0)
                    TotalMonsters--;
            }
        }

        public Monster(string name, int health) : base(health)
        {
            Name = name;
            TotalMonsters++;
        }
    }
}