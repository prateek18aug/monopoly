using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessHouse.Models
{
    public class Lottery : IGameSpace
    {
        public const int LotteryPrize = 200;
        public Player PerformAction(Player player)
        {
            player.Balance += LotteryPrize;
            Banker.Balance -= LotteryPrize;
            return player;
        }
    }
}
