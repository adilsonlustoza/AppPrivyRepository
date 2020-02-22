using AppPrivy.Data.Interface;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPrivy.Data.Repositories.DoacaoMais
{
    public class BazarRepository :  RepositoryBaseDoacaoMais<Bazar>, IBazarRepository
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
