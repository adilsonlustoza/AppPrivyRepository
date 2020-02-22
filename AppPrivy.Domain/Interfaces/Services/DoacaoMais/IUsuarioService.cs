using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;

namespace AppPrivy.Domain.Interfaces.Services.DoacaoMais
{
    public interface IUsuarioService:IServiceBase<Usuario>
    {
        int AdicionarUsuario(Usuario usuario);
    }
}
