using tutorialProject.Models;

namespace tutorialProject.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> Countries{get;}
        IGenericRepository<Hotel> Hotels { get; }
        Task Save();

    }
}
