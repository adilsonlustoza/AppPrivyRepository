using Appointment.Application.ViewsModels;
using AppPrivy.Application.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using AppPrivy.CrossCutting.WLog;
using System.Reflection;

namespace AppPrivy.Application.Services.Site
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;
        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<UserToken> BuildToken(UserToken userInfo)
        {
            try
            {
                var claims = new[] {
                                     new Claim(ClaimTypes.Sid, userInfo.Email),
                                     new Claim(ClaimTypes.Role, "DoacaoMais")               
                                  };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                // tempo de expiração do token: 1 hora
                var expiration = DateTime.UtcNow.AddMinutes(20);

                JwtSecurityToken token = new JwtSecurityToken(
                   issuer: _configuration["Jwt:Issuer"],
                   audience: _configuration["Jwt:Audience"],
                   claims: claims,
                   expires: expiration,
                   signingCredentials: creds);

                return  await Task.FromResult(new UserToken
                {
                    Email = userInfo.Email,
                    Password = "******",
                    Token = $"bearer {new JwtSecurityTokenHandler().WriteToken(token)}",
                    Expiration = expiration
                });
            }
            catch (Exception e )
            {
                AppPrivyLog.GetInstance().Error(MethodBase.GetCurrentMethod().Name, e);
            }

            return await Task.FromResult<UserToken>(null);
        }
    }
}
