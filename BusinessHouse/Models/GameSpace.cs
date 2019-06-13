using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessHouse.Models
{
    public interface IGameSpace
    {
        Player PerformAction(Player player);
    }
}
