using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Services.DoacaoMais
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        Task<Usuario> SalvarUsuario(Usuario usuario);

        Task<IEnumerable<Usuario>> ListarUsuarios();
    }
}
