using Monopoly.Models;
using System.Collections.Generic;

namespace Monopoly.Services
{
    public interface IGameBoardInitializer
    {
        GameBoard Initialize(
                    IList<Player> players,
                    IList<string> gameSpaceKeys);
    }
}
