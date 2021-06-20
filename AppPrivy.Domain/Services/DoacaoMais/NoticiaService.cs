using AppPrivy.CrossCutting.Cache;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class NoticiaService : ServiceBase<Noticia>, INoticiaService
    {
        private readonly INoticiaRepository _noticiaRepository;
        private const string ListNoticiasCache = "ListNoticiasCache";

        public NoticiaService(INoticiaRepository noticiaRepository) : base(noticiaRepository)
        {
            _noticiaRepository = noticiaRepository;
        }

        public async Task<IEnumerable<Noticia>> ListNoticias()
        {
            try
            {
                if (TemporaryMemory.GetInstance().GetCache(ListNoticiasCache) == null)
                    TemporaryMemory.GetInstance().CacheSave(ListNoticiasCache, await _noticiaRepository.GetAll());
                return (IEnumerable<Noticia>)TemporaryMemory.GetInstance().GetCache(ListNoticiasCache);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
