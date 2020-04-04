using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;

namespace AppPrivy.Domain.Services.DoacaoMais
{

    public class ContaBancariaService: ServiceBase<ContaBancaria>, IContaBancariaService
    {
        private readonly IContaBancariaRepository _contaBancariaRepository;

        public ContaBancariaService(IContaBancariaRepository contaBancariaRepository) :base(contaBancariaRepository)
        {
            _contaBancariaRepository = contaBancariaRepository;
        }
    }
}
