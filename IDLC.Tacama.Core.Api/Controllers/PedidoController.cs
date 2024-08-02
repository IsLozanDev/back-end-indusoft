using IDCL.AVGUST.SIP.Manager.Tacama;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Pedido.Cmd;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MINEDU.IEST.Estudiante.Inf_Utils.Helpers;
using System;
using System.Net;
using System.Threading.Tasks;

namespace IDLC.Tacama.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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

        [HttpPost("SavePedido")]
        public async Task<IActionResult> SavePedido(CmdPedidoTacamaDto model)
        {
            try
            {
                var response = await _tacamaManager.SavePedido(model);
                if (response.EsError)
                {
                    ModelState.AddModelError("validacion", response.MensajeError);
                    return UnprocessableEntity(ExtensionTools.Validaciones(ModelState));
                }
                return Ok(new { idPedido = response.IdFacturar });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("validacion", ex.Message);
                UnprocessableEntity(ExtensionTools.Validaciones(ModelState));
                _logger.LogError(ex.Message, ex);
                throw;
            }
        }

        [HttpGet("getClientInfo/{id:int}")]
        public async Task<IActionResult> GetPedidoHeaderByIdClienteAsync(int id)
        {
            try
            {
                var query = await _tacamaManager.GetCanalandConditionByIdClienteAsync(id);
                return Ok(query);
            }
            catch (Exception ex)
            {
                return NotFound(new { code = HttpStatusCode.InternalServerError, message = ex.Message });
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPedidoByIdAsync(int id)
        {
            var query = await _tacamaManager.GetPedidoForEditAsync(id);
            return Ok(query);
        }
        
    }
}
