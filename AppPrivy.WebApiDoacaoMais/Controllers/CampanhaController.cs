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
    public class CampanhaController : ControllerBase

    {
        private readonly ICampanhaService _campanhaService;
        private readonly ILogger<CampanhaController> _logger;

        public CampanhaController(ICampanhaService campanhaService, ILogger<CampanhaController> logger)
        {
            _campanhaService = campanhaService;
            _logger = logger;
        }

        /// <summary>
        /// List all linked articles with institutions
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("List")]
        public async Task<IActionResult> List()
        {
            try
            {
                var _result = await _campanhaService.GetAll();

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
        /// List all linked articles by institution Id
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListByCacccId/{Id}")]
        public async Task<IActionResult> ListByCacccId(int? Id)
        {
            try
            {
                if (!Id.HasValue)
                    new ArgumentException("Invalid parameter!");

                var _result = await _campanhaService.ListarCampanhasCaccc(Id);

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
        /// List all linked articles by institution name
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListByCacccName/{caccc}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ListByCacccName(string caccc)
        {
            try
            {
                if (string.IsNullOrEmpty(caccc))
                    new ArgumentException("Invalid parameter!");

                var _result = await _campanhaService.Search(p => p.Caccc.Nome.Contains(caccc));

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
