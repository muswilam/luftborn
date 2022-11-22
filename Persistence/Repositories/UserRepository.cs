using Core.Domain;
using Core.Repositories;

namespace Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(LuftbornContext context)
            : base(context)
        {

        }

        public User GetUser(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
