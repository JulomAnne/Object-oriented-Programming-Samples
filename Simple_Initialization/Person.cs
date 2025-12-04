using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Initialization
{
    internal class Person
    {
        //Class Members
        public string name, gender;
        public int age;

        //Method to display
        public void Greet()
        {
            Console.WriteLine("Hello. I'm " + name + " and I'm " + age + " years old. I'm a " + gender);
        }
    }
}