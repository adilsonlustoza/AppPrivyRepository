using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using AppPrivy.WebAppMvc.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace AppPrivy.WebAppMvc.Controllers
{
    [ApiController]
    [Route("Analista/Programador/Usuario")]
    public class UsuarioController : MasterController
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IDispositoService _dispositivoService;
        private readonly INotificacaoService _notificacaoService;
        private readonly FaultException _fault;
        protected readonly IHttpContextAccessor _httpContextAccessor;
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
            _dispositivoService = dispositoService;
            _notificacaoService = notificacaoService;
            _fault = fault;
            _httpContextAccessor = httpContextAccessor;
          //  _webHostEnvironment = webHostEnvironment;

        }




        [HttpGet]
        [Route("ListarTodosDispositivos")]
        public async Task<IActionResult> ListarTodosDispositivos()
        {
            try
            {
                var _result = await _dispositivoService.GetAll();

                if (_result == null)
                    return NotFound();
                return Ok(_result);
            }
            catch (FaultException e)
            {
                await _fault.WriteError(e);
            }

            return null;
        }




        [HttpPost]
        [Route("SalvarDispositivo")]
        public IActionResult SalvarDispositivo(Dispositivo dispositivo)
        {
            try
            {

                _dispositivoService.AddUpdateDispositivoUsuario(dispositivo);
                return Ok(string.Format("Dispositivo salvo : {0}", dispositivo.DispositivoId));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao salvar o dispositivo :" + e.Source);

            }

        }

        [HttpPost]
        [Route("SalvarUsuario")]
        public IActionResult SalvarUsuario(Usuario usuario)
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
        public IActionResult SalvarListaUsuarios(List<Usuario> usuarios)
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

                /*
                  
                   [{
 			                    "Login": "Priscila",
 			                    "Email": "priscila@mail.com"
 		                    },
 		                    {
 			                    "Login": "Isaac",
 			                    "Email": "isaac@mail.com"
 		                    },
 		                    {
 			                    "Login": "Sofia",
 			                    "Email": "sofia@mail.com"
 		                    }
 	                    ]          
                 
                  
                  
                 */

            }
            catch (Exception e)
            {
                return BadRequest("Erro ao salvar o usuario :" + e.Message);

            }

        }


        [HttpPost]
        [Route("Cabecalho")]
        public IActionResult Cabecalho(object varCabecalho)
        {
            try
            {
                var _sb = new StringBuilder();
                int count = 0;

                var _dicHeaders = this.HttpContext.Request.Headers.GetEnumerator();

                while (_dicHeaders.MoveNext())
                {
                    _sb.AppendLine(string.Format("*************************************************"));

                    _sb.AppendLine(string.Format("Chave {0}", _dicHeaders.Current.Key));

                    foreach (var item in _dicHeaders.Current.Value)
                    {
                        _sb.AppendLine(string.Format(" {0} {1} ", ++count, item.ToString()));
                    }

                    _sb.AppendLine(string.Format("*************************************************"));
                }


                return Ok(_sb.ToString());

            }
            catch (Exception e)
            {
                return BadRequest("Erro ao salvar o usuario :" + e.Message);

            }

        }


        [HttpPost]
        [Route("SalvarArquivo")]
        public IActionResult SalvarArquivo()
        {
            try
            {


                var httpRequest = this.HttpContext.Request;

                if (httpRequest.Form.Files.Count > 0)
                {

                    var postedFile = httpRequest.Form.Files[0];

                    if (postedFile != null && postedFile.Length > 0)
                    {

                        int MaxContentLength = 1024 * 1024 * 5; //Size = 1 MB
                        if (postedFile.Length > MaxContentLength)
                        {

                            var message = string.Format("Please Upload a file upto 5 mb.");
                            return BadRequest(message.ToString());
                        }
                        else
                        {

                            var ms = new MemoryStream();
                            httpRequest.Form.Files[0].CopyTo(ms);
                            byte[] fileContent = ms.ToArray();
                            //var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "~/Arquivos/" + postedFile.FileName);

                          //  System.IO.File.Create(filePath);
                            //File.Create(filePath);
                           // postedFile.SaveAs(filePath);

                        }
                    }
                }

                return Ok(string.Format("Arquivo salvo"));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao salvar o arquivo :" + e.Message);

            }

        }


        [HttpGet]
        [Route("ListarUsuarios")]
        public IActionResult ListarUsuarios()
        {
            var _result = _usuarioService.GetAll();

            if (_result == null)
                return NotFound();
            return Ok(_result);
        }


        [HttpGet]
        [Route("ObterUsuario")]
        public IActionResult ObterUsuario(int? Id)
        {
            if (!Id.HasValue)
                return NotFound();

            var _result = _usuarioService.GetById(Id.Value);

            if (_result == null)
                return NotFound();
            return Ok(_result);
        }


        [HttpGet]
        [Route("ObterUsuarioPorLogin/{login}")]
        public IActionResult ObterUsuarioPorLogin(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                return NotFound();

            var _result = _usuarioService.Search(p => p.Login.Contains(login));

            if (_result == null)
                return NotFound();
            return Ok(_result);
        }



    }
}
