using AppPrivy.InfraStructure.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace AppPrivy.InfraStructure.Contexto
{
    public class ContextManager : IContextManager
    {
        
        private const string DoacaoMaisContextKey = "ContextManager.DoacaoMais";

        private readonly IHttpContextAccessor _httpContextAccessor;

        public ContextManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
               
      

        public AppPrivyContext AppPrivyContext()
        {
            if (_httpContextAccessor.HttpContext.Items[DoacaoMaisContextKey] == null)
                _httpContextAccessor.HttpContext.Items[DoacaoMaisContextKey] = new AppPrivyContext(new DbContextOptions<AppPrivyContext>());
            return (AppPrivyContext)_httpContextAccessor.HttpContext.Items[DoacaoMaisContextKey];

           
        }
    }
}
