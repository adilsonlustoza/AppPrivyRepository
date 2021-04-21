using AppPrivy.CrossCutting.UnitOfWork;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System;
using System.Threading.Tasks;
using System.Transactions;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class DispositivoService : ServiceBase<Dispositivo>, IDispositoService
    {
        private readonly IDispositivoRepository _dispositivoRepository;
      

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


    }
}
