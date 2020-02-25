using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using AppPrivy.WebAppMvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace Appointment.WebApi.Controllers
{
    [ApiController]
    [Route("Analista/Programador/Boletim")]
    public class BoletimController : MasterController
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
            var _result = await _boletimService.GetAll();

            if (_result == null)
                return NotFound();
            return Ok(_result);
        }

        [HttpGet]
        [Route("ListarBoletimPorCacccId/{Id}")]
        public async Task<IActionResult> ListarBoletimPorCaccc(int? Id)
        {
            var _result = await _boletimService.ListaBoletimCaccc(Id);

            if (_result == null)
                return NotFound();
            return Ok(_result);
        }



        [HttpGet]
        [Route("ListarBoletimPorCacccNome/{caccc}")]
        public IActionResult ListarBoletimPorCacccNome(string caccc)
        {
            var _result = _boletimService.Search(p => p.Caccc.Nome.Contains(caccc));

            if (_result == null)
                return NotFound();
            return Ok(_result);
        }
    }
}
