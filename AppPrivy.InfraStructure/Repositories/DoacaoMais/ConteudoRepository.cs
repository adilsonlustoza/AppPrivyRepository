using System.Collections.Generic;
using AppPrivy.Data.Interface;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using System;
using System.Threading.Tasks;

namespace AppPrivy.Data.Repositories.DoacaoMais
{
    public class ConteudoRepository: RepositoryBaseDoacaoMais<Conteudo>, IConteudoRepository
    {
        private readonly IContextManager _contextManager;

        public ConteudoRepository(IContextManager contextManager):base(contextManager)
        {
            _contextManager = contextManager;
        }

        public async Task<ICollection<Conteudo>> ListaConteudoCaccc(int? CacccId)
        {
            try
            {
                if (!CacccId.HasValue)
                    throw new ApplicationException("Deve ser fornecido um CacccId válido.");

                return  await this.Search(p => p.CacccId == CacccId);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
