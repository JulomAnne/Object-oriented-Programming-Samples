using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ybañez_COConstructorUserInput
{
    class Dresses
    {
        //Declaring fields
        public string color, style;
        public double price;

        //Parameterized Constructor
        public Dresses(string delivery, string aStyle, double amount)
        {
            color = delivery;
            style = aStyle;
            price = amount;
        }

        //Call the method to display the object details
        public void DressDisplay()
        {
            Console.WriteLine("The " + color + " " + style + " gown is worth " + price + " pesos.");
        }
    }
}