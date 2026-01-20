using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_with_Parameterized_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Name: Kris Anne J. Ybañez
        //Section: IT306
        //Title: User Input with Constructor

        Main:
            Console.Clear();
            //Instantiating objects and declaring values
            Dresses dress1 = new Dresses("Blue", "Victorian", 12000);
            Dresses dress2 = new Dresses("Silver", "Ball", 40000);
            Dresses dress3 = new Dresses("Black", "Evening", 25000);

            //Main
            Console.Clear();
            Console.WriteLine("The program will present to you three dresses available for purchase.\n");
            Console.WriteLine("\tA. Victoiran Gown\n\tB. Ball Gown\n\tC. Evening Gown\n");
            Console.Write("*~+/Which dress are you interested? ");

            string ans = Console.ReadLine();
            if (ans == "Victorian")
            {
                dress1.DressDisplay();
            }
            else if (ans == "Ball")
            {
                dress2.DressDisplay();
            }
            else if (ans == "Evening")
            {
                dress3.DressDisplay();
            }

            Console.Write("Proceed to purchase? ");
            string buy = Console.ReadLine();
            if (buy == "yes")
            {
                Console.WriteLine("Purchase Successful!");
            }
            else
            {
                Console.WriteLine("Get out.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Want to buy again?");
            string buyagain = Console.ReadLine();

            if (buyagain == "yes")
            {
                goto Main;
            }
            else
            {
                Console.WriteLine("Have a good day then. Bye now.");
                Console.ReadLine();
                return;
            }
        }
    }
}