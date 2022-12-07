using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Musician
    {
        public string Name { get; set; }
        public Guitar Guitar { get; set; }

        public Musician(string name, Guitar guitar)
        {
            Name = name;
            Guitar = guitar;
        }

        public void Plays()
        {
            Console.WriteLine($"{Name} from Breaking Benjamin plays a {Guitar.Brand} guitar.");
        }
    }
}
