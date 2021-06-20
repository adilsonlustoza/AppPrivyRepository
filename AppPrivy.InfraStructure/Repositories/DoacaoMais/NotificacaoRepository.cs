using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class NotificacaoRepository : RepositoryBase<Notificacao>, INotificacaoRepository
    {       

        public NotificacaoRepository(IContextManager contextManager) : base(contextManager)
        {
           
        }

        public async Task<IEnumerable<Notificacao>> ListaNoficacaoAtivas()
        {
            try
            {
                ICollection<Notificacao> notificacoes = null;

                var result = await this.Search(p => p.Ativa && (p.DataInicial <= DateTime.Now && p.DataFinal >= DateTime.Now));

                if (result != null)
                {
                    notificacoes = new List<Notificacao>();
                    var notificacaoEnumerator = result.GetEnumerator();
                    while (notificacaoEnumerator.MoveNext())
                        notificacoes.Add(notificacaoEnumerator.Current);
                }

                return notificacoes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


       
    }
}
