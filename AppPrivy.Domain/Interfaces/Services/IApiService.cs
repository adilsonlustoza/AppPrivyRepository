using System;
using System.Collections.Generic;
using System.Text;

namespace AppPrivy.Domain.Interfaces.Services
{
    public interface IApiService
    {
        IEnumerable<string> List();
    }
}
