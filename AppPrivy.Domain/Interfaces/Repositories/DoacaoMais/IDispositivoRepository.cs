using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Repositories.DoacaoMais
{
    public interface IDispositivoRepository : IRepositoryBase<Dispositivo>
    {
        Task<IEnumerable<Dispositivo>> ListaDispositivos();

        Task<int?> Salva(Dispositivo dispositivo);


        Task Atualiza(int? Id,Dispositivo dispositivo);
    }
}
