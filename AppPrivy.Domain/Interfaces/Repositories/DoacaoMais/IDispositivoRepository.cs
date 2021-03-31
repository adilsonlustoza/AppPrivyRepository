using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Repositories.DoacaoMais
{
    public interface IDispositivoRepository : IRepositoryBase<Dispositivo>
    {
        Task<IEnumerable<Dispositivo>> GetAllDispositivosPorUsuarioId(int Id);

        Task AddDispositivoUsuario(Dispositivo dispositivo);
    }
}
