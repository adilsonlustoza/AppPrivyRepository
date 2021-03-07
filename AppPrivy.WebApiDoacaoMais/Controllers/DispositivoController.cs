using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace AppPrivy.WebApiDoacaoMais.Controllers
{

    [ApiController]
    [Route("Analista/Programador/[controller]")]
    public class DispositivoController : ControllerBase
    {

        private readonly IDispositoService _dispositivoService;
        
        public DispositivoController(IDispositoService dispositoService)
        {

            _dispositivoService = dispositoService;           
        }


        /// <summary>
        /// List all devices 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ListarTodosDispositivos")]
        public async Task<IActionResult> ListarTodosDispositivos()
        {
            try
            {
                var _result = await _dispositivoService.GetAll(p => p.Notificacao);
              
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
        /// Save one device
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        [Route("SalvarDispositivo")]
        public async Task<IActionResult> SalvarDispositivo(Dispositivo dispositivo)
        {
            try
            {
                var _result = await _dispositivoService.AddUpdateDispositivoUsuario(dispositivo);

                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Code {0} device not updated", dispositivo.Code   ));
                return StatusCode(StatusCodes.Status200OK, string.Format("Code {0} device updated", dispositivo.Code));
               
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }        

        }





    }
}
