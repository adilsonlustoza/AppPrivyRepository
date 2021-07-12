using AppPrivy.CrossCutting.Cache;
using AppPrivy.Domain.Entities.Blog;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class PostService : ServiceBase<Post>, IPostService
    {
        private readonly IPostRepository _postRepository;
        private const string ListarPostCache = "ListarPostCache";

        public PostService(IPostRepository postRepository) : base(postRepository)
        {
            _postRepository = postRepository;
        }

        //public async Task<IEnumerable<Bazar>> ListarBazar()
        //{
        //    try
        //    {
        //        if (TemporaryMemory.GetInstance().GetCache(ListarBazarCache) == null)
        //            TemporaryMemory.GetInstance().CacheSave(ListarBazarCache, await _postRepository.GetAll());
        //        return (IEnumerable<Bazar>)TemporaryMemory.GetInstance().GetCache(ListarBazarCache);               
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public async Task<IEnumerable<Bazar>> ObtemBazarPorCacccId(int? Id)
        //{
        //    if (!Id.HasValue)
        //        throw new ApplicationException("Parametro invalido");

        //    var lstBazar = await _postRepository.GetAllByCacccId(Id.Value);

        //    if (lstBazar != null)
        //        return lstBazar;
        //    return null;
        //}

        public Task<int> SavePostAsync(Post post)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePostAsync(int? Id, Post post)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPostsById(int? Id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPostsByGuid(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> ListAllPosts()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> ListAllPostsByCriteria(Expression<Func<Post, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
