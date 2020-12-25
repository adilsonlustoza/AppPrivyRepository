using AppPrivy.Application.ViewsModels.DoacaoMais;
using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
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
        /// Salvar Ong 
        /// </summary>
        /// <param name="viewModel">Name</param>
        /// <returns></returns>

        [HttpPost]
        [Route("SalvarCaccc")]
        public async Task<IActionResult> SalvarCaccc(CacccViewModel viewModel )
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var result =  await Task.FromResult<CacccViewModel>(viewModel);
                    
                    return StatusCode(StatusCodes.Status200OK, string.Format("Your search returned no results!"));
                }

                return StatusCode(StatusCodes.Status204NoContent, string.Format("Your search returned no results!"));
               
            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }


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
