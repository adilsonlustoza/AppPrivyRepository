using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Entities.ObjectValue;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Services.DoacaoMais
{
    public interface IEstatiscoService : IServiceBase<Estatistico>
    {
        Task<IEnumerable<Estatistico>> ListaEstatistico();
        Task<IEnumerable<Estatistico>> ListaEstatisticoPorTipo(TipoEstatisco tipoEstatisco);
    }
}
