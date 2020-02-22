using System.Collections.Generic;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class BoletimService : ServiceBase<Boletim>, IBoletimService
    {
        private readonly IBoletimRepository _boletimRepository;

        public BoletimService(IBoletimRepository boletimRepository) : base(boletimRepository)
        {
            _boletimRepository = boletimRepository;
        }

        public async Task<IEnumerable<Boletim>> ListaBoletimCaccc(int? CacccId)
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
    }
}
