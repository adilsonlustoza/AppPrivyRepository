using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AppPrivy.WebAppApi.Controllers
{
    [ApiController]
    [Route("Analista/Programador/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;       
        //private readonly SignInManager<IdentityUser> _signInManager;


        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
          //  _signInManager = signInManager;
        }
          

        [HttpPost]
        [Route("SalvarUsuario")]
        public IActionResult AddUser(Usuario usuario)
        {
            try
            {
                if (usuario == null)
                    new ArgumentException("Invalid parameter!"); 

                var _codigo = _usuarioService.AdicionarUsuario(usuario);

                if (_codigo == 0)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _codigo);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPost]
        [Route("SalvarListaUsuarios")]
        public IActionResult AddUserList(ICollection<Usuario> usuarios)
        {
            try
            {
                foreach (var item in usuarios)
                {
                    var _codigo = _usuarioService.AdicionarUsuario(item);

                    if (_codigo == 0)
                        return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));

                }

                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }



        [HttpGet]
        [Route("ListarUsuarios")]
        public IActionResult UserList()
        {
            try
            {
                var _result = _usuarioService.GetAll();

                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (FaultException e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("ObterUsuario")]
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
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

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