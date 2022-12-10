using Utils;

namespace DungeonsOfDoom.Core.Characters
{
    public class Skeleton : Monster
    {
        public Skeleton() : base("Skeleton", health: RandomUtils.DiceRoll(6))
        {
            Damage = 5;
        }

        /// <summary>
        /// Skeletons attack if the player has less than 30 health, and does 5 damaga
        /// </summary>
        /// <param name="opponent">Character you ara attacking</param>
        public override AttackResult Attack(Character opponent)
        {
            int damage = 0;

            if (opponent.Health < 30)
            {
                // skeleton is brave enough to attack
                opponent.Health -= Damage;
                damage = Damage;
            }

            return new AttackResult(attacker: this, opponent, damage);
        }
    }
}