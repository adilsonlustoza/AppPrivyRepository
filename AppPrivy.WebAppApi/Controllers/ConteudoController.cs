using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppPrivy.WebAppApi.Controllers
{

    [ApiController]
    [Route("Analista/Programador/[controller]")]
    public class ConteudoController : ControllerBase
    {
        private readonly IConteudoService _conteudoService;


        public ConteudoController(IConteudoService conteudoService)
        {
            _conteudoService = conteudoService;
        }

        [HttpGet]
        [Route("ListarConteudo")]
        public async Task<IActionResult> ListarConteudo()
        {
            try
            {
                var _result = await _conteudoService.GetAll();

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
        [Route("ListarConteudoPorCacccId/{Id}")]
        public async Task<IActionResult> ListarConteudoPorCacccId(int Id)
        {
            try
            {
                var _result = await _conteudoService.Search(p => p.CacccId == Id);

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
        [Route("ListarConteudoPorCacccNome/{caccc}")]
        public async Task<IActionResult> ListarConteudoPorCacccNome(string caccc)
        {
            try
            {
                var _result = await _conteudoService.Search(p => p.Caccc.Nome.Contains(caccc));

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
