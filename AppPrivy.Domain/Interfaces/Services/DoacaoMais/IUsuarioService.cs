using AppPrivy.Domain.Entities.DoacaoMais;

namespace AppPrivy.Domain.Interfaces.Services.DoacaoMais
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        int AdicionarUsuario(Usuario usuario);
    }
}
