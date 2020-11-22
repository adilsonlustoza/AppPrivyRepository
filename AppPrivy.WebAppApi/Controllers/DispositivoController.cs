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
    [Route("Analista/Programador/[controller]")]
    public class DispositivoController : ControllerBase
    {

        private readonly IDispositoService _dispositivoService;
        
        public DispositivoController(IDispositoService dispositoService)
        {

            _dispositivoService = dispositoService;           
        }


        [HttpGet]
        [Route("ListarTodosDispositivos")]
        public async Task<IActionResult> ListarTodosDispositivosAsync()
        {
            try
            {
                var _result = await _dispositivoService.GetAll(p => p.Notificacao);
              
                if (_result == null)
                    return StatusCode(StatusCodes.Status404NotFound, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, e.Message);
            }

          
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
                var _result = await _dispositivoService.AddUpdateDispositivoUsuario(dispositivo);

                if (_result == null)
                    return StatusCode(StatusCodes.Status404NotFound, string.Format("Code {0} device not updated", dispositivo.Code   ));
                return StatusCode(StatusCodes.Status200OK, string.Format("Code {0} device updated", dispositivo.Code));
               
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, e.Message);
            }        

        }





    }
}
