using BusinessHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessHouse.Services
{
    public interface IPlayerManager
    {
        List<Player> Players { get; set; }
        List<Player> CreatePlayers(int numberOfPlayers);

        Player GetPlayer(IList<Player> players, int turn);
    }
}
