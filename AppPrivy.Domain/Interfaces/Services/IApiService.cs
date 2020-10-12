using System.Collections.Generic;

namespace AppPrivy.Domain.Interfaces.Services
{
    public interface IApiService
    {
        IEnumerable<string> List();
    }
}
