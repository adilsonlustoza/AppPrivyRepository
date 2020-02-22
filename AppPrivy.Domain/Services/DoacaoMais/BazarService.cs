using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class BazarService: ServiceBase<Bazar>, IBazarService
    {
        private readonly IBazarRepository _bazarRepository;

        public BazarService(IBazarRepository bazarRepository):base(bazarRepository)
        {
            _bazarRepository = bazarRepository;
        }

        public async Task<IEnumerable<Bazar>> ObtemBazarPorCacccId(int? Id)
        {
            if (!Id.HasValue)
                throw new ApplicationException("Parametro invalido");

            var lstBazar =  await _bazarRepository.GetAllByCacccId(Id.Value);

            if (lstBazar != null)
                return lstBazar;
            return null;
        }
    }
}
