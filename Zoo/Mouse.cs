using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Mouse : Animal
    {
        public Mouse(string name, double weight, int age) : base(name, weight, age)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("squeak...");
        }
    }
}
