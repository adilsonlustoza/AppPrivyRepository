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
            int? _result = 0;

            using (IUnitOfWork _unitOfWork = new TransactionScopeUnitOfWorkFactory(IsolationLevel.Serializable).Create())
            {
                await this.Add(dispositivo);

                _result = await this.SaveChanges();

                _unitOfWork.Commit();
            }

            return await Task.FromResult<int?>(_result);

        }

        public async Task<int?> AtualizarDispositivo(Dispositivo dispositivo)
        {
            try
            {
            

                using (IUnitOfWork _unitOfWork = new TransactionScopeUnitOfWorkFactory(IsolationLevel.Serializable).Create())
                {




                   _unitOfWork.Commit();


                }


                return await Task.FromResult<int?>(null);
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
