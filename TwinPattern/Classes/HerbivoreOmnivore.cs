namespace TwinPattern.Classes
{
    public class HerbivoreOmnivore : Herbivore
    {
        public CarnivoreOmnivore twin { get; set; }
        public HerbivoreOmnivore()
        {
            twin = new CarnivoreOmnivore(this);
        }

        public HerbivoreOmnivore(CarnivoreOmnivore omnivore)
        {
            twin = omnivore;
        }

        public string EatFood(Origin foodType)
        {
            return (foodType == Origin.Vegetal) ? Eat() : twin.Eat();
        }
    }
}
