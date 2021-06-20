using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Services.DoacaoMais
{
    public interface IConteudoService : IServiceBase<Conteudo>
    {
        Task<IEnumerable<Conteudo>> ListaConteudo();
    }
}
