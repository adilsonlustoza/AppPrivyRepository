using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Services.DoacaoMais
{
    public interface IBazarService : IServiceBase<Bazar>
    {
        Task<IEnumerable<Bazar>> ListarBazar();
        Task<IEnumerable<Bazar>> ObtemBazarPorCacccId(int? Id);
    }
}
