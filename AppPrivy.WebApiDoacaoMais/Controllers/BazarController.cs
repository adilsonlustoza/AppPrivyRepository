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

    public class BazarController : ControllerBase
    {
        private readonly IBazarService _bazarService;
        private readonly ILogger<BazarController> _logger;

        public BazarController(IBazarService bazarService,
                               ILogger<BazarController> logger)
        {
            _bazarService = bazarService;
            _logger = logger;
        }

        /// <summary>
        /// Lists stores linked to institutions
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarBazar")]
       
        public async Task<IActionResult> ListarBazar()
        {
            try
            {
                var _result = await _bazarService.GetAll();

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
        /// Lists stores by cacccId linked to institutions 
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarBazarPorCacccId/{cacccId}")]
        public async Task<IActionResult> ListarBazarPorCacccId(int? cacccId)
        {
            try
            {
                if (!cacccId.HasValue )
                    new ArgumentException("Invalid parameter!");

                var _result = await _bazarService.ObtemBazarPorCacccId(cacccId);

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
        /// Lists stores by name linked to institutions 
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarBazarPorCacccNome/{caccc}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ListarBazarPorCacccNomeAsync(string caccc)
        {
            try
            {
                if (!string.IsNullOrEmpty(caccc) )
                    new ArgumentException("Invalid parameter!");

                var _result = await _bazarService.Search(p => p.Caccc.Nome.Contains(caccc));

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
