using AppPrivy.Application.Interfaces;
using AppPrivy.Application.ViewsModels;
using AppPrivy.CrossCutting.Agregation;
using AppPrivy.CrossCutting.WLog;
using AppPrivy.WebAppSiteBlog.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.Extensions.Logging;

namespace AppPrivy.WebAppSiteBlog.Controllers
{
    public class HomeController : MasterController
    {
       
        private readonly IContatoAppService _contatoAppService;
        private readonly IPesquisaAppService _pesquisaAppService;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<HomeController> _logger;

        public HomeController
            (
                IContatoAppService contatoAppService,
                IPesquisaAppService pesquisaAppService,              
                IWebHostEnvironment webHostEnvironment,
                IHttpContextAccessor httpContextAccessor,
                IConfiguration configuration,
                ILogger<HomeController> logger
            )
        {
            _contatoAppService = contatoAppService;
            _pesquisaAppService = pesquisaAppService;        
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Index()
        {
            _logger.LogInformation($"Remote Ip Address {this.HttpContext?.Connection?.RemoteIpAddress?.ToString()}");
            return View();
        }

        [Route("Sobre")]
        public IActionResult About()
        {
            AppPrivyLog.GetInstance().Information($"Remote Ip Address {this.HttpContext?.Connection?.RemoteIpAddress?.ToString()}");
            ViewBag.Message = "Sobre";
            return View();
        }

        [Route("Portfolio")]
        public IActionResult Portfolio()
        {
            AppPrivyLog.GetInstance().Information($"Remote Ip Address {this.HttpContext?.Connection?.RemoteIpAddress?.ToString()}");
            ViewBag.Message = "Portfolio";
            return View();
        }


        [Route("Servicos")]
        public IActionResult Services()
        {
            AppPrivyLog.GetInstance().Information($"Remote Ip Address {this.HttpContext?.Connection?.RemoteIpAddress?.ToString()}");
            ViewBag.Message = "Servicos";
            return View();
        }

        [Route("Contato")]
        public IActionResult Contact()
        {
            AppPrivyLog.GetInstance().Information($"Remote Ip Address {this.HttpContext?.Connection?.RemoteIpAddress?.ToString()}");
            ViewBag.Message = "Página de Contato";
            ViewBag.SiteKey= _configuration.GetSection("Google").GetSection("CaptchaSiteKey").Value;
            return View();
        }


        [Route("Contato")]
        [HttpPost]
        public async Task<IActionResult> Contact(ContatoViewModel contato)
        {
            try
            {
                AppPrivyLog.GetInstance().Information($"Remote Ip Address {this.HttpContext?.Connection?.RemoteIpAddress?.ToString()}");
               
                if (ModelState.IsValid)
                {

                    var captcha = _contatoAppService.GoogleCaptcha();
                 

                    if (captcha)
                    {
                        await _contatoAppService.SendMail(new ContactAgregation()
                        {
                            Path = Path.Combine(_webHostEnvironment.WebRootPath, @"Templates\Email\ContatoEmail.html"),
                            From = contato.Email,
                            Phone = contato.Telefone,
                            Body = contato.Mensagem,
                            Subject = contato.Assunto,
                            Email = contato.Email,
                            Name = contato.Nome,
                            ContactType = contato.TipoContato.HasValue ? (contato.TipoContato.Value.Equals("Empresa") ? 2 : 1) : 0,
                        });
                    }

                 
                    TempData["Message"] = "Email enviado com sucesso!";
                }

               
            }
            catch (Exception e)
            {
                AppPrivyLog.GetInstance().Error(MethodBase.GetCurrentMethod().Name, e);
            }

            return RedirectToAction();

        }

        [Route("Pesquisa")]
        [HttpPost]
        public async Task<IActionResult> Search(IFormCollection formCollection)
        {
            try
            {
                AppPrivyLog.GetInstance().Information($"Remote Ip Address {this.HttpContext?.Connection?.RemoteIpAddress?.ToString()}");
             
                StringValues search;
            
               
                if (formCollection.TryGetValue("search", out search))
                {
                   
                    var filter = search.ToArray().GetValue(0).ToString();
                    var _result = await _pesquisaAppService.Search(filter);
                    return View(_result);
                }
           
              

            }
            catch (Exception e)
            {
                AppPrivyLog.GetInstance().Error(MethodBase.GetCurrentMethod().Name, e);
            }
            return View();

        }

        [Route("Android")]
        public IActionResult Mobile()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        [Route("SistemasWeb")]
        public IActionResult WebSystem()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        [Route("EngenhariaDeSoftware")]
        public IActionResult SoftwareEngineer()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        [Route("Blog")]
        public IActionResult Blog()
        {
            ViewBag.Message = "Blog";
            return View();
        }

        [Route("Politica")]
        public IActionResult Politica()
        {
            ViewBag.Message = "Politica";
            return View();
        }

    }
}
