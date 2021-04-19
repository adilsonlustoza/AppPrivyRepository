using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class CampanhaService : ServiceBase<Campanha>, ICampanhaService
    {
        private readonly ICampanhaRepository _campanhaRepository;

        public CampanhaService(ICampanhaRepository campanhaRepository) : base(campanhaRepository)
        {
            _campanhaRepository = campanhaRepository;
        }

        public async Task<IEnumerable<Campanha>> ListarCampanhasCaccc(int? CacccId)
        {
            try
            {
                if (!CacccId.HasValue)
                    throw new ApplicationException("Deve ser fornecido um CacccId válido.");

                return await _campanhaRepository.ListarCampanhasCaccc(CacccId.Value);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

      
    }
}
