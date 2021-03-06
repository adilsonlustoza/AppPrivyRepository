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
    public class ContaBancariaController : ControllerBase
    {
        private readonly IContaBancariaService _contaBancariaService;

        public ContaBancariaController(IContaBancariaService contaBancariaService)
        {
            _contaBancariaService = contaBancariaService;
        }


        [HttpGet]
        [Route("ListarContasBancarias")]
        public async Task<IActionResult> ListarContasBancarias()
        {
            try
            {
                var _result = await _contaBancariaService.GetAll();

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
        [Route("ListarContasBancariasPorCacccId/{Id}")]
        public async Task<IActionResult> ListarContasBancariasPorCacccId(int? Id)
        {

            try
            {
                if(!Id.HasValue )
                 new ArgumentException("Invalid parameter!");

                var _result = await _contaBancariaService.Search(p => p.CacccId == Id.Value);

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
