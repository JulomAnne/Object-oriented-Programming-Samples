using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ybanez_RepetitionStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Kris Anne J. Ybanez     IT306     Print 10 numbers and also print the sum of all numbers

            Console.WriteLine("ENTER THREE NUMBERS :P\n");

            
            //VARIABLE
            double num1, num2, num3, sum, diff, prod, quo, mod, sumAll;

            //INPUT
            Console.Write("Primary number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Secondary number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tertiary number: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            //PROCESS
            for (int e = 1; e < 11; e++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\n\t{e}");
                Thread.Sleep(555);
            }
            Console.WriteLine("\n\tLoading...");
            sum = num1 + num2 + num3;
            diff = num1 - num2 - num3;
            prod = num1 * num2 * num3;
            quo = num1 / num2 / num3;
            mod = num1 % num2 % num3;
            sumAll = sum + diff + prod + quo + mod;

            //OUTPUT
            Thread.Sleep(900);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\t{num1} + {num2} + {num3}");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sum: {sum}");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\t{num1} - {num2} - {num3}");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Difference: {diff}");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\t{num1} * {num2} * {num3}");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Product: {prod}");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\t{num1} / {num2} / {num3}");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Quotient: {quo}");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\t{num1} % {num2} % {num3}");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Modulo: {mod}");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\tSUM OF ALL: {sumAll}");
            Console.ReadKey();
        }
    }
}