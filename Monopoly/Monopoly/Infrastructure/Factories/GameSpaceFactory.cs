using Monopoly.Models;
using System;
using System.Collections.Generic;

namespace Monopoly.Infrastructure.Factories
{
    public class GameSpaceFactory : IGameSpaceFactory
    {
        private readonly IDictionary<string, Type> gameSpaceMappings = new Dictionary<string, Type>
        {
            { "E", typeof(EmptyGameSpace) },
            { "H", typeof(Hotel) },
            { "L", typeof(Lottery) },
            { "J", typeof(Jail) },
        };

        public IGameSpace Create(string gameSpaceKey)
        {
            if (!gameSpaceMappings.ContainsKey(gameSpaceKey))
            {
                return null;
            }

            var gameSpaceType = gameSpaceMappings[gameSpaceKey];

            return (IGameSpace)Activator.CreateInstance(gameSpaceType);
        }
    }
}
