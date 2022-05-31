using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PracticalAssignmentAPIOlderVersion.DataAccess.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<Guid> CreateAsync(T entity);
        Task DeleteAsync(Guid id);
        Task<ICollection<T>> GetAllAsync();
        Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> filter);
        ValueTask<T> GetByIdAsync(Guid id);
        Task UpdateAsync(T entity);
    }
}