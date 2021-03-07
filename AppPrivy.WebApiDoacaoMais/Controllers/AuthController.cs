using Appointment.Application.ViewsModels;
using AppPrivy.Application.Interfaces;
using AppPrivy.CrossCutting.Fault;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AppPrivy.WebApiDoacaoMais.Controllers
{




    [Route("Analista/Programador/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
      
        public readonly SignInManager<IdentityUser> _signInManager;
        public readonly IAuthService _authService;

        public AuthController(IAuthService authService, SignInManager<IdentityUser> signInManager)
        {           
                   
            _authService = authService;
            _signInManager = signInManager;
        }

        /// <summary>
        /// Request the Token by Login
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Analista/Programador/Auth/Login
        ///     {
        ///         "Email": "email@dominio.com.br",               
        ///         "Password":  "*******"        
        ///     }
        ///
        /// </remarks>
        /// <param name="loginViewModel"></param>        
        /// <returns>Token</returns>
        /// <response code="201">Token</response>
        /// <response code="400">it wasn`t able to created a new token</response>            

        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] UserToken loginViewModel)
        {
            try
            {
                
                var result = await _signInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password,
                        isPersistent: false, lockoutOnFailure: false);
              

                if (result.Succeeded)
                    return  StatusCode(StatusCodes.Status200OK, await _authService.BuildToken(loginViewModel));

                else
                    return StatusCode(StatusCodes.Status400BadRequest, $"It wans`t able to login!!!");
            }
            catch (FaultException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
              
            }
        }
    }
}
