using GN3BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace GN3BackEnd
{
    public class DataBaseContext : DbContext
    {
        public DbSet<employees> employees { get; set; }
        public DbSet<salaries> salaries { get; set; }
        public DbSet<cat_departments> cat_departments { get; set; }
        public DbSet<cat_payment_methods> cat_payment_methods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3J9SR4V\\ERPDB;Database=GN3;Trusted_Connection=True;");
        }
    }
}
