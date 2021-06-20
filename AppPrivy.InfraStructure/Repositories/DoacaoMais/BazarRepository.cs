using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class BazarRepository : RepositoryBase<Bazar>, IBazarRepository
    {

        public BazarRepository(IContextManager contextManager) : base(contextManager)
        {
            
        }
              

        public async Task<ICollection<Bazar>> GetAllByCacccId(int Id)
        {
            return await this.Search(p => p.CacccId == Id);
        }

      
    }
}
