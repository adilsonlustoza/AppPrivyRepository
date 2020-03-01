using AppPrivy.InfraStructure.Interface;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class UsuarioRepository :  RepositoryBaseDoacaoMais<Usuario>, IUsuarioRepository
    {

        private readonly IContextManager _contextManager;

        public UsuarioRepository(IContextManager contextManager):base(contextManager)
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
                _contextManager.DoacaoMaisContext().Set<Dispositivo>().Add(dispositivo);               
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}
