using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_with_Inheritance
{
    class Bag //Base Class
    {
        //Declaring fields
        public string Style { get; set; }
        public string Color { get; set; }

        public virtual void DisplayInfo() //Method of display
        {
            Console.WriteLine($"Name: {Style} \nColor: {Color}\n");
            Console.WriteLine($"This is a {Color} {Style}!");
        }
    }

    class HandBag : Bag //Derived Class
    {
        public HandBag(string name, string color) //Constructor
        {
            Style = name;
            Color = color;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Style} \nColor: {Color}\n");
            Console.WriteLine($"This is a {Color} {Style}!");
        }
    }

    class ShoulderBag : Bag //Derived Class
    {
        public ShoulderBag(string name, string color) //Constructor
        {
            Style = name;
            Color = color;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Style} \nColor: {Color}\n");
            Console.WriteLine($"This is a {Color} {Style}!");
        }
    }
}
