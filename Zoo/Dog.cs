﻿namespace Zoo
{
    internal class Dog : Animal
    {
        public Dog(string name, double weight, int age) : base(name, weight, age)
        {

        }

        /// <summary>
        /// We are Overriding to change how a dog eats opposed to the other animals
        /// </summary>
        /// <param name="animalToEat">The animal the Dog is eating</param>
        public override void Eat(IEdible edible)
        {
            // we could use the base functionality and add onto it
            // or comment this out and do what we want
            // base.Eat(animalToEat);
            Console.WriteLine($"*CHEW* ... {this.Name} ate most and buried the rest...");
            this.Weight += edible.Weight * 0.8;
        }

        public override void MakeSound()
        {
            Console.WriteLine("BORK!");
        }
    }
}
