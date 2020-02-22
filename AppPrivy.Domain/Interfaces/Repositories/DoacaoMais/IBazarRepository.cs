
using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Repositories.DoacaoMais
{
    public interface IBazarRepository:IRepositoryBase<Bazar>
    {
        Task<ICollection<Bazar>> GetAllByCacccId(int Id);          
    }
}
