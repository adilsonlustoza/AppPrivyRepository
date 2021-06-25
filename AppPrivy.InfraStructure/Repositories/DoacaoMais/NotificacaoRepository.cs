using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class NotificacaoRepository : RepositoryBase<Notificacao>, INotificacaoRepository
    {
        private readonly IContextManager _contextManager;
        public NotificacaoRepository(IContextManager contextManager) : base(contextManager)
        {
            _contextManager = contextManager;
        }

        public async Task<IEnumerable<Notificacao>> ListaNoficacaoAtivas()
        {
            try
            {
                var queryNotificacao =  _contextManager.AppPrivyContext().Notificacao.Where(p => p.Ativa && (p.DataInicial <= DateTime.Now && p.DataFinal >= DateTime.Now)).ToList();


                if (queryNotificacao != null)
                {
                    foreach (var notificacao in queryNotificacao)
                    {
                        var notificacaoesDispositvo =  _contextManager.AppPrivyContext().NotificacaoDispositivo.Where(p => p.NotificacaoId == notificacao.NotificacaoId).ToList();

                        if (notificacaoesDispositvo != null && notificacaoesDispositvo.Count > 0)
                            notificacao.NotificacaoDispositivo = notificacaoesDispositvo;
                    }
                }

                return await Task.FromResult<IEnumerable<Notificacao>>(queryNotificacao);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


       
    }
}
