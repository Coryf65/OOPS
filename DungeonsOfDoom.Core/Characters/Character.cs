namespace DungeonsOfDoom.Core.Characters
{
    public abstract class Character
    {
        public virtual int Health { get; set; }
        public bool IsAlive { get { return Health > 0; } }
        public int Damage { get; set; } = 10;

        public Character(int health)
        {
            Health = health;
        }

        /// <summary>
        /// a defualt implementation for attacking, does 10 damage
        /// </summary>
        /// <param name="opponent">the other character you are attacking</param>
        public virtual AttackResult Attack(Character opponent)
        {
            // this. = the player OR the Monster
            opponent.Health -= Damage;

            return new AttackResult(attacker: this, opponent: opponent, damage: Damage);
        }
    }
}