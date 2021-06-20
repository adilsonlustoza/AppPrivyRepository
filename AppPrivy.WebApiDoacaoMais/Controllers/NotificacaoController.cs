using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace AppPrivy.WebApiDoacaoMais.Controllers
{
    [ApiController]
    [Route("Analista/Programador/[controller]")]
    public class NotificacaoController : ControllerBase
    {
        private readonly INotificacaoService _notificacaoService;

        public NotificacaoController(INotificacaoService noficacaoService)
        {
            _notificacaoService = noficacaoService;

        }


        /// <summary>
        /// List all actives notifications
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("List")]
        public async Task<IActionResult> List()
        {

            try
            {

                var _result = await _notificacaoService.ListaNotificacoesAtivas();
                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


    }
}
