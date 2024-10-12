namespace StoreDbConnection.Domain.Abstractions
{
    public interface IRepository<T> where T : class, new()
    {
        Task AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();
    }
}
