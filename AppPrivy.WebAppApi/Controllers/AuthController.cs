using Appointment.Application.ViewsModels;
using AppPrivy.Application.Interfaces;
using DotNurse.Injector.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace AppPrivy.WebAppApi.Controllers
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
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{ex.Message}");
                throw;
            }
        }
    }
}
