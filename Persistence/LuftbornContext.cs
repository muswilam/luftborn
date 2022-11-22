using Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class LuftbornContext : DbContext
    {
        public LuftbornContext()
        {

        }

        public LuftbornContext(DbContextOptions options)
            : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }
    }
}
