using AppPrivy.InfraStructure.Interface;
using AppPrivy.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppPrivy.InfraStructure.Repositories
{
    public class RepositoryBaseSite<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly IContextManager _contextManager;

        public RepositoryBaseSite(IContextManager contextManager)
        {
            _contextManager = contextManager;
         
        }
        
        public void Add(TEntity obj)
        {
            _contextManager.SiteContext().Set<TEntity>().Add(obj);          
        }
       
       

        public void Remove(TEntity obj)
        {
            _contextManager.SiteContext().Set<TEntity>().Remove(obj);           
        }

        public void Update(TEntity obj)
        {
            _contextManager.SiteContext().Entry(obj).State = EntityState.Modified;
         
        }

             

       

        public void Dispose()
        {
            if (_contextManager != null)
                _contextManager.SiteContext().Dispose();

            GC.SuppressFinalize(this);
        }


        public async Task<TEntity> GetById(int id)
        {
            try
            {
                return await _contextManager.SiteContext().Set<TEntity>().FindAsync(id);
            }
            catch(Exception e)
            {
                throw e;
            }          

        }



        public async Task<ICollection<TEntity>> Search(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] children)
        {

            try
            {

                var query = _contextManager.SiteContext().Set<TEntity>().Where(expression);

                if (children.Count() > 0)
                    children.ToList().ForEach(x => query.Include(x).Load());

                return await query.ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }


        }

        public async Task<ICollection<TEntity>> GetAll(params Expression<Func<TEntity, object>>[] children)
        {
            try
            {
                var query = _contextManager.SiteContext().Set<TEntity>();

                if (children.Count() > 0)
                    children.ToList().ForEach(x => query.Include(x).Load());

                return await query.ToListAsync();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public int? SaveChanges()
        {
            return  _contextManager.SiteContext().SaveChanges();
        }
    }
}
