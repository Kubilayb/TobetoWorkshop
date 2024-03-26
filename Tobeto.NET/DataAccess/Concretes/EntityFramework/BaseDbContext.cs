using Microsoft.EntityFrameworkCore;
using Entities;

namespace DataAccess.Concretes.EntityFramework
{
    // Veri tabanını temsil eden dosya
    public class BaseDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Tobeto4A;User Id=sa;Password=YourStrongPassword123!;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
