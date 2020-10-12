using AppPrivy.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace AppPrivy.Domain.Services
{
    public class ApiService : IApiService
    {
        public IEnumerable<string> List()
        {
            return new List<string>() { "Name", "Sobre" };
        }
    }
}
