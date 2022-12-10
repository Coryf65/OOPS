using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal : IEdible
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;

            MakeSound();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="animalToEat"></param>
        public virtual void Eat(IEdible edible)
        {
            // example of interfaces
            Console.WriteLine($"*CHOMP* ... {this.Name} just ate.");
            this.Weight += edible.Weight;
        }

        public abstract void MakeSound(); // Abstract Member
    }
}
