using AppPrivy.InfraStructure.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AppPrivy.InfraStructure.Contexto
{
    public class ContextManager : IContextManager
    {
        
        private const string AppPrivyContextKey = "ContextManager.AppPrivy";

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;

        public ContextManager(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }
               
      

        public AppPrivyContext AppPrivyContext()
        {
            if (_httpContextAccessor.HttpContext.Items[AppPrivyContextKey] == null)
                _httpContextAccessor.HttpContext.Items[AppPrivyContextKey] = new AppPrivyContext(new DbContextOptions<AppPrivyContext>(), _configuration);
            return (AppPrivyContext)_httpContextAccessor.HttpContext.Items[AppPrivyContextKey];

           
        }
    }
}
