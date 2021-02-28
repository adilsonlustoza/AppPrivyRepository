using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace AppPrivy.WebAppApi.Controllers
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
        [Route("ListarNotificacoesAtivas")]
        public async Task<IActionResult> ListarNotificacoesAtivas()
        {

            try
            {

                var _result = await _notificacaoService.ListaNoficacaoAtivas();

                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
         
        }

        /// <summary>
        /// List all actives notifications by device unique identifier
        /// </summary>
        /// <returns></returns>


        [HttpGet]
        [Route("ListaNoficacaoPorDispositivo/{IdentificadorUnico}")]
        public async Task<IActionResult> ListaNoficacaoPorDispositivo(string identificadorUnico)
        {
            try
            {
                if (string.IsNullOrEmpty(identificadorUnico))
                    new ArgumentException("Invalid parameter!");


                var _result = await _notificacaoService.ListaNoficacaoPorDispositivo(identificadorUnico);

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
