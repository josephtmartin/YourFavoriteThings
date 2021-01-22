using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.FavoriteThings
{
    public class Food
    {
        //Properties
        public string Name { get; set; }
        public string Type { get; set; }
        //Constuctor
        public Food(string name, string type)
        {
            Name = name;
            Type = type;
            Console.WriteLine($"The name of the food is {Name} and the type of food is {Type}");
        }

        //Methods
        public void Serve(string action)
        {
            Console.WriteLine($"The food is {action}");
        }
        public void Seasoning(string action)
        {
            Console.WriteLine($"The food is {action}");
        }
    }
}
