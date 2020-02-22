using AppPrivy.Data.Interface;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Data.Repositories.DoacaoMais
{
    public class BoletimRepository :  RepositoryBaseDoacaoMais<Boletim>, IBoletimRepository
    {

        private readonly IContextManager _contextManager;

        public BoletimRepository(IContextManager contextManager):base(contextManager)
        {
            _contextManager = contextManager;
        }

        public async Task<ICollection<Boletim>> ListaBoletimCaccc(int? CacccId)
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
