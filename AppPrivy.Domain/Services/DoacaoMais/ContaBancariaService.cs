using AppPrivy.CrossCutting.Cache;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Services.DoacaoMais
{

    public class ContaBancariaService : ServiceBase<ContaBancaria>, IContaBancariaService
    {
        private readonly IContaBancariaRepository _contaBancariaRepository;
        private const string ListaContasBancariasCache = "ListaContasBancariasCache";

        public ContaBancariaService(IContaBancariaRepository contaBancariaRepository) : base(contaBancariaRepository)
        {
            _contaBancariaRepository = contaBancariaRepository;
        }

        public async Task<IEnumerable<ContaBancaria>> ListaContasBancarias()
        {
            try
            {
                if (TemporaryMemory.GetInstance().GetCache(ListaContasBancariasCache) == null)
                    TemporaryMemory.GetInstance().CacheSave(ListaContasBancariasCache, await _contaBancariaRepository.GetAll());
                return (IEnumerable<ContaBancaria>)TemporaryMemory.GetInstance().GetCache(ListaContasBancariasCache);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
