using Monopoly.Infrastructure.Factories;
using Monopoly.Models;
using System.Collections.Generic;

namespace Monopoly.Services
{
    public class GameBoardInitializer : IGameBoardInitializer
    {
        public const int GameSpaceCount = 20;

        private readonly IGameSpaceFactory gameSpaceFactory;

        public GameBoardInitializer()
        {
            gameSpaceFactory = new GameSpaceFactory();
        }

        public GameBoard Initialize(
            IList<Player> players,
            IList<string> gameSpaceKeys)
        {
            return new GameBoard()
            {
                Players = players,
                GameSpaces = CreateGameSpaces(gameSpaceKeys)
            };         
        }

        private IList<IGameSpace> CreateGameSpaces(IList<string> gameSpaceKeys)
        {
            var gameSpaces = new List<IGameSpace>();
            for (int i = 1; i <= gameSpaceKeys.Count; i++)
            {
                var gameSpace = gameSpaceFactory.Create(gameSpaceKeys[i]);
                gameSpace.Position = i;
                gameSpaces.Add(gameSpace);
            }
            return gameSpaces;
        }
    }
}
