using Monopoly.Models.GameSpaces;

namespace Monopoly.Infrastructure.Factories
{
    public interface IGameSpaceFactory
    {
        IGameSpace Create(string gameSpaceKey);
    }
}
