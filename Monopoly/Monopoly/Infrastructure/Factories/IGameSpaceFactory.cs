using Monopoly.Models;

namespace Monopoly.Infrastructure.Factories
{
    public interface IGameSpaceFactory
    {
        IGameSpace Create(string gameSpaceKey);
    }
}
