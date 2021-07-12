using AppPrivy.CrossCutting.UnitOfWork;
using AppPrivy.Domain.Entities;
using AppPrivy.Domain.Entities.Blog;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AppPrivy.InfraStructure.Repositories.Blog
{
    public class PostRepository :RepositoryBase<Post>, IPostRepository
    {
        private readonly IContextManager _contextManager;
        public PostRepository(IContextManager contextManager) : base(contextManager)
        {
            _contextManager = contextManager;
        }


        public async Task<int> SavePostAsync(Post post)
        {
            IUnitOfWork _unitOfWork = null;
            try
            {
                var codeReturn = 0;
                var strategy = _contextManager.AppPrivyContext().Database.CreateExecutionStrategy();

                await strategy.ExecuteAsync(async () =>
                {

                    using (var resource = _contextManager.AppPrivyContext())
                    {
                        using (_unitOfWork = new TransactionScopeUnitOfWorkFactory(IsolationLevel.Serializable).Create())
                        {
                            await resource.Post.AddAsync(post);

                            codeReturn = await resource.SaveChangesAsync();

                            if (post?.PostComments?.Count > 0)
                                foreach (var comment in post?.PostComments)
                                    await resource.PostComments.AddAsync(comment);


                            codeReturn = await resource.SaveChangesAsync();
                            _unitOfWork.Commit();
                        }
                    }

                });

                if (codeReturn <1)
                    _unitOfWork.RollBack();
                return codeReturn;

            }
            catch (Exception e)
            {
                _unitOfWork.RollBack();
                throw e;
            }
        }

        public async Task UpdatePostAsync(int? Id, Post post)
        {
            IUnitOfWork _unitOfWork = null;
            try
            {

                var strategy = _contextManager.AppPrivyContext().Database.CreateExecutionStrategy();

                await strategy.ExecuteAsync(async () =>
                {
                    using (var resource = _contextManager.AppPrivyContext())
                    {
                        using (_unitOfWork = new TransactionScopeUnitOfWorkFactory(IsolationLevel.Serializable).Create())
                        {
                            if (resource.Entry(post).State != EntityState.Modified)
                                resource.Attach(post).State = EntityState.Modified;
                            await _contextManager.AppPrivyContext().SaveChangesAsync();
                            _unitOfWork.Commit();
                        }
                    }

                });


            }
            catch (Exception e)
            {
                _unitOfWork.RollBack();
                throw e;
            }

        }


        public async Task<Post> GetPostsById(int? Id)
        {
            return await _contextManager.AppPrivyContext().Set<Post>().AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync(p => p.PostId == Id);
        }

        public async Task<Post> GetPostsByGuid(Guid guid)
        {
            return await _contextManager.AppPrivyContext().Set<Post>().AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync(p=>p.IdentificadorUnico.Equals(guid));
        }

        public async Task<IEnumerable<Post>> ListAllPosts()
        {
            return await _contextManager.AppPrivyContext().Post.AsNoTrackingWithIdentityResolution().ToListAsync();
        }

        public async Task<IEnumerable<Post>> ListAllPostsByCriteria(Expression<Func<Post, bool>> expression)
        {
            return await _contextManager.AppPrivyContext().Set<Post>().Where(expression).AsNoTrackingWithIdentityResolution().ToListAsync();
        }
    }
}
