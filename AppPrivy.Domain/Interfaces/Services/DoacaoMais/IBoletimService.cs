using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Services.DoacaoMais
{
    public interface IBoletimService : IServiceBase<Campanha>
    {
        Task<IEnumerable<Campanha>> ListaBoletimCaccc(int? CacccId);
    }
}
