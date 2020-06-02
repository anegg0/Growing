using Growing.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Growing.Server.DataAccess
{
    public class ProductionContext : DbContext
    {
        public virtual DbSet<Production> tblProduction { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
              optionsBuilder.UseMySql("server=localhost;database=growing;user=admin;password=;persistsecurityinfo = True");
            }
        }
    }
}
