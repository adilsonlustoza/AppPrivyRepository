using AppPrivy.Domain.Interfaces.Repositories;
using AppPrivy.InfraStructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppPrivy.InfraStructure.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly IContextManager _context;

        public RepositoryBase(IContextManager context)
        {
            _context = context;

        }

        public async Task<TEntity> Add(TEntity obj)
        {
            try
            {
               var contextResult= await _context.AppPrivyContext().Set<TEntity>().AddAsync(obj);

                if (contextResult.State == EntityState.Added)
                    return contextResult.Entity;
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        public async Task<ICollection<TEntity>> GetAll(params Expression<Func<TEntity, object>>[] children)
        {
            try
            {
                var query = _context.AppPrivyContext().Set<TEntity>().AsQueryable();

                if (query.Any() && (children != null && children.Count() > 0))
                    children?.ToList().ForEach(x => query.Include(x).Load());

                return await query.ToListAsync();


            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public async Task<TEntity> GetById(int id)
        {
            try
            {

                return await _context.AppPrivyContext().Set<TEntity>().FindAsync(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task Remove(TEntity obj)
        {
            try
            {
                _context.AppPrivyContext().Set<TEntity>().Remove(obj);
                 await Task.FromResult<TEntity>(obj);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public async Task Update(TEntity obj)
        {
            try
            {
                 _context.AppPrivyContext().Entry(obj).State = EntityState.Modified;
                  await Task.FromResult<TEntity>(obj);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public async Task<ICollection<TEntity>> Search(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] children)
        {
            try
            {
                var query = _context.AppPrivyContext().Set<TEntity>().Where(expression);

                if (children != null && children.Count() > 0)
                    children.ToList().ForEach(x => query.Include(x).Load());

                return await query.ToListAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }





        public void Dispose()
        {
            if (_context != null)
                _context.AppPrivyContext().Dispose();

            GC.SuppressFinalize(this);
        }

        public async Task<int?> SaveChanges()
        {
            return await _context.AppPrivyContext().SaveChangesAsync();
        }
    }
}
