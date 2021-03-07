using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppPrivy.WebApiDoacaoMais.Controllers
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

        /// <summary>
        /// List all content of all institution
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarConteudo")]
        public async Task<IActionResult> ListarConteudo()
        {
            try
            {
                var _result = await _conteudoService.GetAll();

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
        /// List all content by institution Id
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarConteudoPorCacccId/{Id}")]
        public async Task<IActionResult> ListarConteudoPorCacccId(int Id)
        {
            try
            {
                var _result = await _conteudoService.Search(p => p.CacccId == Id);

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
        /// List all content by institution name
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarConteudoPorCacccNome/{caccc}")]
        public async Task<IActionResult> ListarConteudoPorCacccNome(string caccc)
        {
            try
            {
                var _result = await _conteudoService.Search(p => p.Caccc.Nome.Contains(caccc));

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
