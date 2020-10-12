using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class NoticiaRepository : RepositoryBase<Noticia>, INoticiaRepository
    {
        private readonly IContextManager _contextManager;

        public NoticiaRepository(IContextManager contextManager) : base(contextManager)
        {
            _contextManager = contextManager;
        }
    }
}
