using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AppPrivy.WebApiDoacaoMais.Controllers
{
    [Route("Analista/Programador/[controller]")]
    [ApiController]
    public class RecursoController : ControllerBase
    {


        /// <summary>
        /// Check Http Header Resource
        /// </summary>
        /// <returns></returns>

        [HttpHead]
        [Route("Cabecalho")]
        public async Task<IActionResult> Header()
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

                return await Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status200OK, _sb.ToString()));
            }
            catch (Exception e)
            {
                 return await Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError,"Erro ao salvar o usuario :" + e.Message));
            }
        }

        /// <summary>
        /// Save File By Send By Form
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "DoacaoMais")]
        [HttpPost]
        [Route("SalvarArquivo")]
        public async Task<IActionResult> SaveFile()
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

                return await Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status200OK,string.Format("Arquivo salvo")));
            }
            catch (Exception e)
            {
                return await Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError,"Erro ao salvar o arquivo :" + e.Message));
            }
        }
    }


   
}
