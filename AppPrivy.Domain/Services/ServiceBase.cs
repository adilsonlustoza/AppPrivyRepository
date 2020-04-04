using AppPrivy.Domain.Interfaces.Repositories;
using AppPrivy.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;        

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

    

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }
               
        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);

        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);

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
            return   await _repository.Search(expression,children) ;
        }


        public void Dispose()
        {
            this.Dispose();
        }

        public int? SaveChanges()
        {
            return  _repository.SaveChanges();
        }
    }
}
