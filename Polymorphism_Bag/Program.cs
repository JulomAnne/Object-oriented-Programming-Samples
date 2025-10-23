using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ybañez_Polymorphism
{
    internal class Program
    {
        //Name: Kris Anne J. Ybañez
        //Section: IT306
        //EXERCISE 09: Polymorphism
        static void Main(string[] args)
        {
            //Instantiate an object
            Bag schoolbag = new SchoolBag("JanSport", 1500, 5);
            Bag travelbag = new TravelBag("Samsonite", 4500, 60);

            //Display Method Details
            schoolbag.DisplayInfo();
            travelbag.DisplayInfo();

            Console.ReadLine();
        }
    }
}