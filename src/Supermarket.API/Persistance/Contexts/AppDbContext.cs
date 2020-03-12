using Microsoft.EntityFrameworkCore;

namespace Supermarket.API.Persistance.Contexts
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }
    }
}