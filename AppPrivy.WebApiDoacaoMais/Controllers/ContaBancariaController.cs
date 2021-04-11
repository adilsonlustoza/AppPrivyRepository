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
    public class ContaBancariaController : ControllerBase
    {
        private readonly IContaBancariaService _contaBancariaService;
        private readonly ILogger<ContaBancariaController> _logger;

        public ContaBancariaController(IContaBancariaService contaBancariaService)
        {
            _contaBancariaService = contaBancariaService;
        }

        /// <summary>
        /// List all bank account
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarContasBancarias")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ListarContasBancarias()
        {
            try
            {
                var _result = await _contaBancariaService.GetAll();

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
        /// List bank accounts by institution Id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ListarContasBancariasPorCacccId/{Id}")]
        public async Task<IActionResult> ListarContasBancariasPorCacccId(int? Id)
        {

            try
            {
                if(!Id.HasValue )
                 new ArgumentException("Invalid parameter!");

                var _result = await _contaBancariaService.Search(p => p.CacccId == Id.Value);

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
