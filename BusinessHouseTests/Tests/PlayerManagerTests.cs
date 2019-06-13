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
    public class PlayerManagerTests
    {
        PlayerManager playerManager;
        public PlayerManagerTests()
        {
            playerManager = new PlayerManager();
        }

        [Fact]
        public void ShouldCreatePlayers()
        {
            //Arrange

            int numberOfPlayers = 2;
            //Act

            var players = playerManager.CreatePlayers(numberOfPlayers);

            //Assert
            Assert.Equal(players.Count, 2);
        }

        [Fact]
        public void ShouldGetCorrectPlayer()
        {
            var players = new List<Player>();
            players.Add(new Player(1));
            players.Add(new Player(2));
            players.Add(new Player(3));

            var player = playerManager.GetPlayer(players, 2);

            Assert.Equal(player.ID, 3);
        }
    }
}
