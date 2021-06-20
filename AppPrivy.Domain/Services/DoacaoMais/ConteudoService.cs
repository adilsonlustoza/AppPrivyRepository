using AppPrivy.CrossCutting.Cache;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class ConteudoService : ServiceBase<Conteudo>, IConteudoService
    {
        private readonly IConteudoRepository _conteudoRepository;
        private const string ListaConteudoCache = "ListaConteudoCache";

        public ConteudoService(IConteudoRepository conteudoRepository) : base(conteudoRepository)
        {
            _conteudoRepository = conteudoRepository;
        }

        public async Task<IEnumerable<Conteudo>> ListaConteudo()
        {
            try
            {
                if (TemporaryMemory.GetInstance().GetCache(ListaConteudoCache) == null)
                    TemporaryMemory.GetInstance().CacheSave(ListaConteudoCache, await _conteudoRepository.GetAll());
                return (IEnumerable<Conteudo>)TemporaryMemory.GetInstance().GetCache(ListaConteudoCache);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
