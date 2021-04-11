using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class CampanhaRepository : RepositoryBase<Campanha>, ICampanhaRepository
    {

        private readonly IContextManager _contextManager;

        public CampanhaRepository(IContextManager contextManager) : base(contextManager)
        {
            _contextManager = contextManager;
        }

        public async Task<ICollection<Campanha>> ListaBoletimCaccc(int? CacccId)
        {
            try
            {
                if (!CacccId.HasValue)
                    throw new ApplicationException("Deve ser fornecido um CacccId válido.");

                return await this.Search(p => p.CacccId == CacccId.Value);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
