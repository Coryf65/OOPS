using DungeonsOfDoom.Core.Characters;

namespace DungeonsOfDoom.Core.Items
{
    public class Sword : Item
    {
        public Sword() : base("Sword")
        {

        }

        public override void Use(Player player)
        {
            player.Damage += 10;
        }
    }
}