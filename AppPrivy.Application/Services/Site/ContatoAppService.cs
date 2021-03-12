using AppPrivy.Application.Interfaces;
using AppPrivy.CrossCutting.Agregation;
using AppPrivy.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Threading.Tasks;

namespace AppPrivy.Application
{
    public class ContatoAppService : IContatoAppService
    {
        private readonly IContatoService _contatoService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;

        public ContatoAppService(IContatoService contatoService, IHttpContextAccessor httpContextAccessor,IConfiguration configuration)
        {
            _contatoService = contatoService;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }

        public async Task SendMail(ContactAgregation contato)
        {
            try
            {
                if (contato == null)
                    throw new ApplicationException("Contato é nulo");
                else
                    await _contatoService.SendMail(contato);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool GoogleCaptcha()
        {

            try
            {
                var response = _httpContextAccessor.HttpContext.Request.Form["g-recaptcha-response"];

                string secretKey = _configuration.GetSection("Google").GetSection("CaptchaSecretKey").Value;  

                var client = new WebClient();

                var result = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, response));

                var obj = JObject.Parse(result);

                return (bool)obj.SelectToken("success");
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
