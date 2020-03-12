using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Persistance.Contexts;

namespace Supermarket.API.Persistance.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        // This Constructor will call the base class constructor
        public CategoryRepository(AppDbContext context): base(context)
        {
            
        }
        public async Task<IEnumerable<Category>> ListAsync() => await _context.Categories.ToListAsync();
    }
}