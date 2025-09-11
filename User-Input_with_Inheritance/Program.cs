using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ybañez_InheritanceUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Name: Kris Anne J. Ybañez
        //Section: IT306
        //Title: Inheritance with User Input

        Main:
            Console.Clear();
            //Instantiate an object
            Bag myBag = new Bag();
            Bag aHandBag = new HandBag("Hand Bag", "Red");
            Bag aShoulderBag = new ShoulderBag("Shoulder Bag", "Violet");

            //Starting Dialogue
            Console.WriteLine("The Store has three bags available today!");
            Console.Write("Proceed to enter? "); //Requesting User Input
            Console.ForegroundColor = ConsoleColor.Green;
            string ans = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            //Primary Phase
            if (ans == "Yes" || ans == "yes" || ans == "Y" || ans == "y" || ans == "Ye" || ans == "ye"
                || ans == "absolutely" || ans == "Absolutely" || ans == "Of course" || ans == "of course"
                || ans == "Why not" || ans == "Why not?" || ans == "why not" || ans == "why not?" ||
                ans == "Sure" || ans == "sure")
            {
                goto Main2;
            }
            else //If user = Not interested
            {
                Console.Clear();
                Console.WriteLine("You're wasting space by LOITERING in MY store.");
                Console.WriteLine("GET OUT NOW!!!...");
                Console.ReadKey();
                return;
            }

        Main2:
            Console.Clear();
            //Secondary Phase
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wonderful! Welcome!... Just look in front of you.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("A. Bag\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("B. Hand Bag\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("C. Shoulder Bag\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("What would you like to buy? "); //Requesting User Input
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">> ");
            string obj = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            //Method to display object details
            if (obj == "Bag" || obj == "bag" || obj == "A" || obj == "A." || obj == "a" || obj == "a.")
            {
                Console.Clear();
                myBag.Style = "Messenger Bag";
                Console.ForegroundColor = ConsoleColor.Yellow;
                myBag.Color = "Yellow";
                Console.ForegroundColor = ConsoleColor.White;
                myBag.DisplayInfo();
            }
            else if (obj == "Hand" || obj == "hand" || obj == "Hand Bag" || obj == "hand bag" || obj == "B" || obj == "B." || obj == "b" || obj == "b.")
            {
                Console.Clear();
                aHandBag.DisplayInfo();
            }
            else if (obj == "Shoulder" || obj == "shoulder" || obj == "Shoulder Bag" || obj == "shoulder bag" || obj == "C" || obj == "C." || obj == "c" || obj == "c.")
            {
                Console.Clear();
                aShoulderBag.DisplayInfo();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("(Let's try this again!...)");
                Console.ReadKey();
                goto Main2;
            }

            //Final Phase
            Console.Write("\nDo you wish to buy it? "); //Requesting User Input
            Console.ForegroundColor = ConsoleColor.Green;
            string respo = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            //Ending Dialogue
            if (respo == "Yes" || respo == "yes" || respo == "Y" || respo == "y" || respo == "Ye" || respo == "ye"
                || respo == "Absolutely" || respo == "absolutely" || respo == "Of course" || respo == "of course"
                || respo == "Why not" || respo == "Why not?" || respo == "why not" || respo == "why not?" ||
                respo == "Sure" || respo == "sure")
            {
                Console.Clear();
                Console.WriteLine("Thanks! Come again! (UvU)/<3");
                Console.ReadLine();
                goto Main;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("GET OUT OF MY TOTALLY AWESOME STORE!!!");
                Console.ReadKey();
                return;
            }
        }
    }
}
