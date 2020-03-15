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
        public async Task<IEnumerable<Category>> ListAsync()
         {
            
             return await _context.Categories.ToListAsync();
         }

         public async Task AddAsync(Category category)
         {
             await _context.Categories.AddAsync(category);
         }

        public async Task<Category> FindByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}