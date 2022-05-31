using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Enities.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEnity
    {
        Task CreateAsync(T entity);
        Task DeleteAsync(Guid id);
        Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        ValueTask<T> GetByIdAsync(Guid id);
        Task UpdateAsync(T entity);
    }
}
