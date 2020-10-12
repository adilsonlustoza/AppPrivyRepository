using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;
using System.Collections.Generic;
using System.Linq;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class DispositivoRepository : RepositoryBase<Dispositivo>, IDispositivoRepository
    {

        private readonly IContextManager _contextManager;

        public DispositivoRepository(IContextManager contextManager) : base(contextManager)
        {
            _contextManager = contextManager;
        }

        public IEnumerable<Dispositivo> GetAllDispositivosPorUsuarioId(int Id)
        {
            return _contextManager
                   .AppPrivyContext()
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
