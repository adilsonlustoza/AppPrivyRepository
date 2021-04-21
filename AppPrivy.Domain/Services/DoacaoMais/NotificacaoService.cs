using AppPrivy.CrossCutting.Cache;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class NotificacaoService : ServiceBase<Notificacao>, INotificacaoService
    {
        private readonly INotificacaoRepository _notificacaoRepository;
        private const string NotificacaoCache = "NotificacaoCache";

        public NotificacaoService(INotificacaoRepository notificacaoRepository) : base(notificacaoRepository)
        {
            _notificacaoRepository = notificacaoRepository;
        }

        public async Task<IEnumerable<Notificacao>> ListaNoficacaoAtivas()
        {
            if (TemporaryMemory.GetInstance().GetCache(NotificacaoCache) == null)
                TemporaryMemory.GetInstance().CacheSave(NotificacaoCache, await _notificacaoRepository.ListaNoficacaoAtivas());
            return  (IEnumerable<Notificacao>)TemporaryMemory.GetInstance().GetCache(NotificacaoCache);
        }

        //public async Task<IEnumerable<Notificacao>> ListaNoficacaoPorDispositivo(string identificadorUnico)
        //{
        //    return await _notificacaoRepository.ListaNoficacaoPorDispositivo(identificadorUnico);
        //}
    }
}
