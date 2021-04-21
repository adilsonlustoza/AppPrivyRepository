using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Repositories.DoacaoMais
{
    public interface INotificacaoRepository : IRepositoryBase<Notificacao>
    {
        Task<IEnumerable<Notificacao>> ListaNoficacaoAtivas();

    }
}
