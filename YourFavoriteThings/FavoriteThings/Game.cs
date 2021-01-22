using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.FavoriteThings
{
    public class Game
    {
        //Properties
        public string Name { get; set; }
        public string Type { get; set; }
        //Constuctor
        public Game(string name, string type)
        {
            Name = name;
            Type = type;
            Console.WriteLine($"The name of the game is {Name} and the type of game is {Type}");
        }
        //Methods
        public void Play(string action)
        {
            Console.WriteLine($"The game is {action}");
        }
        public void GetAngry(string action)
        {
            Console.WriteLine($"The game made Joe {action}");
        }
    }
}
