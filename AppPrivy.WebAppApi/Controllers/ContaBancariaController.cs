using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using Microsoft.AspNetCore.Mvc;
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
            var _result = await _contaBancariaService.GetAll();

            if (_result == null)
                return NotFound();
            return Ok(_result);
        }


        [HttpGet]
        [Route("ListarContasBancariasPorCacccId/{Id}")]
        public async Task<IActionResult> ListarContasBancariasPorCacccId(int? Id)
        {

            try
            {
                var _result = await _contaBancariaService.Search(p => p.CacccId == Id.Value);

                if (_result == null)
                    return NotFound();
                return Ok(_result);
            }
            catch (FaultException e)
            {
                throw e;
            }
        }
    }
}
