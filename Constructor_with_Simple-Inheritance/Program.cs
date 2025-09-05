using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ybañez_InheritanceWithConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Kris Anne J. Ybañez
            //Section: IT306
            //Title: Simple Inheritance with Constructor

            //Instantiate an object for the Student Class
            Student student1 = new Student("Aliza", "IT");
            student1.BasicInfo(); //Call method to display BasicInfo

            RegularStudent student2 = new RegularStudent("Amira", "IT", "IT103P");
            student2.SectionEnrolled(); //Call method to display SectionEnrolled

            IrregularStudent student3 = new IrregularStudent("Amira", "IT", 21);
            student3.EnrolledSemUnits(); //Call method to display UnitsEnrolled
            Console.ReadKey(); //End =)
        }
    }
}