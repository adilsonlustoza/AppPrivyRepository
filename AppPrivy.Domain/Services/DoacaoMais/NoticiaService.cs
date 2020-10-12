using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;


namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class NoticiaService : ServiceBase<Noticia>, INoticiaService
    {
        private readonly INoticiaRepository _noticiaRepository;

        public NoticiaService(INoticiaRepository noticiaRepository) : base(noticiaRepository)
        {
            _noticiaRepository = noticiaRepository;
        }
    }
}
