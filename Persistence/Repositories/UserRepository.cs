using Core.Domain;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly LuftbornContext _luftbornContext;

        public UserRepository(LuftbornContext context)
            : base(context)
        {
            _luftbornContext = _context as LuftbornContext;
        }

        public async Task<IEnumerable<Gender>> GetGendersLookupAsync()
        {
            return await _luftbornContext.Genders.ToListAsync();
        }
    }
}
