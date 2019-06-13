using System.Collections.Generic;
using BusinessHouse.Infrastructure.Factory;
using BusinessHouse.Models;

namespace BusinessHouse.Services
{
    public class GameBoardInitializer : IGameBoardInitializer
    {
        private IGameSpaceFactory gameSpaceFactory;

        private GameBoard gameBoard;
        public GameBoardInitializer()
        {
            gameSpaceFactory = new GameSpaceFactory();
        }
        public GameBoard InitializeGameBoard(IList<string> gameSpaceKeys)
        {
            gameBoard = new GameBoard()
            {
                GameSpaces = CreateGameSpaces(gameSpaceKeys)
            };

            return gameBoard;
        }
        private List<IGameSpace> CreateGameSpaces(IList<string> gameSpaceKeys)
        {
            var gameSpaces = new List<IGameSpace>();
            foreach (var gameSpace in gameSpaceKeys)
            {
                var gs = gameSpaceFactory.CreateInstance(gameSpace);
                gameSpaces.Add(gs);
            }
            return gameSpaces;
        }


    }
}