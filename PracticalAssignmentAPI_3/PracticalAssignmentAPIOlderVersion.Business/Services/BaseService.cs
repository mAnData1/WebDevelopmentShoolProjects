using AutoMapper;
using PracticalAssignmentAPIOlderVersion.Business.Models;
using PracticalAssignmentAPIOlderVersion.Business.Services.Interfaces;
using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;
using PracticalAssignmentAPIOlderVersion.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PracticalAssignmentAPIOlderVersion.Business.Services
{
    public class BaseService<TEntity, TRequestModel, TResponseModel, TRepository> : IBaseService<TEntity, TRequestModel, TResponseModel> 
        where TEntity : BaseEntity
        where TRequestModel : BaseRequestModel
        where TResponseModel : BaseResponseModel
        where TRepository : IBaseRepository<TEntity>
    {
        protected readonly TRepository _repository;
        protected readonly IMapper _mapper;

        public BaseService(TRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public virtual async Task<TEntity> OnBeforeCreateAsync(TRequestModel model)
        {
            return _mapper.Map<TEntity>(model);
        }

        public virtual async Task CreateAsync(TRequestModel model)
        {
            var entity = await OnBeforeCreateAsync(model);

            await _repository.CreateAsync(entity);
        }

        public virtual async Task<TEntity> OnBeforeUpdateAsync(TRequestModel model)
        {
            return _mapper.Map<TEntity>(model);
        }

        public async virtual Task UpdateAsync(Guid id, TRequestModel model)
        {
            var entity = await OnBeforeUpdateAsync(model);
            entity.Id = id;

            await _repository.UpdateAsync(entity);
        }

        public virtual async ValueTask<TResponseModel> GetByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);

            return _mapper.Map<TResponseModel>(entity);
        }

        public virtual async Task<List<TResponseModel>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return _mapper.Map<List<TResponseModel>>(result);
        }

        public virtual async Task<List<TResponseModel>> GetAllAsync(Expression<Func<TResponseModel, bool>> filter)
        {
            var expression = _mapper.Map<Expression<Func<TEntity, bool>>>(filter);

            var result = await _repository.GetAllAsync(expression);

            return _mapper.Map<List<TResponseModel>>(result);
        }
    }
}
