using Monopoly.Infrastructure.Factories;
using Monopoly.Models;
using Monopoly.Models.GameSpaces;
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
            int playersCount,
            IList<string> gameSpaceKeys)
        {
            return new GameBoard()
            {
                Players = CreatePlayers(2),
                GameSpaces = CreateGameSpaces(gameSpaceKeys)
            };         
        }

        private IList<Player> CreatePlayers(int count)
        {
            var players = new List<Player>();
            for (int i = 1; i <= count; i++)
            {
                players.Add(new Player(i));
            }
            return players;
        }

        private IList<IGameSpace> CreateGameSpaces(IList<string> gameSpaceKeys)
        {
            var gameSpaces = new List<IGameSpace>();
            for (int i = 0; i < gameSpaceKeys.Count; i++)
            {
                var gameSpace = gameSpaceFactory.Create(gameSpaceKeys[i]);
                gameSpace.Position = i+1;
                gameSpaces.Add(gameSpace);
            }
            return gameSpaces;
        }
    }
}
