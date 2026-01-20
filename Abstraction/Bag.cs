using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Bag //Abstract Class
    {
        //Common properties
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        //Parameterized Constructor
        public Bag(string brand, string hue, double price)
        {
            Brand = brand;
            Color = hue;
            Price = price;
        }

        //Abstract method
        public abstract void DisplayDetails();
        public abstract void CalculateDiscount(double percent);
        public void Carry()
        {
            Console.WriteLine("Carrying the bag around...");
        }
    }

    class SchoolBag : Bag //Derived Class
    {
        //Property
        public int NumOfCompartments { get; set; }

        //Parameterized Constructor
        public SchoolBag(string brand, string hue, double price, int num): base(brand, hue, price)
        {
            NumOfCompartments = num;
        }

        //Implementation of abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine("\n--- School Bag Details ---");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Price: ₱{Price}");
            Console.WriteLine($"Compartments: {NumOfCompartments}");
        }

        public override void CalculateDiscount(double percent)
        {
            double discount = Price * (percent / 100);
            double finalPrice = Price - discount;
            Console.WriteLine($"Discount: {percent}%");
            Console.WriteLine($"Final Price: ₱{finalPrice}");
        }
    }

    class TravelBag : Bag //Derived Class
    {
        //Property
        public double Capacity { get; set; }

        //Parameterized Constructor
        public TravelBag(string brand, string hue, double price, double cap) : base(brand, hue, price)
        {
            Capacity = cap;
        }

        //Implementation of abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine("\n--- Travel Bag Details ---");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Price: ₱{Price}");
            Console.WriteLine($"Capacity: {Capacity} liters");
        }

        public override void CalculateDiscount(double percent)
        {
            double discount = (Price * (percent / 100)) + 100; //Bonus ₱100 off
            double finalPrice = Price - discount;
            Console.WriteLine($"Discount: {percent}% + ₱100 Bonus");
            Console.WriteLine($"Final Price: ₱{finalPrice}");
        }
    }
}