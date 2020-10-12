using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;

namespace AppPrivy.Domain.Interfaces.Repositories.DoacaoMais
{
    public interface IDispositivoRepository : IRepositoryBase<Dispositivo>
    {
        IEnumerable<Dispositivo> GetAllDispositivosPorUsuarioId(int Id);

        void AddDispositivoUsuario(Dispositivo dispositivo);
    }
}
