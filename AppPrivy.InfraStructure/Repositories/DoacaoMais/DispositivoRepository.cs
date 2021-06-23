using AppPrivy.CrossCutting.UnitOfWork;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Transactions;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class DispositivoRepository : RepositoryBase<Dispositivo>, IDispositivoRepository
    {

        private readonly IContextManager _contextManager;

        public DispositivoRepository(IContextManager contextManager) : base(contextManager)
        {
            _contextManager = contextManager;
        }


        public async Task<IEnumerable<Dispositivo>> ListaDispositivos()
        {
            return await _contextManager.AppPrivyContext().Dispositivo.ToListAsync();
        }

        public async Task<int?> Salva(Dispositivo dispositivo)
        {
            IUnitOfWork _unitOfWork = null;
            try
            {
                var codeReturn = 0;
                var strategy = _contextManager.AppPrivyContext().Database.CreateExecutionStrategy();
              
                await strategy.ExecuteAsync(async ()   => {

                    using (var resource = _contextManager.AppPrivyContext())
                    {
                        using (_unitOfWork = new TransactionScopeUnitOfWorkFactory(IsolationLevel.Serializable).Create())
                        {
                            await  resource.Dispositivo.AddAsync(dispositivo);

                            codeReturn = await resource.SaveChangesAsync();

                            if (dispositivo?.Notificacoes?.Count > 0)
                                foreach (var notificacao in dispositivo?.Notificacoes)                                
                                    await resource.NotificacaoDispositivo.AddAsync(new NotificacaoDispositivo() { DispositivoId = dispositivo.DispositivoId, NotificacaoId = notificacao.NotificacaoId });


                             codeReturn = await resource.SaveChangesAsync();
                            _unitOfWork.Commit();
                        }
                    }                                                           
                                                            
                });

                if(codeReturn!=2)
                    _unitOfWork.RollBack();
                return codeReturn;
                           
            }
            catch(Exception e)
            {
                _unitOfWork.RollBack();
                throw e;
            }
                                           

        }

        public async Task Atualiza(int? Id, Dispositivo dispositivo)
        {
            var query = await _contextManager.AppPrivyContext().Dispositivo.FirstOrDefaultAsync(p => p.DispositivoId == Id.Value);

            if (query != null)
                _contextManager.AppPrivyContext().Update<Dispositivo>(query);

        }

    }
}
