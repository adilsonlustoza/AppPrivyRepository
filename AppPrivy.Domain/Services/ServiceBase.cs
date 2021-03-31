using AppPrivy.Domain.Interfaces.Repositories;
using AppPrivy.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<TEntity> Add(TEntity obj)
        {
           return await _repository.Add(obj);
        }

        public async Task Remove(TEntity obj)
        {
           await _repository.Remove(obj);

        }

        public async Task Update(TEntity obj)
        {
            await _repository.Update(obj);

        }


        public async Task<TEntity> GetById(int id)
        {
            return await _repository.GetById(id);
        }
        public async Task<ICollection<TEntity>> GetAll(params Expression<Func<TEntity, object>>[] children)
        {
            return await _repository.GetAll(children);
        }

        public async Task<ICollection<TEntity>> Search(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] children)
        {
            return await _repository.Search(expression, children);
        }


     

        public async Task<int?> SaveChanges()
        {
            return await _repository.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose();

        }
    }
}
