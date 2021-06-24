using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Repositories.DoacaoMais
{
    public interface IDispositivoRepository : IRepositoryBase<Dispositivo>
    {
        Task<IEnumerable<Dispositivo>> ListaDispositivos();

        Task<Dispositivo> BuscaDispositivoPorDeviceId(string code);

        Task<int?> SalvaDispositivo(Dispositivo dispositivo);

        Task AtualizaDispositivo(int? Id,Dispositivo dispositivo);
    }
}
