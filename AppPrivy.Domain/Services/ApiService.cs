using AppPrivy.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPrivy.Domain.Services
{
    public class ApiService : IApiService
    {
        public IEnumerable<string> List()
        {
            return new List<string>() {"Name","Sobre" };
        }
    }
}
