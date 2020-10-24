using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace AppPrivy.WebAppApi.Controllers
{

    [ApiController]
    [Route("Analista/Programador/Dispositivo")]
    public class DispositivoController : ControllerBase
    {

        private readonly IDispositoService _dispositivoService;
        private readonly FaultException _fault;


        public DispositivoController(IDispositoService dispositoService, FaultException faultException)
        {

            _dispositivoService = dispositoService;
            _fault = faultException;
        }


        [HttpGet]
        [Route("ListarTodosDispositivos")]
        public async Task<IActionResult> ListarTodosDispositivosAsync()
        {
            try
            {
                var _result = await _dispositivoService.GetAll(p => p.Notificacao);
                if (_result == null)
                    return NotFound();
                return Ok(null);
            }
            catch (FaultException e)
            {
                await _fault.WriteError("ListarTodosDispositivosAsync", e);
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }


        // GET api/documentation
        /// <summary>
        /// This is how we create a documentation
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        [Route("SalvarDispositivo")]
        public async Task<IActionResult> SalvarDispositivo(Dispositivo dispositivo)
        {
            try
            {
                var result = await _dispositivoService.AddUpdateDispositivoUsuario(dispositivo);
                return Ok(string.Format("Dispositivo salvo : {0}", result));
            }
            catch (Exception e)
            {
                await _fault.WriteError("SalvarDispositivo", e);

            }

            return StatusCode(StatusCodes.Status500InternalServerError);

        }





    }
}
