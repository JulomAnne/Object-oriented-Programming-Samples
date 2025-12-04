using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kris Anne J. Ybañez       IT306       Age_Assignment 

            string again = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter Age: ");
                Console.ForegroundColor= ConsoleColor.White;
                int age = int.Parse(Console.ReadLine());

                if (age < 12)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("You're a kid!");
                }
                else if (age >= 12 && age < 20)
                {
                    Console.ForegroundColor= ConsoleColor.Cyan;
                    Console.WriteLine("You're a Teenager!");
                }
                else if (age >= 20 && age < 60)
                {
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine("You're an Adult!");
                }
                else if (age >= 60 && age <= 110)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You're a Senior!");
                }
                else if (age > 110)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("You're Ancient!");
                }
                    Console.ForegroundColor = ConsoleColor.White;
                Console.Write("_______________________\nWanna try again? (Y/N): ");
                Console.ForegroundColor = ConsoleColor.Green;
                again = Console.ReadLine().ToUpper();
                Console.Clear();
            }
            while (again == "Y");
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hasta Luego!");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ReadLine();
            }
        }
    }
}
