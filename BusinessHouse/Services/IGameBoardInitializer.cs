using BusinessHouse.Models;
using System.Collections.Generic;

namespace BusinessHouse.Services
{
    public interface IGameBoardInitializer
    {
        GameBoard InitializeGameBoard(IList<string> gameSpaceKeys);
    }
}
