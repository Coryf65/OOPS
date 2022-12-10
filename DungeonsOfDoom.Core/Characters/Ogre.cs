using Utils;

namespace DungeonsOfDoom.Core.Characters
{
    public class Ogre : Monster
    {
        public Ogre() : base("Ogre", health: RandomUtils.Percentage() < 50 ? 10 : 20)
        {

        }
    }
}