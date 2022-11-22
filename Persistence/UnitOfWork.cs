using Core;
using Core.Repositories;
using System.Threading.Tasks;

namespace Persistence
{
    public class UnitOfWorK : IUnitOfWork
    {
        private readonly LuftbornContext _context;

        public UnitOfWorK(LuftbornContext context,
                          IUserRepository userRepository)
        {
            _context = context;
            Users = userRepository;
        }

        public IUserRepository Users { get; set; }

        public async Task<bool> CommitAsync() =>
            await _context.SaveChangesAsync() > 0;
    }
}
