using Growing.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Growing.Server.DataAccess
{
    public class TrayTypeContext : DbContext
    {
        public virtual DbSet<TrayType> tblTrayType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
<<<<<<< HEAD
              optionsBuilder.UseMySql("server=localhost;database=growing;user=root;password=;persistsecurityinfo = True");
=======
              optionsBuilder.UseMySql("server=localhost;database=growing;user=admin;password=;persistsecurityinfo = True");
>>>>>>> e4849ece4d7cebfb7ee98a7df39a5f8815a6465f
            }
        }
    }
}
