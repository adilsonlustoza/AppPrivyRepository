using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Repositories.DoacaoMais
{
    public interface IContaBancariaRepository : IRepositoryBase<ContaBancaria>
    {
       Task<ICollection<ContaBancaria>> ListaContaBancariaCaccc(int? CacccId);
    }
}
