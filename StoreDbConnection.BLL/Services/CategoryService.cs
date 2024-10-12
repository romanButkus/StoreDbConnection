using Microsoft.EntityFrameworkCore;
using StoreDbConnection.Domain.Abstractions;
using StoreDbConnection.Domain.Models;

namespace StoreDbConnection.BLL.Services
{
    public class CategoryService : GenericService<Category>
    {
        private readonly IRepository<Category> _repository;

        public CategoryService(IRepository<Category> repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Category>> GetAllBySort(string sortedAt)
        {
            var items = await _repository.GetAllAsync();

            var sortedItems = sortedAt != "desc"
                ? items.OrderBy(categories => categories.Id)
                : items.OrderByDescending(x => x.Id);

            return sortedItems;
        }
    }
}
