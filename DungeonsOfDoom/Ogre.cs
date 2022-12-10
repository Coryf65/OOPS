namespace DungeonsOfDoom
{
    internal class Ogre : Monster
    {    
        public Ogre() : base("Ogre", health: RandomUtils.Percentage() < 50 ? 10 : 20)
        {

        }
    }
}