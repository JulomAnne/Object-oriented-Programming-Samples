using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Polymorphism
{
    class Student
    {
        //Fields
        public double MisFee = 2599;
        public virtual void ComputeTuitionFee() //Method
        {
            Console.WriteLine("~~~~~~~~STUDENT FEE");
            Console.WriteLine($"\tMiscellaneous Fee: {MisFee}\n");
        }
    }

    class Irregular : Student
    {
        //Fields
        public double unitsEnrolled = 21;
        public double ratePerUnit = 3;
        public override void ComputeTuitionFee() //Method
        {
            Console.WriteLine("~~~~~~~~IRREGULAR STUDENT FEE");
            double fee = (unitsEnrolled / ratePerUnit) * MisFee;
            Console.WriteLine($"\tMiscellaneous Fee w/ units: {fee}\n");
        }
    }

    class Working : Student
    {
        public override void ComputeTuitionFee() //Method
        {
            Console.WriteLine("~~~~~~~~WORKING STUDENT FEE");
            double discount = MisFee - (0.615 * MisFee);
            Console.WriteLine($"\tMiscellaneous Fee w/ Discount: {discount}");
        }
    }
}