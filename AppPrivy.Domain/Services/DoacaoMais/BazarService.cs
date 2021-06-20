using AppPrivy.CrossCutting.Cache;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class BazarService : ServiceBase<Bazar>, IBazarService
    {
        private readonly IBazarRepository _bazarRepository;
        private const string ListarBazarCache = "ListarBazarCache";

        public BazarService(IBazarRepository bazarRepository) : base(bazarRepository)
        {
            _bazarRepository = bazarRepository;
        }

        public async Task<IEnumerable<Bazar>> ListarBazar()
        {
            try
            {
                if (TemporaryMemory.GetInstance().GetCache(ListarBazarCache) == null)
                    TemporaryMemory.GetInstance().CacheSave(ListarBazarCache, await _bazarRepository.GetAll());
                return (IEnumerable<Bazar>)TemporaryMemory.GetInstance().GetCache(ListarBazarCache);               
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<IEnumerable<Bazar>> ObtemBazarPorCacccId(int? Id)
        {
            if (!Id.HasValue)
                throw new ApplicationException("Parametro invalido");

            var lstBazar = await _bazarRepository.GetAllByCacccId(Id.Value);

            if (lstBazar != null)
                return lstBazar;
            return null;
        }
    }
}
