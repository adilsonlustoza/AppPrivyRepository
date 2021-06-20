using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class ContaBancariaRepository : RepositoryBase<ContaBancaria>, IContaBancariaRepository
    {       
        public ContaBancariaRepository(IContextManager contextManager) : base(contextManager)
        {
           
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
