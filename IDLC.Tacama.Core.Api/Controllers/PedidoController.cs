using IDCL.AVGUST.SIP.Manager.Tacama;
using IDLC.Tacama.Core.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IDLC.Tacama.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly ILogger<PedidoController> _logger;
        private readonly ITacamaManager _tacamaManager;

        public PedidoController(ILogger<PedidoController> logger, ITacamaManager tacamaManager)
        {
            _logger = logger;
            _tacamaManager = tacamaManager;
        }
        

        [HttpGet("GetListPedidoNacional/{idEmpresa:int}/{idLocal:int}/{codPedidoCad?}/{todos:bool}/{fecInicial:DateTime}/{fecFinal:DateTime}/{Estado?}/{RazonSocial?}/{Tipo:bool}/{idVendedor:int}/{indCotPed}")]

        public async Task<IActionResult> GetGeoByIdPersona(int idEmpresa, int idLocal, string? codPedidoCad, bool todos, DateTime fecInicial, DateTime fecFinal,
            string? Estado, string? RazonSocial, bool Tipo, int idVendedor, string indCotPed)

        {

            codPedidoCad = codPedidoCad ?? string.Empty;
            Estado = Estado ?? "%";
            RazonSocial = RazonSocial ?? "%";

            var data = await _tacamaManager.GetListarPedidoNacionalAsync(idEmpresa, idLocal, codPedidoCad, false, fecInicial, fecFinal, Estado, RazonSocial, false, idVendedor, indCotPed);

            return Ok(data);
        }
    }
}
