using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_with_Encapsulation
{
    internal class Bag
    {
        //Declare the fields of the Bag class
        private string name;
        private string color;

        //Set the property values
        public string Style
        {
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //Method to display object details
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Style} \nColor: {Color}");
            Console.WriteLine($"It is a {Color} {Style}!");
        }
    }
}