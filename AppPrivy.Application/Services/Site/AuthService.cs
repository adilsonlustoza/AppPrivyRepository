using Appointment.Application.ViewsModels;
using AppPrivy.Application.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AppPrivy.Application.Services.Site
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;
        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task<UserToken> BuildToken(UserToken userInfo)
        {
            try
            {
                var claims = new[]
                    {
                new Claim(ClaimTypes.Sid, userInfo.Email),
                new Claim(ClaimTypes.Role, "DoacaoMais"),
                new Claim(ClaimTypes.Name, Guid.NewGuid().ToString())
            };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                // tempo de expiração do token: 1 hora
                var expiration = DateTime.UtcNow.AddHours(1);

                JwtSecurityToken token = new JwtSecurityToken(
                   issuer: _configuration["Jwt:Issuer"],
                   audience: _configuration["Jwt:Audience"],
                   claims: claims,
                   expires: expiration,
                   signingCredentials: creds);

                return Task.FromResult(new UserToken
                {
                    Email = userInfo.Email,
                    Password = "******",
                    Token = $"bearer {new JwtSecurityTokenHandler().WriteToken(token)}",
                    Expiration = expiration
                });
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
