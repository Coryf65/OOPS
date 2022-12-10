using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        /// <summary>
        /// Eats an animal and gains it's weight
        /// </summary>
        /// <param name="animalToEat">The animal you are eating</param>
        public virtual void Eat(Animal animalToEat)
        {
            Console.WriteLine($"*CHOMP* ... {this.Name} just ate the {animalToEat.Name}.");
            this.Weight += animalToEat.Weight;
        }
    }
}
