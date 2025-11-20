using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Encapsulation
{
    internal class Dress
    {
        //Fields
        public string color, style;
        public double price;

        //Methods to display
        public void DressDisplay()
        {
            Console.WriteLine($"This is a {color} {style} gown worth {price} pesos.");
        }
    }
}