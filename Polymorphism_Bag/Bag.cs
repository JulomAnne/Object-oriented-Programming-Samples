using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ybañez_Polymorphism
{
    public class Bag //Base Class
    {
        //Bag Class Properties
        public string Brand { get; set; }
        public double Price { get; set; }

        public Bag(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        //Virtual Method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Price: ₱{Price}");
        }
    }

    public class SchoolBag : Bag //Derived Class
    {
        public int Compartments { get; set; } //SchoolBag Class Property

        public SchoolBag(string brand, double price, int compartments) : base(brand, price)
        {
            Compartments = compartments;
        }

        //Override Method
        public override void DisplayInfo()
        {
            Console.WriteLine("--- School Bag ---");
            base.DisplayInfo();
            Console.WriteLine($"Compartments: {Compartments}");
            Console.WriteLine();
        }
    }

    public class TravelBag : Bag //Derived Class
    {
        public int Capacity { get; set; } //TravelBag Class Property

        public TravelBag(string brand, double price, int capacity) : base(brand, price)
        {
            Capacity = capacity;
        }

        // Override DisplayInfo()
        public override void DisplayInfo()
        {
            Console.WriteLine("--- Travel Bag ---");
            base.DisplayInfo();
            Console.WriteLine($"Capacity: {Capacity} liters");
            Console.WriteLine();
        }
    }

}
