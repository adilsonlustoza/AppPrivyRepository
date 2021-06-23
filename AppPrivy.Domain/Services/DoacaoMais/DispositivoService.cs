using AppPrivy.CrossCutting.Cache;
using AppPrivy.CrossCutting.UnitOfWork;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Transactions;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class DispositivoService : ServiceBase<Dispositivo>, IDispositoService
    {
        private readonly IDispositivoRepository _dispositivoRepository;
        private const string ListarDispositivosCache = "ListarDispositivosCache";



        public DispositivoService(IDispositivoRepository dispositivoRepository) : base(dispositivoRepository)
        {
            _dispositivoRepository = dispositivoRepository;
          
        }


        public async Task<int?> AdicionarDispositivo(Dispositivo dispositivo)
        {
           
            try
            {  
                
               return await _dispositivoRepository.Salva(dispositivo);            
              
            }
            catch (Exception ex)
            {
             
                throw ex;
            }

        }

        public async Task<int?> AtualizarDispositivo(int? Id,Dispositivo dispositivo)
        {
            try
            {

                if (!Id.HasValue)
                    throw new ArgumentException("");

                using (IUnitOfWork _unitOfWork = new TransactionScopeUnitOfWorkFactory(IsolationLevel.Serializable).Create())
                {
                                        
                    await _dispositivoRepository.Atualiza(Id.Value, dispositivo);
                              
                    await _dispositivoRepository.SaveChangesAsync();

                    _unitOfWork.Commit();
                }


                return await Task.FromResult<int?>(Id);
            }
            catch (Exception e)
            {

                throw e;
            }

           
        }

        public async Task<IEnumerable<Dispositivo>> ListarDispositivos()
        {
            
                try
                {
                    if (TemporaryMemory.GetInstance().GetCache(ListarDispositivosCache) == null)
                        TemporaryMemory.GetInstance().CacheSave(ListarDispositivosCache, await _dispositivoRepository.GetAll(p => p.NotificacaoDispositivo));
                    return (IEnumerable<Dispositivo>)TemporaryMemory.GetInstance().GetCache(ListarDispositivosCache);
                }
                catch (Exception e)
                {
                    throw e;
                }
            
        }

    }
}
