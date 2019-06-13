using System.Collections.Generic;
using BusinessHouse.Models;

namespace BusinessHouse.Services
{
    public class PlayerManager : IPlayerManager
    {
        public List<Player> Players { get; set; }
        public List<Player> CreatePlayers(int numberOfPlayers)
        {
            Players = new List<Player>();
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                var player = new Player(i);
                Players.Add(player);
            }
            return Players;
        }

        public Player GetPlayer(IList<Player> players, int turn)
        {
            if (turn >= players.Count)
            {
                turn = 0;
            }
            return players[turn];
        }
    }
}
