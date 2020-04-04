using System.Collections.Generic;
using AppPrivy.InfraStructure.Interface;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using System;
using System.Threading.Tasks;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class ContaBancariaRepository: RepositoryBase<ContaBancaria>, IContaBancariaRepository
    {
        private readonly IContextManager _contextManager;

        public ContaBancariaRepository(IContextManager contextManager):base(contextManager)
        {
            _contextManager = contextManager;
        }

        public async Task<ICollection<ContaBancaria>> ListaContaBancariaCaccc(int? CacccId)
        {
            try
            {
                if (!CacccId.HasValue)
                    throw new ApplicationException("Deve ser fornecido um CacccId válido.");

                return await this.Search(p => p.CacccId == CacccId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
