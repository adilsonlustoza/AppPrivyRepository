using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AppPrivy.WebAppApi.Controllers
{
    [ApiController]
    [Route("Analista/Programador/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;      
        private readonly FaultException _fault;
        protected readonly IHttpContextAccessor _httpContextAccessor;

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<Usuario> _logger;

        //  protected readonly IWebHostEnvironment _webHostEnvironment;

        public UsuarioController(
                                 IUsuarioService usuarioService,
                                 IDispositoService dispositoService,
                                 INotificacaoService notificacaoService,
                                 FaultException fault,
                                 //   IWebHostEnvironment webHostEnvironment,
                                 IHttpContextAccessor httpContextAccessor
                               )
        {
            _usuarioService = usuarioService;           
            _fault = fault;
            _httpContextAccessor = httpContextAccessor;
            //  _webHostEnvironment = webHostEnvironment;
        }


        [HttpPost]
        [Route("ObterToken")]
        private async Task<IActionResult> GetToken(Usuario usuario)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(usuario.Email, usuario.Senha, isPersistent: false, lockoutOnFailure: false);


                if (result.Succeeded)                
                    return await Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status200OK, "OK"));                
                else
                    return await Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status401Unauthorized, "Login ou Senha estão incorretos"));

            }
            catch (Exception ex)
            {
                return await Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status400BadRequest, ex.Message));
            }
        }



        [HttpPost]
        [Route("SalvarUsuario")]
        public IActionResult SaveUser(Usuario usuario)
        {
            try
            {
                var _codigo = _usuarioService.AdicionarUsuario(usuario);

                if (_codigo == 0)
                    return NotFound();
                return Ok(string.Format("Usuario criado : {0}", usuario.Login));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao salvar o usuario :" + e.Message);
            }
        }

        [HttpPost]
        [Route("SalvarListaUsuarios")]
        public IActionResult SaveUsers(List<Usuario> usuarios)
        {
            try
            {
                foreach (var item in usuarios)
                {
                    var _codigo = _usuarioService.AdicionarUsuario(item);

                    if (_codigo == 0)
                        return BadRequest(string.Format("Erro ao criar usuario {0}", item.Login));
                }

                return Ok(string.Format("Usuarios  criados"));              
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao salvar o usuario :" + e.Message);
            }
        }

       

      

        [HttpGet]
        [Route("ListarUsuarios")]
        public IActionResult ListUsers()
        {
            try
            {
                var _result = _usuarioService.GetAll();

                if (_result == null)
                    return NotFound();
                return Ok(_result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("ObterUsuario")]
        public IActionResult GetUser(int? Id)
        {
            try
            {
                if (!Id.HasValue)
                    return NotFound();

                var _result = _usuarioService.GetById(Id.Value);

                if (_result == null)
                    return NotFound();
                return Ok(_result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("ObterUsuarioPorLogin/{login}")]
        public IActionResult GetUserByLogin(string login)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(login))
                    return NotFound();

                var _result = _usuarioService.Search(p => p.Login.Contains(login));

                if (_result == null)
                    return NotFound();
                return Ok(_result);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}