using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class ConteudoService : ServiceBase<Conteudo>, IConteudoService
    {     

        public ConteudoService(IConteudoRepository conteudoRepository) : base(conteudoRepository)
        {
          
        }
    }
}
