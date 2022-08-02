using Microsoft.EntityFrameworkCore;
using Students_Galaxy_Infrastructure.Data;

namespace Students_Galaxy_Infrastructure.Contexts
{
    public class InventoryManagementContext : DbContext
    {
        public InventoryManagementContext(DbContextOptions<InventoryManagementContext> options) : base(options) { }

        public DbSet<ProductMaster> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductMaster>().ToTable("ProductMaster");
            modelBuilder.Entity<Supplier>().ToTable("Supplier");
            modelBuilder.Entity<Purchase>().ToTable("Purchase");
            modelBuilder.Entity<PurchaseDetail>().ToTable("PurchaseDetail");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetail");
        }
    }
}
