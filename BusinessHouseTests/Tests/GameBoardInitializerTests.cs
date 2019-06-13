using BusinessHouse.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BusinessHouseTests.Tests
{
    public class GameBoardInitializerTests
    {
        IGameBoardInitializer gameBoardInitializer;
        public GameBoardInitializerTests()
        {
            gameBoardInitializer = new GameBoardInitializer();
        }

        [Fact]
        public void ShouldInitializeCorrectGameBoard()
        {
            var gameSpaceKeys = new List<string>();
            gameSpaceKeys.Add("J");
            gameSpaceKeys.Add("J");
            gameSpaceKeys.Add("H");
            gameSpaceKeys.Add("H");
            gameSpaceKeys.Add("L");
            gameSpaceKeys.Add("L");
            var board = gameBoardInitializer.InitializeGameBoard(gameSpaceKeys);
            Assert.Equal(board.GameSpaces.Count(), gameSpaceKeys.Count());
        }
    }
}
