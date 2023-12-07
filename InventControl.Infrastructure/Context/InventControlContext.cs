using InventControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventControl.Infrastructure.Context
{
    public class InventControlContext : DbContext
    {
        public InventControlContext(DbContextOptions<InventControlContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Category>(categ =>
            {
                categ.Property(p => p.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd()
                .IsRequired();

                categ.Property(p => p.CategoryName)
                .HasColumnName("CategoryName")
                .HasColumnType("VARCHAR")
                .HasMaxLength(150)
                .IsRequired();

                categ.Property(p => p.Avalible)
                .HasColumnName("Avalible")
                .HasDefaultValue(true);
            });

            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Product>(pd =>
            {
                pd.Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("BIGINT")
                .IsRequired()
                .ValueGeneratedOnAdd();

                pd.Property(p => p.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

                pd.Property(p => p.Description)
                .HasColumnName("Description")
                .HasColumnType("VARCHAR")
                .HasMaxLength(150);

                pd.Property(p => p.Price)
                .HasColumnName("Price")
                .IsRequired()
                .HasColumnType("DECIMAL")
                .HasPrecision(5, 2);

                pd.Property(p => p.Quantity)
                .HasColumnName("Quantity")
                .IsRequired()
                .HasColumnType("BIGINT")
                .HasDefaultValue(0);

                pd.Property(p => p.Discount)
                .HasColumnName("Discount")
                .HasDefaultValue(0);

            });
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany()
                .HasForeignKey(p => p.CategoryId);
        }

    }
}
