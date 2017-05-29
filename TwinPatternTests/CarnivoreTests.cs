using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwinPattern.Classes;

namespace TwinPattenTest
{
    
    [TestClass]
    public class CarnivoreTests
    {
        [TestMethod]
        public void CarnivoreTwinEatingMeat()
        {
            var omnivore = new CarnivoreOmnivore();
            var meat = new Food(Origin.Animal);

            string eatingMessage = omnivore.EatFood(meat.Type);
            string eatingAnimalMessage = "Eating animal origin food.";

            Assert.AreEqual(eatingAnimalMessage,eatingMessage,true);
        }

        [TestMethod]
        public void CarnivoreTwinEatingPlant()
        {
            var omnivore = new CarnivoreOmnivore();
            var plant = new Food(Origin.Vegetal);

            string eatingMessage = omnivore.EatFood(plant.Type);
            string eatingVegetalMessage = "Eating plant origin food.";

            Assert.AreEqual(eatingVegetalMessage, eatingMessage, true);
        }
    }
}
