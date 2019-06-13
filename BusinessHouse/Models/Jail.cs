namespace BusinessHouse.Models
{
    public class Jail : IGameSpace
    {
        private const int JailFine = 200;
        public Player PerformAction(Player player, IGameSpace gameSpace = null)
        {
            player.Balance -= JailFine;
            Banker.Balance += JailFine;
            return player;
        }
    }
}
