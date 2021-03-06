﻿using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AppPrivy.WebAppApi.Controllers
{
    [ApiController]
    [Route("Analista/Programador/[controller]")]

    public class BazarController : ControllerBase
    {
        private readonly IBazarService _bazarService;

        public BazarController(IBazarService bazarService)
        {
            _bazarService = bazarService;
        }


        [HttpGet]
        [Route("ListarBazar")]
        public async Task<IActionResult> ListarBazar()
        {
            try
            {
                var _result = await _bazarService.GetAll();

                if (_result == null)
                    return StatusCode(StatusCodes.Status404NotFound, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }


        [HttpGet]
        [Route("ListarBazarPorCacccId/{cacccId}")]
        public async Task<IActionResult> ListarBazarPorCacccId(int? cacccId)
        {
            try
            {
                if (!cacccId.HasValue )
                    new ArgumentException("Invalid parameter!");

                var _result = await _bazarService.ObtemBazarPorCacccId(cacccId);

                if (_result == null)
                    return StatusCode(StatusCodes.Status404NotFound, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);
            }
            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("ListarBazarPorCacccNome/{caccc}")]
        public async Task<IActionResult> ListarBazarPorCacccNomeAsync(string caccc)
        {
            try
            {
                if (!string.IsNullOrEmpty(caccc) )
                    new ArgumentException("Invalid parameter!");

                var _result = await _bazarService.Search(p => p.Caccc.Nome.Contains(caccc));

                if (_result == null)
                    return StatusCode(StatusCodes.Status404NotFound, string.Format("Your search returned no results!"));
                return StatusCode(StatusCodes.Status200OK, _result);

            }

            catch (FaultException e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
