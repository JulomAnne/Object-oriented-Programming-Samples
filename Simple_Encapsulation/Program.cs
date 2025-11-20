using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kris Anne J. Ybañez   IT306   Create a Class

            //Instantiate objects
            Dress dress1 = new Dress();
            Dress dress2 = new Dress();
            Dress dress3 = new Dress();

            //Initialization values for fields (Attributes)
            dress1.style = "Victorian";
            dress1.color = "Blue";
            dress1.price = 12000;

            dress2.style = "Ball";
            dress2.color = "Silver";
            dress2.price = 40000;

            dress3.style = "Evening";
            dress3.color = "Black";
            dress3.price = 25000;

            //Call method to display
            dress1.DressDisplay();
            dress2.DressDisplay();
            dress3.DressDisplay();

            Console.ReadLine();
        }
    }
}