using Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concretes.EntityFramework
{
    public class BaseDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<ProductColors> ProductColors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=MiniECommerceDB;User Id=sa;Password=YourStrongPassword123!;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>().ToTable("ColorsGood");
            modelBuilder.Entity<Color>().Property(i => i.ColorName).HasColumnName("ColorName").HasMaxLength(2);
            //  Seed Data
            Color color = new Color(2, "Lacivert");
            modelBuilder.Entity<Color>().HasData(color);

            Product product = new Product(2, "Elbise","L" , 15, 2500);
            modelBuilder.Entity<Product>().HasData(product);

            base.OnModelCreating(modelBuilder);
        }
    }

  
    //protected override void OnModelCreating(ModelBuilder modelBuilder)

}
