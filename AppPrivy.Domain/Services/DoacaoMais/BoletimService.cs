using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class BoletimService : ServiceBase<Campanha>, IBoletimService
    {
        private readonly ICampanhaRepository _boletimRepository;

        public BoletimService(ICampanhaRepository boletimRepository) : base(boletimRepository)
        {
            _boletimRepository = boletimRepository;
        }

        public async Task<IEnumerable<Campanha>> ListaBoletimCaccc(int? CacccId)
        {
            try
            {
                if (!CacccId.HasValue)
                    throw new ApplicationException("Deve ser fornecido um CacccId válido.");

                return await _boletimRepository.ListaBoletimCaccc(CacccId.Value);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        Task<IEnumerable<Campanha>> IBoletimService.ListaBoletimCaccc(int? CacccId)
        {
            throw new NotImplementedException();
        }
    }
}
