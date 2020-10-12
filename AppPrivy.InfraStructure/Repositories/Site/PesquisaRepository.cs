using AppPrivy.Domain;
using AppPrivy.InfraStructure.Interface;

namespace AppPrivy.InfraStructure.Repositories
{
    public class PesquisaRepository : RepositoryBase<Pesquisa>, IPesquisaRepository
    {
        private readonly IContextManager _contextManager;

        public PesquisaRepository(IContextManager contextManager) : base(contextManager)
        {
            _contextManager = contextManager;
        }

    }
}
