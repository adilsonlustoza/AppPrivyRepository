using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
        [Route("Save")]
        public async Task<IActionResult> Save(Usuario usuario)
        {
            try
            {
                if (usuario == null)
                    new ArgumentException("Invalid parameter!");

                var user = await _usuarioService.SalvarUsuario(usuario);

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
        /// List All Users
        /// </summary>
        /// <returns></returns>
        /// 

        [Authorize(Roles = "DoacaoMais")]
        [HttpGet]
        [Route("List")]

        public async Task<IActionResult> List()
        {
            try
            {
                var _result = await _usuarioService.ListarUsuarios();

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
        [Route("{Id:int?}")]
        public async Task<IActionResult> Get(int? Id)
        {
            try
            {
                if (!Id.HasValue)
                    new ArgumentException("Invalid parameter!");

                var _result = await _usuarioService.GetById(Id.Value);

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
        [HttpGet]
        [Route("{login}")]
        public async Task<IActionResult> Get(string login)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(login))
                    throw new ArgumentException("Invalid parameter!");

                var _result = await _usuarioService.Search(p => p.Login.Contains(login));

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