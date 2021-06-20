using AppPrivy.CrossCutting.Cache;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private const string ListarUsuariosCache = "ListarUsuariosCache";

        public UsuarioService(
                              IUsuarioRepository usuarioRepository                             
            ) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;           
        }
             


        public async Task<Usuario> SalvarUsuario(Usuario usuario)
        {
           return await _usuarioRepository.Add(usuario);
           
        }

        public async Task<IEnumerable<Usuario>> ListarUsuarios()
        {
            try
            {
                if (TemporaryMemory.GetInstance().GetCache(ListarUsuariosCache) == null)
                    TemporaryMemory.GetInstance().CacheSave(ListarUsuariosCache, await _usuarioRepository.GetAll());
                return (IEnumerable<Usuario>)TemporaryMemory.GetInstance().GetCache(ListarUsuariosCache);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }


}
