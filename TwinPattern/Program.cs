using System;
using TwinPattern.Classes;

namespace TwinPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var omnivore = new CarnivoreOmnivore();
            var meat = new Food(Origin.Animal);
            var plant = new Food(Origin.Vegetal);

            Console.WriteLine("Carnivore Twin eating Meat and Delegating plant food for Herbivore Twin.");
            Console.WriteLine(omnivore.EatFood(meat.Type));
            Console.WriteLine(omnivore.EatFood(plant.Type));

            Console.ReadKey();
        }
    }
}
