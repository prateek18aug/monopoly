using Monopoly.Models;
using System.Collections.Generic;

namespace Monopoly.Services
{
    public interface IGameBoardInitializer
    {
        GameBoard Initialize(int playersCount, IList<string> gameSpaceKeys);
    }
}
