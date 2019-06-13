using BusinessHouse.Models;
using BusinessHouse.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BusinessHouseTests.Tests
{
    public class GameHelperTests
    {
        public IGameHelper gameHelper;

        public GameHelperTests()
        {
            gameHelper = new GameHelper();
        }

        [Fact]
        public void ShouldAdvancePlayer()
        {
            Player player = new Player(1);
            player.Position = 42;
            int boardSize = 50;
            int diceValue = 10;
            int newPosition = gameHelper.AdvancePlayer(player, diceValue, boardSize);

            Assert.Equal(newPosition, 2);
        }
    }
}
