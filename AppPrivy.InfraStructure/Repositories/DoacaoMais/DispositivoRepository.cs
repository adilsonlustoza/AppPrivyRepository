using AppPrivy.Data.Interface;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using System.Collections.Generic;
using System.Linq;

namespace AppPrivy.Data.Repositories.DoacaoMais
{
    public class DispositivoRepository :  RepositoryBaseDoacaoMais<Dispositivo>, IDispositivoRepository
    {

        private readonly IContextManager _contextManager;

        public DispositivoRepository(IContextManager contextManager):base(contextManager)
        {
            _contextManager = contextManager;
        }

        public IEnumerable<Dispositivo> GetAllDispositivosPorUsuarioId(int Id)
        {
            return _contextManager
                   .DoacaoMaisContext()
                   .Set<Usuario>()
                   .Where(p => p.UsuarioId == Id)
                   .FirstOrDefault()
                   .Dispositivo.
                   ToList();
        }

        public void AddDispositivoUsuario(Dispositivo dispositivo)
        {
            this.Add(dispositivo);
           
        }
    }
}
