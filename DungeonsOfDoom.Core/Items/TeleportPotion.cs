using DungeonsOfDoom.Core.Characters;

namespace DungeonsOfDoom.Core.Items
{
    public class TeleportPotion : Item
    {
        public TeleportPotion() : base("Teleportation Potion")
        {

        }

        public override void Use(Player player)
        {
            player.Health += 10;
            player.X = 0;
            player.Y = 0;
        }
    }
}