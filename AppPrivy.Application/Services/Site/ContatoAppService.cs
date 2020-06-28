using AppPrivy.Application.Interfaces;
using AppPrivy.CrossCutting.Agregation;
using AppPrivy.Domain;
using Microsoft.AspNetCore.Http;
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

        public ContatoAppService(IContatoService contatoService, IHttpContextAccessor httpContextAccessor)
        {
            _contatoService = contatoService;
            _httpContextAccessor = httpContextAccessor;
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


        public Boolean GoogleCaptcha()
        {

            var response = _httpContextAccessor.HttpContext.Request.Query["g-recaptcha-response"];

            string secretKey = "6LerbkYUAAAAADWpcWLFuTFzIDpnMhxVGeGTc9mQ";

            var client = new WebClient();

            var result = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, response));

            var obj = JObject.Parse(result);

            var captcha = (bool)obj.SelectToken("success");

            return captcha;

        }


    }
}
