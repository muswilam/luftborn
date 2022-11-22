using Core.Repositories;
using System.Threading.Tasks;

namespace Core
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }

        Task<bool> CommitAsync();
    }
}
