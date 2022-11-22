using Core.Domain;

namespace Core.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int id);
    }
}
