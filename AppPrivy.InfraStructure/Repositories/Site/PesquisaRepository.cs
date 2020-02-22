using AppPrivy.Data.Interface;
using AppPrivy.Domain;

namespace AppPrivy.Data.Repositories
{
    public class PesquisaRepository :RepositoryBaseSite<Pesquisa>,IPesquisaRepository
    {
      private readonly   IContextManager _contextManager;

        public PesquisaRepository(IContextManager contextManager):base(contextManager)
        {
            _contextManager = contextManager;
        }

    }
}
