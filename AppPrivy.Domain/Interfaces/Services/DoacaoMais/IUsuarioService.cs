using AppPrivy.Domain.Entities.DoacaoMais;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Services.DoacaoMais
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        Task<Usuario> AdicionarUsuario(Usuario usuario);
    }
}
