using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;


namespace AppPrivy.WebApiDoacaoMais.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("Analista/Programador/[controller]")]
    public class CacccController : ControllerBase
    {

        private readonly ICacccService _cacccService;
        private readonly ILogger<CacccController> _logger;

        public CacccController(ICacccService cacccService, ILogger<CacccController> logger)
        {
            _cacccService = cacccService;
            _logger = logger;
        }
        /// <summary>
        /// Create a new institution [Required Authorization]
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST / Analista/Programador/Caccc/SalvarCaccc
        ///     {
        ///         "Nome": "Nome",               
        ///         "Cnpj":  "99.999.999/9999-99"
        ///         "Emai":  "email@dominio.com.br"
        ///         "UrlImagem":"http://dominio.com.br/path/image.jpg"
        ///         "Telefone":"(99) 9999-9999"
        ///         "Responsavel":"Responsavel"
        ///     }
        ///
        /// </remarks>
        /// <param name="caccc"></param>        
        /// <returns>New Ong Created! </returns>
        /// <response code="201">Returns new Ong Creted</response>
        /// <response code="400">it wasn`t able to created a new Ong</response>            

        [Authorize(Roles = "DoacaoMais")]
        [HttpPost]
        [Route("SalvarCaccc")]
        public async Task<IActionResult> SalvarCaccc([FromBody]Caccc caccc)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var result = await _cacccService.Add(caccc);
                         
                    return StatusCode(StatusCodes.Status201Created,$"The ong {result} was created!");
                }

                return StatusCode(StatusCodes.Status400BadRequest, $"The ong {caccc.Cnpj}  wasn't created");
               
            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, "Exception Error in Method {0} - {1}: ", e.TargetSite.ReflectedType.FullName, e);
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }


        /// <summary>
        /// Update a institution [Required Authorization]
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT / Analista/Programador/Caccc/AtualizaCaccc/2
        ///     
        ///     {
        ///         "Nome": "Nome",               
        ///         "Cnpj":  "99.999.999/9999-99"
        ///         "Emai":  "email@dominio.com.br"
        ///         "UrlImagem":"http://dominio.com.br/path/image.jpg"
        ///         "Telefone":"(99) 9999-9999"
        ///         "Responsavel":"Responsavel"
        ///     }
        ///
        /// </remarks>
        /// <param name="Id"></param>      
        /// <param name="caccc"></param>      
        /// <returns>Update institution </returns>
        /// <response code="200">Returns institution updated</response>
        /// <response code="400">it wasn`t able to update a institution</response>          

        [Authorize(Roles = "DoacaoMais")]
        [HttpPut]
        [Route("AtualizarCaccc/{Id:int?}")]
        public async Task<IActionResult> AtualizarCaccc(int? Id, [FromBody] Caccc caccc)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var result = await Task.FromResult<Caccc>(caccc);
                    return StatusCode(StatusCodes.Status201Created, $"The ong {result.Cnpj} was created!");
                }

                return StatusCode(StatusCodes.Status400BadRequest, $"The ong {caccc.Cnpj}  wasn't created");

            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, "Exception Error in Method {0} - {1}: ", e.TargetSite.ReflectedType.FullName, e);
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }


        /// <summary>
        /// Partial update a institution [Required Authorization]
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PATCH /Analista/Programador/Caccc/AtualizarParcialCaccc/3
        ///     
        ///     {
        ///         "Nome": "Nome",               
        ///         "Cnpj":  "99.999.999/9999-99"
        ///         "Emai":  "email@dominio.com.br"
        ///         "UrlImagem":"http://dominio.com.br/path/image.jpg"
        ///         "Telefone":"(99) 9999-9999"
        ///         "Responsavel":"Responsavel"
        ///     }
        ///
        /// </remarks>
        /// <param name="Id"></param>      
        /// <param name="caccc"></param>      
        /// <returns>Update institution </returns>
        /// <response code="200">Returns institution updated</response>
        /// <response code="400">it wasn`t able to update a institution</response>          

        [Authorize(Roles = "DoacaoMais")]
        [HttpPatch]
        [Route("AtualizarParcialCaccc/{Id:int?}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> AtualizarParcialCaccc([FromRoute] int? Id, [FromBody] JsonPatchDocument<Caccc> caccc)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    
                    return StatusCode(StatusCodes.Status201Created, $"The ong {await Task.FromResult<int?>(Id)} was created!");
                }

                return StatusCode(StatusCodes.Status400BadRequest, $"The ong {Id}  wasn't created");

            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, "Exception Error in Method {0} - {1}: ", e.TargetSite.ReflectedType.FullName, e);
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Delete a institution [Required Authorization]
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE / Analista/Programador/Caccc/AtualizaCaccc/8
        ///        
        /// </remarks>
        /// <param name="Id"></param>        
        /// <returns>Delete institution </returns>
        /// <response code="200">Returns institution deleted</response>
        /// <response code="400">it wasn`t able to deleted a institution</response>          

        [Authorize(Roles = "DoacaoMais")]
        [HttpDelete]
        [Route("ApagarCaccc/{Id:int?}")]
        public async Task<IActionResult> ApagarCaccc(int? Id)
        {
            try
            {

                if (ModelState.IsValid)
                {
                  
                    return StatusCode(StatusCodes.Status201Created, $"The ong {await Task.FromResult<int>(Id.Value)} was deleted!");
                }

                return StatusCode(StatusCodes.Status400BadRequest, $"The ong {Id}  wasn't deleted");

            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, "Exception Error in Method {0} - {1}: ", e.TargetSite.ReflectedType.FullName, e);
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// List all Institution
        /// </summary>
        /// <returns></returns>
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
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, "Exception Error in Method {0} - {1}: ", e.TargetSite.ReflectedType.FullName, e);
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
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, "Exception Error in Method {0} - {1}: ", e.TargetSite.ReflectedType.FullName, e);
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Brings a summary of the Institution through the Id
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
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, "Exception Error in Method {0} - {1}: ", e.TargetSite.ReflectedType.FullName, e);
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Brings a summary of the Institution through the Name
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ConteudoContasPorNomeCaccc/{caccc}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ConteudoContasPorNomeCaccc(string caccc)
        {
            try
            {
                var _result = await _cacccService.ConteudoContasPorNomeCaccc(caccc);

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
        /// List all content of all institutions
        /// </summary>
        /// <returns></returns>

        
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
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, "Exception Error in Method {0} - {1}: ", e.TargetSite.ReflectedType.FullName, e);
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

    }
}
