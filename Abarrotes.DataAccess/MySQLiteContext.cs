using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes.DataAccess
{
    public class MySQLiteContext : DbContext
    {
        public MySQLiteContext(DbContextOptions<MySQLiteContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }   
        public DbSet<Product> Product { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<SalesDetail> SalesDetail { get; set; }
        public DbSet<Inventory> Inventory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Status).IsRequired();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.IdCategory).IsRequired();
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.Stock).IsRequired();
                entity.Property(e => e.MeasureUnit).IsRequired();
                entity.Property(e => e.UrlImage).IsRequired();
                entity.Property(e => e.Status).IsRequired();
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.HasKey(e => e.IdVenta);
                entity.Property(e => e.FechaVenta).IsRequired();
                entity.Property(e => e.Total).IsRequired();
            });      

            modelBuilder.Entity<SalesDetail>(entity =>
            {
                entity.HasKey(e => e.IdDetalleVenta);
                entity.Property(e => e.IdVenta).IsRequired();
                entity.Property(e => e.IdProducto).IsRequired();
                entity.Property(e => e.Cantidad).IsRequired();
                entity.Property(e => e.Subtotal).IsRequired();
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.IdMovimiento);
                entity.Property(e => e.IdProducto).IsRequired();
                entity.Property(e => e.TipoMovimiento).IsRequired();
                entity.Property(e => e.Cantidad).IsRequired();
                entity.Property(e => e.FechaMovimiento).IsRequired();
            });
        }
    }  
}
