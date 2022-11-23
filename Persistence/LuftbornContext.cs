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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().HasData(
                new { Id = 1, Name = "None" },
                new { Id = 2, Name = "Male" },
                new { Id = 3, Name = "Female" });
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Gender> Genders { get; set; }
    }
}
