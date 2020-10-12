using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System.Collections.Generic;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IDispositivoRepository _dispositivoRepository;

        public UsuarioService(
                              IUsuarioRepository usuarioRepository,
                              IDispositivoRepository dispositivoRepository
            ) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
            _dispositivoRepository = dispositivoRepository;
        }

        public int AdicionarUsuario(Usuario usuario)
        {
            _usuarioRepository.Add(usuario);
            return 0;

        }

        public IEnumerable<Dispositivo> GetAllDispositivosPorUsuarioId(int Id)
        {
            return _dispositivoRepository.GetAllDispositivosPorUsuarioId(Id);
        }



        public void SaveDeviceUsuario(Dispositivo dispositivo)
        {
            _dispositivoRepository.AddDispositivoUsuario(dispositivo);

        }


    }


}
