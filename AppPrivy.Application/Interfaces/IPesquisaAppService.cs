using AppPrivy.Application.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppPrivy.Application.Interfaces
{
    public interface IPesquisaAppService : IAppServiceBase<PesquisaViewModel>
    {
        Task<ICollection<PesquisaViewModel>> Search(string propertie, params Expression<Func<PesquisaViewModel, object>>[] children);
    }
}
