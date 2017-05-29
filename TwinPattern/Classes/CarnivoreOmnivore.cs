using System;
using System.Collections.Generic;
using System.Text;

namespace TwinPattern.Classes
{
    public class CarnivoreOmnivore : Carnivore
    {
        public HerbivoreOmnivore twin{ get; set; }

        public CarnivoreOmnivore()
        {
            twin = new HerbivoreOmnivore(this);
        }

        public CarnivoreOmnivore(HerbivoreOmnivore omnivore)
        {
            twin = omnivore;
        }
        
        public string EatFood(Origin foodType)
        {
            return (foodType == Origin.Animal) ? Eat() : twin.Eat();
        }
    }
}
