namespace Monopoly.Models.GameSpaces
{
    public class Asset : IGameSpace
    {
        public int Position { get; set; }

        public Player Owner { get; set; }

        public int Rent { get; set; }
    }
}
