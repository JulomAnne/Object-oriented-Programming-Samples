using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_with_Inheritance
{
    class Student //Base Class
    {
        //Setting property values for Student class
        public string Name;
        public string Program;
        public Student(string identity, string major) //Constructor
        {
            Name = identity;
            Program = major;
        }
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
        public string Section;
        public RegularStudent(string identity, string major, string classSec) : base(identity, major) //Constructor
        {
            Section = classSec;
        }
        //Method to display Regular Student information
        public void SectionEnrolled()
        {
            BasicInfo();
            Console.WriteLine($"Section: {Section}");
        }
    }

    class IrregularStudent : Student //Derived Class
    {
        //Setting property values for the IrregularStudent class
        public int UnitsEnrolled;
        public IrregularStudent(string identity, string major, int enrolledUnits) : base(identity, major) //Constructor
        {
            UnitsEnrolled = enrolledUnits;
        }
        //Method to display Irregular Student information
        public void EnrolledSemUnits()
        {
            BasicInfo();
            Console.WriteLine($"Enrolled Units: {UnitsEnrolled}");
        }
    }
}