using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an object for the Student Class
            Student student1 = new Student
            {
                Name = "Aliza",
                Program = "IT"
            };
            student1.BasicInfo(); //Call method to display BasicInfo

            RegularStudent student2 = new RegularStudent
            {
                Name = "Amira",
                Program = "IT",
                Section = "IT103P"
            };
            student2.BasicInfo();       //Call method to display BasicInfo
            student2.SectionEnrolled(); //Call method to display SectionEnrolled

            IrregularStudent student3 = new IrregularStudent
            {
                Name = "Akira",
                Program = "IT",
                UnitsEnrolled = "21"
            };
            student3.BasicInfo();        //Call method to display BasicInfo
            student3.EnrolledSemUnits(); //Call method to display UnitsEnrolled
            Console.ReadKey();
        }
    }
}