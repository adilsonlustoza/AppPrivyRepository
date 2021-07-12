using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Services.DoacaoMais
{
    public interface IDispositoService : IServiceBase<Dispositivo>
    {

        Task<Dispositivo> GetByDeviceId(string deviceId);
        Task<IEnumerable<Dispositivo>> ListarDispositivos();
        Task<int?> SaveDevice(Dispositivo dispositivo);
        Task<int?> UpdateDevice(int? Id, Dispositivo dispositivo);
    }
}
