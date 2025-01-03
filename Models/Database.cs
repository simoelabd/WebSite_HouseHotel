using Microsoft.EntityFrameworkCore;

namespace Webhotel.Models
{
    public class Database : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=managehotel;user=root;",
                new MySqlServerVersion(new Version(8, 0, 21)));
        }
    }
}
