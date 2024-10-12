using Microsoft.EntityFrameworkCore;
using StoreDbConnection.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDbConnection.DAL.Context
{
    public class StoreDbContext(DbContextOptions<StoreDbContext> options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
    }
}
