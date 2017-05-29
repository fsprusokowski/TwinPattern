using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
