using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Repositories.DoacaoMais
{
    public interface IBoletimRepository : IRepositoryBase<Boletim>
    {
        Task<ICollection<Boletim>> ListaBoletimCaccc(int? CacccId);
    }
}
