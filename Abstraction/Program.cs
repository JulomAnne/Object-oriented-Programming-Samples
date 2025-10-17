using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ybañez_Abstraction
{
    //Name: Kris Anne J. Ybanez
    //Section: IT306P
    //Subject: OOPROG

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Instantiate derived object class
            SchoolBag backpack = new SchoolBag("JanSport", "Blue", 1500, 5);
            TravelBag travelBag = new TravelBag("Samsonite", "Black", 4500, 60);

            //Display details & discount examples
            backpack.DisplayDetails();
            backpack.CalculateDiscount(10);
            backpack.Carry();

            travelBag.DisplayDetails();
            travelBag.CalculateDiscount(15);
            travelBag.Carry();

            Console.ReadKey();
        }
    }
}