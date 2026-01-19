using Microsoft.EntityFrameworkCore;
using SmartInventory.Services.Supplier.Models;

namespace SmartInventory.Services.Supplier.Data
{
    public class SupplierDbContext : DbContext
    {
        public SupplierDbContext(DbContextOptions<SupplierDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Supplier> Suppliers { get; set; }
    }
}
