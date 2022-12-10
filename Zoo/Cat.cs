namespace Zoo
{
    internal class Cat : Animal
    {
        public Cat(string name, double weight, int age) : base(name, weight, age)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Purrrsss");
        }
    }
}
