using Monopoly.Infrastructure.Extensions;
using Monopoly.Models.GameSpaces;
using System.Collections.Generic;

namespace Monopoly.Models
{
    public class GameBoard
    {
        public GameBoard()
        {
            CurrentPlayerId = 1;
        }

        public IList<IGameSpace> GameSpaces { get; set; }

        public IList<Player> Players { get; set; }

        public int CurrentPlayerId { get; set; }

        public IGameSpace GetGameSpace(int position)
        {
            return GameSpaces[position];
        }

        public Player GetNextPlayer()
        {
            return Players.NextOrFirst(CurrentPlayerId);
        }
    }
}
