using PracticalAssignmentAPIOlderVersion.Business.Models;
using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PracticalAssignmentAPIOlderVersion.Business.Services.Interfaces
{
    public interface IBaseService<TEntity, TRequestModel, TResponseModel>
        where TEntity : BaseEntity
        where TRequestModel : BaseRequestModel
        where TResponseModel : BaseResponseModel
    {
        Task CreateAsync(TRequestModel model);
        Task DeleteAsync(Guid id);
        Task<List<TResponseModel>> GetAllAsync();
        Task<List<TResponseModel>> GetAllAsync(Expression<Func<TResponseModel, bool>> filter);
        ValueTask<TResponseModel> GetByIdAsync(Guid id);
        Task<TEntity> OnBeforeCreateAsync(TRequestModel model);
        Task<TEntity> OnBeforeUpdateAsync(TRequestModel model);
        Task UpdateAsync(Guid id, TRequestModel model);
    }
}