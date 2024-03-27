using Microsoft.EntityFrameworkCore;
using Entities;

namespace DataAccess.Concretes.EntityFramework
{
    // Veri tabanını temsil eden dosya
    public class BaseDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Tobeto4A2;User Id=sa;Password=YourStrongPassword123!;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          //  modelBuilder.Entity<Product>().ToTable("Products");
          //  modelBuilder.Entity<Product>().HasOne(i => i.Category);
            modelBuilder.Entity<Product>().Property(i => i.Category).HasColumnName("Name").HasMaxLength(50);

            //  Seed Data
            
            Category category = new Category(1,"Giyim");
            Category category1 = new Category(1, "Elektronik");

            Product product = new Product(1,"Kazak",500,50,1);

            modelBuilder.Entity<Category>().HasData(category, category1);
            modelBuilder.Entity<Product>().HasData(product);

            base.OnModelCreating(modelBuilder);
        }
    }
}

//    En doğrusu tutarlı seçim code first başladıysan öyle devam et yok db first ise db first devam et