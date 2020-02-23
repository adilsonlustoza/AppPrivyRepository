﻿using AppPrivy.Application.Interfaces;
using AppPrivy.Application.ViewsModels;
using AppPrivy.CrossCutting.Agregation;
using AppPrivy.WebAppMvc.Commons;
using AppPrivy.WebAppMvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace AppPrivy.WebAppMvc.Controllers
{
    public class HomeController : MasterController
    {
               
        private readonly ILogger<HomeController> _logger;
        private readonly IContatoAppService _contatoAppService;
        private readonly IPesquisaAppService _pesquisaAppService;
        private readonly IHttpContextAccessor _httpContextAccessor;        
        private readonly IHostEnvironment _hostingEnvironment;

        public HomeController() { }

        [Obsolete]
        public HomeController
            (
                IContatoAppService contatoAppService, 
                IPesquisaAppService pesquisaAppService, 
                ILogger<HomeController> logger, 
                IHttpContextAccessor httpContextAccessor, 
                IHostEnvironment hostingEnvironment
            )
        {
            _contatoAppService = contatoAppService;
            _pesquisaAppService = pesquisaAppService;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _hostingEnvironment = hostingEnvironment;
        }
                           

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

               
        public IActionResult Index()
        {
            return View();
        }

        [Route("Sobre")]
        public IActionResult About()
        {
            ViewBag.Message = "Sobre";

            return View();
        }

        [Route("Portfolio")]
        public IActionResult Portfolio()
        {
            ViewBag.Message = "Portfolio";

            return View();
        }


        [Route("Servicos")]
        public IActionResult Services()
        {
            ViewBag.Message = "Servicos";

            return View();
        }

        [Route("Contato")]
        public IActionResult Contact()
        {
            ViewBag.Message = "Pagina de Contato";

            return View();
        }


        [Route("Contato")]
        [HttpPost]       
        public async Task<JsonResult> Contact(ContatoViewModel contato)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    var captcha = _contatoAppService.GoogleCaptcha();

                    if (true)
                    {

                        await _contatoAppService.SendMail(new ContactAgregation()
                        {
                            _path = Path.Combine(_hostingEnvironment.ContentRootPath,@"~\Templates\Email\ContatoEmail.html"),
                            _from = contato.Email,
                            _phone = contato.Telefone,
                            _body = contato.Mensagem,
                            _subject = contato.Assunto,
                            _email = contato.Email,
                            _name = contato.Nome,
                            _contactType = contato.TipoContato.HasValue ? (contato.TipoContato.Value.Equals("Empresa") ? 2 : 1) : 0,
                        });
                    }


                    if (this.Request.IsAjaxRequest())
                        return Json(new { contato, Data = "Ok" });
                    return Json(new { Data = "NoK" });
                }
                else
                    return Json(new { Data = "NoK" });

            }
            catch (Exception e)
            {
                throw e;
            }

            finally
            {

            }


        }

        [Route("Pesquisa")]
        [HttpPost]
        public async Task<IActionResult> Search(FormCollection formCollection)
        {
            try
            {
                StringValues search; 

                if (formCollection.TryGetValue("search",out search))
                {
                    var filter = search.ToArray().GetValue(0).ToString();

                    var _result = await _pesquisaAppService.Search(filter);

                    return View(_result);
                }

                return View();

            }
            catch (Exception e)
            {
                throw e;
            }


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
