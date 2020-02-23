using AppPrivy.Application.Interfaces;
using AppPrivy.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppPrivy.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _serviceBase.GetById(id);
        }

        public async Task<ICollection<TEntity>> GetAll(params Expression<Func<TEntity, object>>[] children)
        {
            return await _serviceBase.GetAll(children);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public async Task<ICollection<TEntity>> Search(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] children)
        {
            return await _serviceBase.Search(expression, children);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
