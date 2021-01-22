using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.FavoriteThings
{
    class Animal
    {
        //Properties
        public string Name { get; set; }
        public string Color { get; set; }

        private bool _isHungry = true;
        //Constuctor
        public Animal(string name, string type)
        {
            Name = name;
            Color = type;
            Console.WriteLine($"The name of the animal is {Name} and the color of the animal is {Color}");
        }

        //Methods
        public void Eat(string foodType)
        {
            if (_isHungry)
            {
                Console.WriteLine($"The sloth slowly munches on the {foodType}");
                _isHungry = false;
            }
            else
            {
                Console.WriteLine("The sloth slowly moves away");
            }
        }
        public void Move(string action)
        {
            Console.WriteLine($"The sloth is slowly {action}");
        }
    }
}
