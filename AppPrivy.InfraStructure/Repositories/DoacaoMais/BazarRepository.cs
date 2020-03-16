using AppPrivy.InfraStructure.Interface;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class BazarRepository :  RepositoryBase<Bazar>, IBazarRepository
    {

        private readonly IContextManager _contextManager;

        public BazarRepository(IContextManager contextManager):base(contextManager)
        {
            _contextManager = contextManager;
        }

        public async Task<ICollection<Bazar>> GetAllByCacccId(int Id)
        {
            return await this.Search(p => p.CacccId == Id);
        }
    }
}
