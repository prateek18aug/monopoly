using Monopoly.Models.GameSpaces;
using System.Collections.Generic;

namespace Monopoly.Models
{
    public class Player
    {
        public const int InitialPlayerMoney = 1500;

        public int Id { get; set; }

        public int Money { get; set; }

        public int Position { get; set; }

        public List<Asset> Assets { get; set; }

        public Player(int id)
        {
            Id = id;
            Money = 1500;
        }

        public void BuyAsset(Asset asset)
        {
            asset.Owner = this;
            Assets.Add(asset);
        }
    }
}