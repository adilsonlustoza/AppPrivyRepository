using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
        [Route("List")]
        public async Task<IActionResult> List()
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
        [Route("ListByCacccId/{Id?}")]
        public async Task<IActionResult> ListByCacccId(int? Id)
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
        [Route("ListByCacccName/{caccc}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ListByCacccName(string caccc)
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

    }
}
