
namespace TDSPK.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository()
        {
        }

        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetByUserIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
