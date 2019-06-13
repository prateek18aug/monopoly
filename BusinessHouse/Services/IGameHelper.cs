using BusinessHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessHouse.Services
{
    public interface IGameHelper
    {
        int AdvancePlayer(Player player, int delta, int gameBoardSize);
    }
}
