using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Insttantiate an object
            Student normal = new Student();
            Irregular person = new Irregular();
            Working scholar = new Working();

            //Method of display
            normal.ComputeTuitionFee();
            person.ComputeTuitionFee();
            scholar.ComputeTuitionFee();
            Console.ReadLine();
        }
    }
}
