using System;
using YourFavoriteThings.FavoriteThings;

namespace YourFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("Slothy", "Brown");
            Animal animal2 = new Animal("Slow Boi", "Light Brown");
            Car car1 = new Car("Ford Raptor", "Black");
            Car car2 = new Car("Toyota 4Runner", "Gunmetal Gray");
            Food food1 = new Food("Spaghetti", "Italian");
            Food food2 = new Food("Pizza", "Italian");
            Game game1 = new Game("Settlers of Catan(ka-tah-n)", "Board Game");
            Game game2 = new Game("Dauntless", "Video Game");
        }
    }
}
