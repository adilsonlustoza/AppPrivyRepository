using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using AppPrivy.WebAppMvc.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace Appointment.WebApi.Controllers
{
    [ApiController]
    [Route("Analista/Programador/Notificacao")]
    public class NotificacaoController : MasterController
    {
        private readonly INotificacaoService _notificacaoService;
        private readonly FaultException _fault;

        public NotificacaoController(INotificacaoService noficacaoService, FaultException fault)
        {
            _notificacaoService = noficacaoService;
            _fault = fault;
        }


        [HttpGet]
        [Route("ListarNotificacoesAtivas")]
        public async Task<IActionResult> ListarNotificacoesAtivas()
        {

            try
            {

                var _result = await _notificacaoService.ListaNoficacaoAtivas();

                if (_result == null)
                    return NotFound();
                return Ok(_result);
            }
            catch (FaultException e)
            {
                await _fault.WriteError(e);
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }





        [HttpGet]
        [Route("ListaNoficacaoPorDispositivo/{IdentificadorUnico}")]
        public async Task<IActionResult> ListaNoficacaoPorDispositivo(string identificadorUnico)
        {
            try
            {
                var _result = await _notificacaoService.ListaNoficacaoPorDispositivo(identificadorUnico);

                if (_result == null)
                    return NotFound();

                return Ok(_result);
            }
            catch (Exception e)
            {
                await _fault.WriteError(e);
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
