using Microsoft.EntityFrameworkCore;
using StoreDbConnection.DAL.Context;
using StoreDbConnection.DAL.Implementations;
using StoreDbConnection.Domain.Models;

namespace StoreDbConnection.DAL.Repositories
{
    public class CategoryRepository : GenericRepository<Category>
    {
        private readonly StoreDbContext _context;

        public CategoryRepository(StoreDbContext context) : base(context)
        {
            _context = context;
        }

        
    }
}
