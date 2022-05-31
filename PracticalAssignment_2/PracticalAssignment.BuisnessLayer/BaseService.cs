using AutoMapper;
using PracticalAssignment.BuisnessLayer.Interfaces;
using PracticalAssignment.Data.Entities;
using PracticalAssignment.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PracticalAssignment.BuisnessLayer
{
        public class BaseService<TEntity, TViewModel, TRepository> : IBaseService<TEntity, TViewModel> where TEntity : BaseEntity
         where TViewModel : class
         where TRepository : IBaseRepository<TEntity>
        {
            protected readonly TRepository _repository;
            protected readonly IMapper _mapper;

            public BaseService(TRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public virtual async Task Delete(Guid id)
            {
                await _repository.DeleteAsync(id);
            }

            public virtual async Task<TEntity> OnBeforeCreate(TViewModel model)
            {
                return _mapper.Map<TEntity>(model);
            }

            public virtual async Task Create(TViewModel model)
            {
                var entity = await OnBeforeCreate(model);

                await _repository.CreateAsync(entity);
            }

            public virtual async Task<TEntity> OnBeforeUpdate(TViewModel model)
            {
                return _mapper.Map<TEntity>(model);
            }

            public async virtual Task Update(TViewModel model)
            {
                var entity = await OnBeforeUpdate(model);

                await _repository.UpdateAsync(entity);
            }

            public virtual async ValueTask<TViewModel> GetByIdAsync(Guid id)
            {
                var entity = await _repository.GetByIdAsync(id);

                return _mapper.Map<TViewModel>(entity);
            }

            public virtual async Task<List<TViewModel>> GetAllAsync(Expression<Func<TViewModel, bool>>? filter = null)
            {
                var expression = _mapper.Map<Expression<Func<TEntity, bool>>?>(filter);

                var result = await _repository.GetAllAsync(expression);

                return _mapper.Map<List<TViewModel>>(result);
            }
        }
    
}
