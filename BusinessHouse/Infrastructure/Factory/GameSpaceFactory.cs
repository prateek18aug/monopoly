using BusinessHouse.Models;
using System;
using System.Collections.Generic;

namespace BusinessHouse.Infrastructure.Factory
{
    public class GameSpaceFactory : IGameSpaceFactory
    {
        Dictionary<string, Type> types;
        public GameSpaceFactory()
        {
            LoadTypes();
        }

        private void LoadTypes()
        {
            types = new Dictionary<string, Type>();
            types.Add("J", typeof(Jail));
            types.Add("E", typeof(Empty));
            types.Add("H", typeof(Hotel));
            types.Add("L", typeof(Lottery));
        }

        public IGameSpace CreateInstance(string gameSpaceType)
        {
            if (types.ContainsKey(gameSpaceType))
            {
                return Activator.CreateInstance(types[gameSpaceType]) as IGameSpace;
            }
            else
            {
                return null;
            }
        }
    }
}
