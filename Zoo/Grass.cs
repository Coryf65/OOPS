namespace Zoo
{
    internal class Grass : IEdible
    {
        public double Weight { get; set; }

        public Grass(double weight)
        {
            Weight = weight;
        }
    }
}