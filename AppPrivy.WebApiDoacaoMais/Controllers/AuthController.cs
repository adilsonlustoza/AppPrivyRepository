using Appointment.Application.ViewsModels;
using AppPrivy.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace AppPrivy.WebApiDoacaoMais.Controllers
{




    [Route("Analista/Programador/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IAuthService _authService;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuthService authService,
                              SignInManager<IdentityUser> signInManager,
                              ILogger<AuthController> logger
            )
        {           
                   
            _authService = authService;
            _signInManager = signInManager;
            _logger = logger;
        }

        /// <summary>
        /// Request the Token by Login
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     Head /Analista/Programador/Auth/Login
        ///     
        ///    "Email": "email@dominio.com.br"             
        ///    "Password":  "*******"        
        ///     
        /// </remarks>
        /// <param name="userToken"></param>
        // <returns>Token</returns>
        /// <response code="201">Token</response>
        /// <response code="400">it wasn`t able to created a new token</response>            


        [HttpHead("Login")]
        [ResponseCache(NoStore = true)]
        public async Task<ActionResult<UserToken>> Login([FromHeader] UserToken userToken)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(userToken.Email, userToken.Password,
                        isPersistent: false, lockoutOnFailure: false);              

                if (result.Succeeded)
                    return  StatusCode(StatusCodes.Status200OK, await _authService.BuildToken(userToken));
                else
                    return StatusCode(StatusCodes.Status400BadRequest, $"It wans`t able to login!!!");
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error,"Exception Error in Method {0} - {1}: ", ex.TargetSite.ReflectedType.FullName,ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
              
            }
        }
    }
}
