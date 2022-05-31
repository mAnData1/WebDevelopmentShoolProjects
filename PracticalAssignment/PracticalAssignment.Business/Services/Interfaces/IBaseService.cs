using PracticalAssignment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PracticalAssignment.Business.Services.Interfaces
{
    public interface IBaseService<TEntity, TViewModel>
        where TEntity : BaseEntity
        where TViewModel : class
    {
        Task Create(TViewModel model);
        Task Delete(Guid id);
        Task<List<TViewModel>> GetAllAsync(Expression<Func<TViewModel, bool>> filter = null);
        ValueTask<TViewModel> GetByIdAsync(Guid id);
        Task<TEntity> OnBeforeCreate(TViewModel model);
        Task<TEntity> OnBeforeUpdate(TViewModel model);
        Task Update(TViewModel model);
    }
}