using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessHouse.Models;

namespace BusinessHouse.Services
{
    public class GameHelper : IGameHelper
    {
        public int AdvancePlayer(Player player, int delta, int gameBoardSize)
        {
            int copy = player.Position;
            int newPosition = copy + delta;
            if (newPosition > gameBoardSize)
            {
                newPosition = newPosition - gameBoardSize;
            }
            return newPosition;
        }
    }
}
