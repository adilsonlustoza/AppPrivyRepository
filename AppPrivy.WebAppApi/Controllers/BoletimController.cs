using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace AppPrivy.WebAppApi.Controllers
{
    [ApiController]
    [Route("Analista/Programador/[controller]")]
    public class BoletimController : ControllerBase

    {
        private readonly IBoletimService _boletimService;

        public BoletimController(IBoletimService boletimService)
        {
            _boletimService = boletimService;
        }


        [HttpGet]
        [Route("ListarBoletim")]
        public async Task<IActionResult> ListarBoletim()
        {
            try
            {
                var _result = await _boletimService.GetAll();

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
        [Route("ListarBoletimPorCacccId/{Id}")]
        public async Task<IActionResult> ListarBoletimPorCaccc(int? Id)
        {
            try
            {
                if (!Id.HasValue)
                    new ArgumentException("Invalid parameter!");

                var _result = await _boletimService.ListaBoletimCaccc(Id);

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
        [Route("ListarBoletimPorCacccNome/{caccc}")]
        public async Task<IActionResult> ListarBoletimPorCacccNome(string caccc)
        {
            try
            {
                if (string.IsNullOrEmpty(caccc) )
                    new ArgumentException("Invalid parameter!");

                var _result = await _boletimService.Search(p => p.Caccc.Nome.Contains(caccc));

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
