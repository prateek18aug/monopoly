using System.Collections.Generic;

namespace BusinessHouse.Models
{
    public class GameBoard
    {
        public IList<IGameSpace> GameSpaces { get; set; }
        public IGameSpace GetGameSpace(int position)
        {
            return GameSpaces[position];
        }
    }
}
