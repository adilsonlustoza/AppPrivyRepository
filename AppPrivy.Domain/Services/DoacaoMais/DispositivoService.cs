using AppPrivy.CrossCutting.Cache;
using AppPrivy.CrossCutting.UnitOfWork;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using AutoMapper;
using Remotion.Linq.Parsing.Structure.IntermediateModel;
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
        private readonly IMapper _mapper;



        public DispositivoService(IDispositivoRepository dispositivoRepository,IMapper mapper) : base(dispositivoRepository)
        {
            _dispositivoRepository = dispositivoRepository;
            _mapper = mapper;
          
        }


        public async Task<int?> AdicionarDispositivo(Dispositivo dispositivo)
        {
           
            try
            {  
                
               return await _dispositivoRepository.SalvaDispositivo(dispositivo);            
              
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

                  var query =   await _dispositivoRepository.BuscaDispositivoPorDeviceId(dispositivo.DeviceId);

                if (query != null)
                {
                    dispositivo.DispositivoId = query.DispositivoId;
                    await _dispositivoRepository.AtualizaDispositivo(Id, dispositivo);
                }


                return dispositivo.DispositivoId;
                  
              
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
