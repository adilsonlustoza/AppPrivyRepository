using AppPrivy.Data.Interface;
using AppPrivy.InfraStructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using  Microsoft.EntityFrameworkCore;

namespace AppPrivy.Data.Contexto
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



        public AppPrivyContext SiteContext()
        {
            if (_httpContextAccessor.HttpContext.Items[SiteContextKey] == null)
                _httpContextAccessor.HttpContext.Items[SiteContextKey] = new SiteContext( new DbContextOptions<InfraStructure.AppPrivyContext>());
            return (SiteContext)_httpContextAccessor.HttpContext.Items[SiteContextKey];
          
        }

        public AppPrivyContext DoacaoMaisContext()
        {
            if (_httpContextAccessor.HttpContext.Items[DoacaoMaisContextKey] == null)
                _httpContextAccessor.HttpContext.Items[DoacaoMaisContextKey] = new DoacaoMaisContext(new DbContextOptions<InfraStructure.AppPrivyContext>());
            return (DoacaoMaisContext)_httpContextAccessor.HttpContext.Items[DoacaoMaisContextKey];

           
        }
    }
}
