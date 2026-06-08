using Microsoft.EntityFrameworkCore;

namespace carservice_projekt.Models
{
    public class CarServiceContext : DbContext
    {
        public DbSet<Fahrzeug> Fahrzeuge { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;Database=CarServiceDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}