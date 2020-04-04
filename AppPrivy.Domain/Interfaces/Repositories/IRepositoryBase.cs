using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);      
        void Update(TEntity obj);
        void Remove(TEntity obj);
        Task<TEntity> GetById(int id);
        Task<ICollection<TEntity>> GetAll(params Expression<Func<TEntity, object>>[] children);
        Task<ICollection<TEntity>> Search(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] children);
        int? SaveChanges();   



    }
}
