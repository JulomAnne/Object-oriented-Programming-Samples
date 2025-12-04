using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Initialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kris Anne J. Ybañez   IT306   EXER_01: Creating a Class

            Person person1 = new Person();

            //Initialization of fields
            person1.name = "Kris Anne";
            person1.age = 16;
            person1.gender = "Girl";
            person1.Greet();
            Console.ReadLine();
        }
    }
}