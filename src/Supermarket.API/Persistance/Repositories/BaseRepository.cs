using Supermarket.API.Persistance.Contexts;

namespace Supermarket.API.Persistance.Repositories
{
    public class BaseRepository
    {
        protected readonly AppDbContext _context;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        
    }
}