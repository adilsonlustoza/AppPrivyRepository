using AppPrivy.CrossCutting.Fault;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using AppPrivy.WebAppMvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Appointment.WebApi.Controllers
{
    [ApiController]
    [Route("Analista/Programador/ContaBancaria")]
    public class ContaBancariaController : MasterController
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
