using StoreDbConnection.Domain.Abstractions;

namespace StoreDbConnection.BLL.Services
{
    public class GenericService<T> : IService<T> where T : class, new()
    {
        private readonly IRepository<T> _repository;

        public GenericService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public Task AddAsync(T service)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T service)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _repository.GetAllAsync();

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T service)
        {
            throw new NotImplementedException();
        }
    }
}
