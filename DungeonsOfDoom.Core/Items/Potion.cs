using DungeonsOfDoom.Core.Characters;

namespace DungeonsOfDoom.Core.Items
{
    public class Potion : Item
    {
        public Potion() : base("Potion")
        {

        }

        public override void Use(Player player)
        {
            player.Health += 15;
        }
    }
}