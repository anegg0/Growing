using Growing.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Growing.Server.DataAccess
{
    public class SeedContext : DbContext
    {
        public virtual DbSet<Seed> tblSeed { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
              optionsBuilder.UseMySql("server=localhost;database=growing;user=root;password=;persistsecurityinfo = True");
            }
        }
    }
}
