using Supermarket.API.Domain.Repositories;
using Supermarket.API.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Persistance.Repositories
{
    //public class UnitOfWork : BaseRepository, IUnitOfWork
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        //Optionally  We can crate the AppDbContext object here
        // rather then inherit from Base Repository


        //public UnitOfWork(AppDbContext context) : base(context) { }



        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
