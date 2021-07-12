using AppPrivy.Domain.Entities.Blog;
using AppPrivy.Domain.Entities.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Services.DoacaoMais
{
    public interface IPostService : IServiceBase<Post>
    {
        public Task<int> SavePostAsync(Post post);

        public Task UpdatePostAsync(int? Id, Post post);

        public Task<Post> GetPostsById(int? Id);

        public Task<Post> GetPostsByGuid(Guid guid);

        public Task<IEnumerable<Post>> ListAllPosts();

        public Task<IEnumerable<Post>> ListAllPostsByCriteria(Expression<Func<Post, bool>> expression);
    }
}
