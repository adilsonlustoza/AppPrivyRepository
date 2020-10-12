using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {

        private readonly IContextManager _contextManager;

        public UsuarioRepository(IContextManager contextManager) : base(contextManager)
        {
            _contextManager = contextManager;
        }

        public IEnumerable<Dispositivo> GetAllDispositivosPorUsuarioId(int Id)
        {
            return this.GetById(Id).Result.Dispositivo.ToList<Dispositivo>();
        }

        public void SaveDeviceUsuario(Dispositivo dispositivo)
        {
            try
            {
                _contextManager.AppPrivyContext().Set<Dispositivo>().Add(dispositivo);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
