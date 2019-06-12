using System.Collections.Generic;

namespace Monopoly.Models
{
    public class GameBoard
    {
        public IList<IGameSpace> GameSpaces { get; set; }

        public IList<Player> Players { get; set; }

        public IGameSpace GetGameSpace(int position)
        {
            return GameSpaces[position];
        }
    }
}
