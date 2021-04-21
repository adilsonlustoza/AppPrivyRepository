using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AppPrivy.WebApiDoacaoMais.Controllers
{
    [ApiController]
    [Route("Analista/Programador/[controller]")]
    public class NoticiaController : ControllerBase
    {

        private readonly INoticiaService _noticiaService;

        public NoticiaController(INoticiaService noticiaService)
        {
            _noticiaService = noticiaService;
        }

        /// <summary>
        /// List all articles
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarNoticia")]
        public async Task<IActionResult> ListarNoticia()
        {
            try
            {
                var _result = await _noticiaService.GetAll();

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
        /// List all articles by instituion Id
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarNoticiaPorCacccId/{Id}")]
        public async Task<IActionResult> ListarNoticiaPorCacccId(int? Id)
        {
            try
            {
                if (!Id.HasValue)
                    throw new ApplicationException("Invalid parameter");

                var _result = await _noticiaService.Search(p => p.CacccId == Id.Value);

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
        /// List all articles by instituion name
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarNoticiaPorCacccNome/{caccc}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ListarNoticiaPorCacccNome(string caccc)
        {
            try
            {

                if (string.IsNullOrEmpty(caccc))
                    throw new ArgumentException("Invalid parameter");

                var _result = await _noticiaService.Search(p => p.Caccc.Nome.ToLower().Trim().Contains(caccc.ToLower().Trim()));

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
        /// List all general articles by instituion Id
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarNoticiasGeraisPorCacccId/{Id}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ListarNoticiasGeraisPorCacccId(int? Id)
        {
            try
            {
                if (!Id.HasValue)
                    throw new ArgumentException("Invalid parameter");

                var _noticias = await _noticiaService.Search(p => p.CacccId == Id.Value);

                var _comuns = await _noticiaService.Search(p => p.CacccId == null);

                var _result = _noticias.Union(_comuns);

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
