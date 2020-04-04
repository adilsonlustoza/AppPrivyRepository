using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Entities.ObjectValue;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Repositories.DoacaoMais
{
    public interface IDispositivoRepository:IRepositoryBase<Dispositivo>
    {
        IEnumerable<Dispositivo> GetAllDispositivosPorUsuarioId(int Id);

        void AddDispositivoUsuario(Dispositivo dispositivo);
    }
}
