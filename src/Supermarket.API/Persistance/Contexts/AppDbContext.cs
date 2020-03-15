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
             
            /* Category Table Configuration through fluent API */
             modelBuilder.Entity<Category>().ToTable("Categories");
             modelBuilder.Entity<Category>().HasKey(x => x.Id);

             modelBuilder.Entity<Category>().Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
             modelBuilder.Entity<Category>().Property(x => x.Name).IsRequired().HasMaxLength(30);
             


             modelBuilder.Entity<Category>().HasData(
                  new Category{ Id = -1, Name = "Fruits and Vegetables"}, new Category { Id = -2, Name = "Diary"}
                  );

                  /*One to many relationship with fluent API  
                    We have 2 ways to do it , either from Category table or Product Table 
                    Below we have done it through Category table
                  */

          modelBuilder.Entity<Category>().HasMany<Product>(c => c.Products).WithOne(p => p.Category).HasForeignKey(p =>p.CategoryId).IsRequired();




            /* Product Table Configuration through fluent API */
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().HasKey(x => x.Id);

            modelBuilder.Entity<Product>().Property(x =>x.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Product>().Property(x =>x.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(x => x.QuantityInPackage).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.UnitOfMeasurement).IsRequired();

            /* We are configuring one to many relationship through Product table here using fluent API */

            // modelBuilder.Entity<Product>().HasOne<Category>(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);


       }
    }
}