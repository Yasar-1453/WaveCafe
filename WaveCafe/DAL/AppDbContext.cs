using Microsoft.EntityFrameworkCore;
using WaveCafe.Models;

namespace WaveCafe.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImg> ProductsImages { get; set; }
    }
}
