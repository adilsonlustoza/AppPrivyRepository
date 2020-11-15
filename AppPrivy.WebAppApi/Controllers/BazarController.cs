using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Mvc;
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
                    return NotFound();
                return Ok(_result);
            }
            catch (FaultException)
            {
                throw;
            }
        }




        [HttpGet]
        [Route("ListarBazarPorCacccId/{cacccId}")]
        public async Task<IActionResult> ListarBazarPorCacccId(int cacccId)
        {
            try
            {
                var _result = await _bazarService.ObtemBazarPorCacccId(cacccId);

                if (_result == null)
                    return NotFound();
                return Ok(_result);
            }
            catch (FaultException)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("ListarBazarPorCacccNome/{caccc}")]
        public async Task<IActionResult> ListarBazarPorCacccNomeAsync(string caccc)
        {
            try
            {
                var _result = await _bazarService.Search(p => p.Caccc.Nome.Contains(caccc));

                if (_result == null)
                    return NotFound();
                return Ok(_result);

            }

            catch (FaultException)
            {
                throw;
            }
        }
    }
}
