using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.WebApiDoacaoMais.Controllers
{
    [ApiController]
    [Route("Analista/Programador/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;            


        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
      
        }


        /// <summary>
        /// Add New User
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "DoacaoMais")]
        [HttpPost]
        [Route("SalvarUsuario")]
        public async Task<IActionResult> AddUser(Usuario usuario)
        {
            try
            {
                if (usuario == null)
                    new ArgumentException("Invalid parameter!"); 

                var user =  await _usuarioService.AdicionarUsuario(usuario);

                if (user == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, user);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Add New List of User
        /// </summary>
        /// <returns></returns>
        /// 
        [Authorize(Roles = "DoacaoMais")]
        [HttpPost]
        [Route("SalvarListaUsuarios")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> AddUserList(ICollection<Usuario> usuarios)
        {
            try
            {
                foreach (var item in usuarios)
                {
                    var usuario = await _usuarioService.AdicionarUsuario(item);

                    if (usuario==null)
                        return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));

                }

                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// List All Users
        /// </summary>
        /// <returns></returns>
        /// 

        [Authorize(Roles = "DoacaoMais")]
        [HttpGet]
        [Route("ListarUsuarios")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult UserList()
        {
            try
            {
                var _result = _usuarioService.GetAll();

                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "DoacaoMais")]
        [HttpGet]
        [Route("ObterUsuario/{Id:int?}")]
        public IActionResult GetUser(int? Id)
        {
            try
            {
                if (!Id.HasValue)
                    new ArgumentException("Invalid parameter!");

                var _result = _usuarioService.GetById(Id.Value);

                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Get User By Login
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "DoacaoMais")]
        [HttpGet]
        [Route("ObterUsuarioPorLogin/{login}")]
        public IActionResult GetUserByLogin(string login)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(login))
                    throw new ArgumentException("Invalid parameter!"); 

                var _result = _usuarioService.Search(p => p.Login.Contains(login));

                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}