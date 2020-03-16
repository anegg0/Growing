using BlazorCrud.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Server.DataAccess
{
    public class EmployeeContext : DbContext
    {
        public virtual DbSet<Employee> tblTray { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
              // optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=myTestDB;Data Source=ANKIT-LENOVO\SQLEXPRESS;");
              optionsBuilder.UseMySql("server=localhost;database=growing;user=admin;password=;persistsecurityinfo = True");
            }
        }
    }
}
