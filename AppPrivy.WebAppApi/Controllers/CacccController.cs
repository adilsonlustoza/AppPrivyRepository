using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace AppPrivy.WebAppApi.Controllers
{

    [ApiController]
    [Route("Analista/Programador/[controller]")]
    public class CacccController : ControllerBase
    {

        private readonly ICacccService _cacccService;

        public CacccController(ICacccService cacccService)
        {
            _cacccService = cacccService;
        }



        [HttpGet]
        [Route("ListarCaccc")]
        public async Task<IActionResult> ListarCaccc()
        {
            try
            {
                var _result = await _cacccService.GetAll();

                if (_result == null)
                    return StatusCode(StatusCodes.Status404NotFound, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, e.Message);
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
                    return StatusCode(StatusCodes.Status404NotFound, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, e.Message);
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
                    return StatusCode(StatusCodes.Status404NotFound, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);

            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, e.Message);
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
                    return StatusCode(StatusCodes.Status404NotFound, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, e.Message);
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
                    return StatusCode(StatusCodes.Status404NotFound, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, e.Message);
            }
        }

    }
}
