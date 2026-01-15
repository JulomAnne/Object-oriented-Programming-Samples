using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Simple_Inheritance
{
    class Student //Base Class
    {
        //Setting property values for Student class
        public string Name { get; set; }
        public string Program { get; set; }

        //Method to display Student information
        public void BasicInfo()
        {
            Console.WriteLine("\n------Student Information-----\n");
            Console.WriteLine($"Name: {Name}    \nProgram: {Program}");
        }
    }

    class RegularStudent : Student //Derived Class
    {
        //Setting property values for the RegularStudent class
        public string Section { get; set; }

        //Method to display Regular Student information
        public void SectionEnrolled()
        {
            Console.WriteLine($"Section: {Section}");
        }
    }

    class IrregularStudent : Student //Derived Class
    {
        //Setting property values for the IrregularStudent class
        public string UnitsEnrolled { get; set; }

        //Method to display Irregular Student information
        public void EnrolledSemUnits()
        {
            Console.WriteLine($"Enrolled Units: {UnitsEnrolled}");
        }
    }
}