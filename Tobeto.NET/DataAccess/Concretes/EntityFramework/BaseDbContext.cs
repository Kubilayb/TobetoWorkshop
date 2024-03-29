using Microsoft.EntityFrameworkCore;
using Entities;

namespace DataAccess.Concretes.EntityFramework
{
    // Veri tabanını temsil eden dosya
    public class BaseDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        //   public DbSet<Order> Orders { get; set; }
        //  public DbSet<OrderDetail> OrderDetails { get; set; }
        // public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Tobeto4A2;User Id=sa;Password=YourStrongPassword123!;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().HasOne(i => i.Category);
            modelBuilder.Entity<Product>().Property(i => i.Name).HasColumnName("Name").HasMaxLength(50);

            // Seed Data

            Category category = new Category(1, "Giyim");
            Category category1 = new(2, "Elektronik");

            Product product = new Product(1, "Kazak", 500, 50, 1);

            modelBuilder.Entity<Category>().HasData(category, category1);
            modelBuilder.Entity<Product>().HasData(product);

            base.OnModelCreating(modelBuilder);
        }

    }
}

//    En ddoğrusu tutarlı seçim code first başladıysan öyle devam et yok db first ise db first devam et




// ÖDEV KISMINDAKİ HATA SEBEBİYLE BU KISIM YORUM SATIRINA ALINMIŞTIR.


/*
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Product>().ToTable("Products");
    modelBuilder.Entity<Product>().HasOne(i => i.Category);

    //  modelBuilder.Entity<Product>().Property(i => i.Category).HasColumnName("Name").HasMaxLength(50);

    //  modelBuilder.Entity<Order>().HasMany(o => o.OrderDetails).WithOne(od => od.Order).HasForeignKey(od => od.OrderId);

    //   modelBuilder.Entity<OrderDetail>().ToTable("OrderDetails");



    //  Seed Data

    Category category = new Category(2, "Giyim");
    Category category1 = new Category(1, "Elektronik");

    Product product = new Product(2, "Pantolon", 250, 60, 3);
    Product product2 = new Product(3, "Tişört", 150, 25, 4);

    modelBuilder.Entity<Category>().HasData(category, category1);
    modelBuilder.Entity<Product>().HasData(product);

    base.OnModelCreating(modelBuilder);

    //   Order order = new Order(1);
    //    Order order2 = new Order(2);
    //     Order order3 = new Order(3);


    //       OrderDetail orderDetail = new OrderDetail(1,79.95, 1, 5);
    //      OrderDetail orderDetail2 = new OrderDetail(2, 105.5, 3, 8);


} */



