using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Guitar
    {
        public string Brand { get; set; }
        public bodyStyle BodyStyle { get; set; }
        public double Price { get; set; } = 0.00;
        public enum bodyStyle
        {
            LesPaul,
            Telecaster,
            Stratocaster,
            SuperStrat,
            SG,
            Explorer
        }

        public Guitar(string brand, bodyStyle bodyStyle, double price)
        {
            Brand = brand;
            BodyStyle = bodyStyle;
            Price = price;
        }
    }
}