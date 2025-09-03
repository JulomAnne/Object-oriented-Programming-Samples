using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ybañez_EncapsulationUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Kris Anne J. Ybañez
        //Section: IT306
        //Exercise Title: Applying Encapsulation with User

        Main:
            Console.Clear();
            //Instantiate an object
            Bag bag1 = new Bag();

            //Declare fields on the properties of Bag class
            bag1.Style = "Messenger Bag";
            bag1.Color = "Yellow";

            //Main
            Console.WriteLine("The Store only has one bag available because of Human Consumption...");
            Console.Write("Yes, I said what I said. Do you dare enter still? ");
            Console.ForegroundColor = ConsoleColor.Green;
            string ans = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            //Method to display object details
            if (ans == "yes" || ans == "Yes" || ans == "Y" || ans == "y")
            {
                Console.WriteLine("Wonderful! Welcome!... Just look in front of you.");
                bag1.DisplayInfo();
            }
            else //If user is not interested in window shopping-
            {
                Console.WriteLine("You're wasting space by loitering in my store. So---");
                Console.Write("GET OUT NOW!!!...");
                Console.WriteLine("...please.");
                Console.ReadLine();
                return;
            }
            Console.Write("\nDo you wish to buy it? ");
            Console.ForegroundColor = ConsoleColor.Green;
            string respo = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            if (respo == "yes" || respo == "Yes" || respo == "Y" || respo == "y")
            {
                Console.WriteLine("Thanks! Come again!");
                Console.ReadLine();
                goto Main;
            }
            else
            {
                Console.WriteLine("GET OUT OF MY TOTALLY AWESOME STORE!!!");
                Console.ReadLine();
                return;
            }
        }
    }
}