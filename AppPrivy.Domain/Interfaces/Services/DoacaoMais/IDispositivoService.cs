using AppPrivy.Domain.Entities.DoacaoMais;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Services.DoacaoMais
{
    public interface IDispositoService : IServiceBase<Dispositivo>
    {
        Task<int?> AddDispositivoUsuario(Dispositivo dispositivo);

        Task<int?> AddUpdateDispositivoUsuario(Dispositivo dispositivo);
    }
}
