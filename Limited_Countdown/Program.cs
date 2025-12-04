using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Limited_Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Main:
            Console.Clear();
            int num; //Variable
            Console.WriteLine("The program will determine what type of number and display it ranges.\n");

            Console.Write("Enter a number: "); //Input
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1 || num == 3 || num == 5 || num == 7 || num == 9)
            {
                Console.WriteLine($"The number {num} is an odd number!");
            }
            else if (num == 2 || num == 4 || num == 6 || num == 8 || num == 10)
            {
                Console.WriteLine($"The number {num} is an even number!");
            }
            else
            {
                Console.WriteLine("The numerical limit is exactly 10.");
                Console.ReadLine();
                goto Main;
            }
            for (; num >= 0; num--)
            {
                Console.Write($"\t{num}\n");
                num--;
                Thread.Sleep(555);
            }
            Console.Write("\nTry Again (Y/N)? ");
            string retry = Console.ReadLine();
            if (retry == "y" || retry == "Y")
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