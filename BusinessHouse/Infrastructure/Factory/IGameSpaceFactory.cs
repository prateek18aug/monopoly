using BusinessHouse.Models;
namespace BusinessHouse.Infrastructure.Factory
{
    public interface IGameSpaceFactory
    {
        IGameSpace CreateInstance(string gameSpaceType);
    }
}
