using Microsoft.EntityFrameworkCore;
using Entities;

namespace DataAccess.Concretes.EntityFramework
{
    // Veri tabanını temsil eden dosya
    public class BaseDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        // public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Tobeto4A2;User Id=sa;Password=YourStrongPassword123!;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Productss");
            modelBuilder.Entity<Product>().HasOne(i => i.Category);

            modelBuilder.Entity<Order>().HasMany(o => o.OrderDetails).WithOne(od => od.Order).HasForeignKey(od => od.OrderId);


            //Product product = new Product(2,"Pantolon",250,60,3);



            base.OnModelCreating(modelBuilder);

           
            //  modelBuilder.Entity<Product>().Property(i => i.Category).HasColumnName("Name").HasMaxLength(50);

            //  //  Seed Data

            //  Category category = new Category(2,"Giyim");
            //  Category category1 = new Category(1, "Elektronik");


            //  modelBuilder.Entity<Category>().HasData(category, category1);
            //  modelBuilder.Entity<Product>().HasData(product);
        }
    }
}

//    En ddoğrusu tutarlı seçim code first başladıysan öyle devam et yok db first ise db first devam et