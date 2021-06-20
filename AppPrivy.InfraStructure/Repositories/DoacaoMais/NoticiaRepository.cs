using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class NoticiaRepository : RepositoryBase<Noticia>, INoticiaRepository
    {        
        public NoticiaRepository(IContextManager contextManager) : base(contextManager)
        {
           
        }
    }
}
