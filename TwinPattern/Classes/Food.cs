namespace TwinPattern.Classes
{
    public enum Origin
    {
        Animal,
        Vegetal
    }
    public class Food
    {
        public Origin Type { get; set; }

        public Food(Origin type)
        {
            Type = type;
        }
    }
}
