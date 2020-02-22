using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class ConteudoService: ServiceBase<Conteudo>, IConteudoService
    {
        private readonly IConteudoRepository _conteudoRepository;

        public ConteudoService(IConteudoRepository conteudoRepository) :base(conteudoRepository)
        {
            _conteudoRepository = conteudoRepository;
        }
    }
}
