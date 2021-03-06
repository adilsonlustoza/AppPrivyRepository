﻿using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AppPrivy.WebAppApi.Controllers
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


        [HttpGet]
        [Route("ListarNoticia")]
        public async Task<IActionResult> ListarNoticia()
        {
            try
            {
                var _result = await _noticiaService.GetAll();

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
        [Route("ListarNoticiaPorCacccId/{Id}")]
        public async Task<IActionResult> ListarNoticiaPorCacccId(int? Id)
        {
            try
            {
                if (!Id.HasValue)
                    throw new ApplicationException("Invalid parameter");

                var _result = await _noticiaService.Search(p => p.CacccId == Id.Value);

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
        [Route("ListarNoticiaPorCacccNome/{caccc}")]
        public async Task<IActionResult> ListarNoticiaPorCacccNome(string caccc)
        {
            try
            {

                if (string.IsNullOrEmpty(caccc))
                    throw new ArgumentException("Invalid parameter");

                var _result = await _noticiaService.Search(p => p.Caccc.Nome.ToLower().Trim().Contains(caccc.ToLower().Trim()));

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
        [Route("ListarNoticiasGeraisPorCacccId/{Id}")]
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
