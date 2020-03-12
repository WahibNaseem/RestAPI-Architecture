using Microsoft.EntityFrameworkCore;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Persistance.Contexts
{
    public class AppDbContext: DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
             base.OnModelCreating(modelBuilder);
             
       }
    }
}