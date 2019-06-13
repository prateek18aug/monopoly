using System.Collections.Generic;

namespace BusinessHouse.Models
{
    public class Player
    {
        public IList<Property> properties;
        public int Position { get; set; }
        public int Balance { get; set; }

        public int AssetValue { get; set; }

        public int ID { get; set; }
        public Player(int ID)
        {
            Balance = 1500;
            Position = 0;
            properties = new List<Property>();
            this.ID = ID;
            AssetValue = 0;
        }
    }
}
