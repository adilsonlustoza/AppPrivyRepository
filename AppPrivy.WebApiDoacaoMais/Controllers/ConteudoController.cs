﻿using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace AppPrivy.WebApiDoacaoMais.Controllers
{
    [ApiController]
    [Route("Analista/Programador/[controller]")]
    public class ConteudoController : ControllerBase
    {
        private readonly IConteudoService _conteudoService;
        private readonly ILogger<ConteudoController> _logger;
        public ConteudoController(IConteudoService conteudoService, ILogger<ConteudoController> logger)
        {
            _conteudoService = conteudoService;
            _logger = logger;
        }

        /// <summary>
        /// List all content of all institution
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("List")]
        public async Task<IActionResult> List()
        {
            try
            {
                var _result = await _conteudoService.ListaConteudo();

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
        /// List all content by institution Id
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListByCacccId/{Id}")]
        public async Task<IActionResult> ListByCacccId(int Id)
        {
            try
            {
                var _result = await _conteudoService.Search(p => p.CacccId == Id);

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
        /// List all content by institution name
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListByCacccName/{caccc}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ListByCacccName(string caccc)
        {
            try
            {
                var _result = await _conteudoService.Search(p => p.Caccc.Nome.Contains(caccc));

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
