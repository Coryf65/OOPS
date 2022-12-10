namespace DungeonsOfDoom
{
    abstract class Item : ICarryable
    {
        public string Name { get; set; }
        
        public Item(string name)
        {
            Name = name;
        }

        // no fitting default so we shall use abstract
        public abstract void Use(Player player);
    }
}