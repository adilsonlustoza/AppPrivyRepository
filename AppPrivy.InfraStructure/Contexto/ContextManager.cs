using AppPrivy.InfraStructure.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace AppPrivy.InfraStructure.Contexto
{
    public class ContextManager : IContextManager
    {
        private const string SiteContextKey = "ContextManager.Site";
        private const string DoacaoMaisContextKey = "ContextManager.DoacaoMais";

        private readonly IHttpContextAccessor _httpContextAccessor;

        public ContextManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }



        public SiteContext SiteContext()
        {
            if (_httpContextAccessor.HttpContext.Items[SiteContextKey] == null)
                _httpContextAccessor.HttpContext.Items[SiteContextKey] = new SiteContext( new DbContextOptions<SiteContext>());
            return (SiteContext)_httpContextAccessor.HttpContext.Items[SiteContextKey];
          
        }

        public DoacaoMaisContext DoacaoMaisContext()
        {
            if (_httpContextAccessor.HttpContext.Items[DoacaoMaisContextKey] == null)
                _httpContextAccessor.HttpContext.Items[DoacaoMaisContextKey] = new DoacaoMaisContext(new DbContextOptions<DoacaoMaisContext>());
            return (DoacaoMaisContext)_httpContextAccessor.HttpContext.Items[DoacaoMaisContextKey];

           
        }
    }
}
