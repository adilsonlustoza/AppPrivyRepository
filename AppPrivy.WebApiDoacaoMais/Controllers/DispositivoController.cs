using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Reflection;
using System.Threading.Tasks;


namespace AppPrivy.WebApiDoacaoMais.Controllers
{
    [ApiController]
    [Route("Analista/Programador/[controller]")]
    public class DispositivoController : ControllerBase
    {

        private readonly IDispositoService _dispositivoService;
        private readonly ILogger<DispositivoController> _logger;

        public DispositivoController(IDispositoService dispositoService, ILogger<DispositivoController> logger)
        {

            _dispositivoService = dispositoService;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetByDeviceId/{deviceId}")]
        public async Task<IActionResult> GetByDeviceId(string deviceId)
        {
            try
            {
                var _result = await _dispositivoService.GetByDeviceId(deviceId);

                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }


        }


        /// <summary>
        /// List all devices 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("List")]
        public async Task<IActionResult> List()
        {
            try
            {
                var _result = await _dispositivoService.ListarDispositivos();

                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }


        }

        /// <summary>
        /// Save a device [Required Authorization]
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PATCH /Analista/Programador/Dispositivo/Save
        ///     
        ///     {
        ///         "Nome": "Nome",               
        ///         "Cnpj":  "99.999.999/9999-99"
        ///         "Emai":  "email@dominio.com.br"
        ///         "UrlImagem":"http://dominio.com.br/path/image.jpg"
        ///         "Telefone":"(99) 9999-9999"
        ///         "Responsavel":"Responsavel"
        ///     }
        ///
        /// </remarks>
        /// <param name="dispositivo"></param>      
        /// <returns>Create device </returns>
        /// <response code="200">Returns device updated</response>
        /// <response code="400">it wasn`t able to ve a device</response>    
   //     [Authorize(Policy = "DoacaoMais")]
        [HttpPost]
        [Route("Save")]
        public async Task<IActionResult> Save([FromBody]Dispositivo dispositivo)
        {
            try
            {
                var _result = await _dispositivoService.AdicionarDispositivo(dispositivo);
                
                if (_result == null || _result==0)
                    return StatusCode(StatusCodes.Status400BadRequest, string.Format("Code {0} device not updated", dispositivo.Code));
                return StatusCode(StatusCodes.Status201Created, string.Format("Code {0} device updated", dispositivo.DeviceId));

            }
            catch (Exception e)
            {
                _logger.LogError("Code : {0}  - Error : {1}", e.GetHashCode() , e);
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error to save device - Send this code { e.GetHashCode() } to System Administrator and wait a answer!");
            }

        }


        /// <summary>
        /// Update a device [Required Authorization]
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PATCH /Analista/Programador/Dispositivo/Update
        ///     
        ///     {
        ///         "Nome": "Nome",               
        ///         "Cnpj":  "99.999.999/9999-99"
        ///         "Emai":  "email@dominio.com.br"
        ///         "UrlImagem":"http://dominio.com.br/path/image.jpg"
        ///         "Telefone":"(99) 9999-9999"
        ///         "Responsavel":"Responsavel"
        ///     }
        ///
        /// </remarks>
        /// <param name="DispositivoId">id do dispositivo</param>      
        /// <param name="dispositivo">dispositivo</param>      
        /// <returns>Create device </returns>
        /// <response code="200">Returns device updated</response>
        /// <response code="400">it wasn`t able to ve a device</response>    
       // [Authorize(Policy = "DoacaoMais")]
        [HttpPost]
        [Route("Update/{DispositivoId:int?}")]
        public async Task<IActionResult> Update([FromRoute]int? DispositivoId,[FromBody] Dispositivo dispositivo)
        {
            try
            {
              
                var _result = await _dispositivoService.AtualizarDispositivo(DispositivoId, dispositivo);                           

                if (_result == null)
                    return StatusCode(StatusCodes.Status400BadRequest, string.Format("Code {0} device not updated", dispositivo.DeviceId));
                return StatusCode(StatusCodes.Status201Created, string.Format("Entity with Id {0} device updated", _result));

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }

    }
}
