using BusinessHouse.Infrastructure.Enum;
using BusinessHouse.Services;
using System.Linq;

namespace BusinessHouse.Models
{
    public class Hotel : Property, IGameSpace
    {
        HotelType hotelType;
        int worth;
        int hotelRent = 200;
        int hotelCost = 400;
        private IPlayerManager playerManager;


        public Hotel()
        {
            hotelType = HotelType.Default;
            worth = 200;
        }
        public Player PerformAction(Player player)
        {
            if (this.owner == null)
            {
                if (player.Balance > hotelCost)
                {
                    player.Balance -= hotelCost;
                    player.AssetValue = hotelCost;
                    Banker.Balance += hotelCost;
                    this.owner = player;
                }
            }
            else if (this.owner.ID != player.ID)
            {
                player.Balance -= hotelRent;

            }
            return player;
        }
    }
}
