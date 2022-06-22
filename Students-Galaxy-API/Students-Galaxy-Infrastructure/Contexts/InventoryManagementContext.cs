using Microsoft.EntityFrameworkCore;
using Students_Galaxy_Infrastructure.Data;

namespace Students_Galaxy_Infrastructure.Contexts
{
    public class InventoryManagementContext : DbContext
    {
        public InventoryManagementContext(DbContextOptions<InventoryManagementContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}
