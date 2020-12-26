using AppPrivy.Application.ViewsModels.DoacaoMais;
using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace AppPrivy.WebAppApi.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("Analista/Programador/[controller]")]
    public class CacccController : ControllerBase
    {

        private readonly ICacccService _cacccService;

        public CacccController(ICacccService cacccService)
        {
            _cacccService = cacccService;
        }
        /// <summary>
        /// Create a new Ong
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST / Analista/Programador/Caccc/SalvarCaccc
        ///     {
        ///         "Ong Name": "Ong Name",
        ///         "Ong surname": "Ong surname"
        ///         "Cnpj": cnpj
        ///     }
        ///
        /// </remarks>
        /// <param name="viewModel">viewModel</param>       
        /// <returns>New Ong Created! </returns>
        /// <response code="201">Returns new Ong Creted</response>
        /// <response code="400">it wasn`t able to created a new Ong</response>            

        [Authorize(Roles = "DoacaoMais")]
        [HttpPost]
        [Route("SalvarCaccc")]
        public async Task<IActionResult> SalvarCaccc([FromBody]CacccViewModel viewModel )
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var result =  await Task.FromResult<CacccViewModel>(viewModel);                    
                    return StatusCode(StatusCodes.Status201Created,$"The ong {result.Cnpj} was created!");
                }

                return StatusCode(StatusCodes.Status400BadRequest, $"The ong {viewModel.Cnpj}  wasn't created");
               
            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }


        /// <summary>
        /// List all Ongs
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        [Route("ListarCaccc")]
        public async Task<IActionResult> ListarCaccc()
        {
            try
            {
                             
                var _result = await _cacccService.GetAll();

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
        /// List all stores associated the Ongs
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarCacccBazares")]
        public async Task<IActionResult> ListarCacccBazares()
        {
            try
            {
                var _result = await _cacccService.ListarCacccBazares();

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
        /// Brings a summary of the Ong through the Ong Id
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ConteudoContasPorCaccc/{Id}")]
        public async Task<IActionResult> ConteudoContasPorCaccc(int? Id)
        {
            try
            {
                var _result = await _cacccService.ConteudoContasPorCaccc(Id);

                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);

            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }


        [HttpGet]
        [Route("ConteudoContasPorNomeCaccc/{caccc}")]
        public async Task<IActionResult> ConteudoContasPorNomeCaccc(string caccc)
        {
            try
            {
                var _result = await _cacccService.ConteudoContasPorNomeCaccc(caccc);

                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }


        [HttpGet]
        [Route("ListarConteudoContasPorCaccc")]
        public async Task<IActionResult> ListarConteudoContasPorCaccc()
        {
            try
            {
                var _result = await _cacccService.ListarConteudoContasPorCaccc();

                if (_result == null)
                    return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

    }
}
