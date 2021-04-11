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
    public class BoletimController : ControllerBase

    {
        private readonly IBoletimService _boletimService;
        private readonly ILogger<BoletimController> _logger;

        public BoletimController(IBoletimService boletimService, ILogger<BoletimController> logger)
        {
            _boletimService = boletimService;
            _logger = logger;
        }

        /// <summary>
        /// List all linked articles with institutions
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarBoletim")]
        public async Task<IActionResult> ListarBoletim()
        {
            try
            {
                var _result = await _boletimService.GetAll();

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
        /// List all linked articles by institution Id
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarBoletimPorCacccId/{Id}")]
        public async Task<IActionResult> ListarBoletimPorCaccc(int? Id)
        {
            try
            {
                if (!Id.HasValue)
                    new ArgumentException("Invalid parameter!");

                var _result = await _boletimService.ListaBoletimCaccc(Id);

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
        /// List all linked articles by institution name
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("ListarBoletimPorCacccNome/{caccc}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ListarBoletimPorCacccNome(string caccc)
        {
            try
            {
                if (string.IsNullOrEmpty(caccc) )
                    new ArgumentException("Invalid parameter!");

                var _result = await _boletimService.Search(p => p.Caccc.Nome.Contains(caccc));

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
