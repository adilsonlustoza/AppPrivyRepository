using AppPrivy.Data.Interface;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;

namespace AppPrivy.Data.Repositories.DoacaoMais
{
    public class NoticiaRepository: RepositoryBaseDoacaoMais<Noticia>, INoticiaRepository
    {
        private readonly IContextManager _contextManager;

        public NoticiaRepository(IContextManager contextManager):base(contextManager)
        {
            _contextManager = contextManager;
        }
    }
}
