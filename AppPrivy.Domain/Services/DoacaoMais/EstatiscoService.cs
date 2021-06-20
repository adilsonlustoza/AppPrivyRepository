using AppPrivy.CrossCutting.Cache;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Entities.ObjectValue;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class EstatiscoService : ServiceBase<Estatistico>, IEstatiscoService
    {
        private readonly IEstatisticoRepository _estatisticoRepository;
        private const string ListarEstatisticoCache = "ListarEstatisticoCache";

        public EstatiscoService(IEstatisticoRepository estatisticoRepository) : base(estatisticoRepository)
        {
            _estatisticoRepository = estatisticoRepository;
        }

       public async Task<IEnumerable<Estatistico>> ListaEstatistico()
        {
            try
            {
                if (TemporaryMemory.GetInstance().GetCache(ListarEstatisticoCache) == null)
                    TemporaryMemory.GetInstance().CacheSave(ListarEstatisticoCache, await _estatisticoRepository.ListaEstatistico());
                return (IEnumerable<Estatistico>)TemporaryMemory.GetInstance().GetCache(ListarEstatisticoCache);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<IEnumerable<Estatistico>> ListaEstatisticoPorTipo(TipoEstatisco tipoEstatisco)
        {
            try
            {
                if (TemporaryMemory.GetInstance().GetCache(ListarEstatisticoCache) == null)
                    TemporaryMemory.GetInstance().CacheSave(ListarEstatisticoCache, await _estatisticoRepository.ListaEstatisticoPorTipo(tipoEstatisco));
                return (IEnumerable<Estatistico>)TemporaryMemory.GetInstance().GetCache(ListarEstatisticoCache);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
