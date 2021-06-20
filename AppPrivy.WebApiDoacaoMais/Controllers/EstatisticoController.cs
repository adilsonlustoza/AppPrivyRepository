using AppPrivy.Domain.Entities.ObjectValue;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace AppPrivy.WebApiDoacaoMais.Controllers
{
    [ApiController]
    [Route("Analista/Programador/[controller]")]

    public class EstatisticoController : ControllerBase
    {
        private readonly IEstatiscoService _estasticoService;
        private readonly ILogger<EstatisticoController> _logger;

        public EstatisticoController(IEstatiscoService estasticoService,
                                    ILogger<EstatisticoController> logger)
        {
            _estasticoService = estasticoService;
            _logger = logger;
        }

        /// <summary>
        /// Lists All Statistics
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("List")]

        public async Task<IActionResult> List()
        {
            try
            {
                var _result = await _estasticoService.ListaEstatistico();

                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, "Exception Error in Method {0} - {1}: ", e.TargetSite.ReflectedType.FullName, e);
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Lists Statistics by Type 
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListByType/{tipo}")]
        public async Task<IActionResult> ListByType(TipoEstatisco tipo)
        {
            try
            {
                if (tipo.Equals(TipoEstatisco.Nenhum))
                     new ArgumentException("Invalid parameter!");

                var _result = await _estasticoService.ListaEstatisticoPorTipo(tipo);

                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, "Exception Error in Method {0} - {1}: ", e.TargetSite.ReflectedType.FullName, e);
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

              
    }
}
