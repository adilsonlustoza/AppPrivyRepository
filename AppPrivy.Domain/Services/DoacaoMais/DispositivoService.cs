using System.Collections.Generic;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System.Linq;
using System;
using System.Transactions;
using System.Threading.Tasks;
using AppPrivy.CrossCutting.UnitOfWork;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class DispositivoService : ServiceBase<Dispositivo>, IDispositoService
    {
        private readonly IDispositivoRepository _dispositivoRepository;
        private readonly INotificacaoRepository _notificacaoRepository;
      


        public DispositivoService(IDispositivoRepository dispositivoRepository,INotificacaoRepository notificacaoRepository) :base(dispositivoRepository)
        {
            _dispositivoRepository = dispositivoRepository;
            _notificacaoRepository = notificacaoRepository;
          
        }


        public async Task<int?> AddDispositivoUsuario(Dispositivo dispositivo)
        {
            int? _result = 0;

            using (IUnitOfWork _unitOfWork = new TransactionScopeUnitOfWorkFactory(IsolationLevel.Serializable).Create())
            {
                _dispositivoRepository.AddDispositivoUsuario(dispositivo);

                _result = _dispositivoRepository.SaveChanges();

                _unitOfWork.Commit();
            }

            return await Task.FromResult<int>(_result.Value);

        }

        public async Task<int?> AddUpdateDispositivoUsuario(Dispositivo dispositivo)
        {
            try
            {
                ICollection<Dispositivo> _dispositivos=null;
                Notificacao _notificacao = null;
                int? _result=0;


                using (IUnitOfWork _unitOfWork = new TransactionScopeUnitOfWorkFactory(IsolationLevel.Serializable).Create())
                {


                    if (dispositivo.Notificacao != null)
                    {
                        var notificacaoId = dispositivo.Notificacao.Count > 0 ? dispositivo.Notificacao.FirstOrDefault().NotificacaoId : 0;

                        if (notificacaoId != 0)
                            _notificacao = await _notificacaoRepository.GetById(notificacaoId);
                    }

                    _dispositivos = await _dispositivoRepository.Search(p => p.Serial == dispositivo.Serial, x => x.Notificacao);


                    if (_dispositivos != null && _dispositivos.Count() > 0)
                    {
                        var dispositivoEncontrado = _dispositivos.FirstOrDefault();


                        if (dispositivoEncontrado != null && !dispositivoEncontrado.Notificacao.Contains(_notificacao))
                            dispositivoEncontrado.Notificacao.Add(_notificacao);
                        _dispositivoRepository.Update(dispositivoEncontrado);

                        _result = _dispositivoRepository.SaveChanges();
                    }
                    else
                    {

                         new List<Notificacao>().Add(_notificacao);

                         dispositivo.Notificacao.Add(_notificacao);
                        _dispositivoRepository.Add(dispositivo);
                        
                        _result = _dispositivoRepository.SaveChanges();

                    }


                    _unitOfWork.Commit();


                }

                return _result;


            }
            catch(Exception e)
            {
                
                throw e;
            }
        }

     
    }
}
