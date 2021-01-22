using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.FavoriteThings
{
    public class Car
    {
        //Properties
        public string Name { get; set; }
        public string Color { get; set; }
        //Constuctor
        public Car(string name, string type)
        {
            Name = name;
            Color = type;
            Console.WriteLine($"The name of the car is {Name} and the color of the car is {Color}");
        }
        //Methods
        public void Open(string action)
        {
            Console.WriteLine($"The car doors {action}");
        }
        public void Drive(string action)
        {
            Console.WriteLine($"The car {action}");
        }
    }
}
