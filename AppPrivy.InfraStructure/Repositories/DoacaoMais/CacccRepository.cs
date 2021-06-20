using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class CacccRepository : RepositoryBase<Caccc>, ICacccRepository
    {
       
        public CacccRepository(IContextManager contextManager) : base(contextManager)
        {
          
        }


     
    }
}
