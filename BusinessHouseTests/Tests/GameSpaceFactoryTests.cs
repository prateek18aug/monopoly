using BusinessHouse.Infrastructure.Factory;
using BusinessHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BusinessHouseTests.Tests
{
    public class GameSpaceFactoryTests
    {
        private IGameSpaceFactory gameSpaceFactory;
        public GameSpaceFactoryTests()
        {
            this.gameSpaceFactory = new GameSpaceFactory();
        }

        [Fact]
        public void ShouldReturnInstanceForValidType()
        {
            var type = "J";
            var gameSpace = this.gameSpaceFactory.CreateInstance(type);
            Assert.NotNull(gameSpace);
        }

        [Fact]
        public void ShouldReturnNullForInvalidType()
        {
            var type = "p";
            var gameSpace = this.gameSpaceFactory.CreateInstance(type);
            Assert.Null(gameSpace);
        }


    }
}
