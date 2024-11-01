using IDCL.AVGUST.SIP.Manager.Tacama;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace IDLC.Tacama.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly ITacamaManager _tacamaManager;
        private readonly ICustomerTacamaManager _customerTacamaManager;

        public ClienteController(ILogger<ClienteController> logger, ITacamaManager tacamaManager, ICustomerTacamaManager customerTacamaManager)
        {
            _logger = logger;
            _tacamaManager = tacamaManager;
            _customerTacamaManager = customerTacamaManager;
        }

        //[HttpGet("GetClientesFilterAsync/{filter?}")]
        //public async Task<IActionResult> GetClientesFilterAsync(string? filter = "")
        //{
        //    var data = await _tacamaManager.GetClientesFilterAsync(filter);
        //    return Ok(data);
        //}

        [HttpGet("getListClients/{filter?}")]
        public async Task<IActionResult> GetListClientesFilterAsync(string? filter = "")
        {
            var data = await _tacamaManager.GetListClientesFilterAsync(filter);
            return Ok(data);
        }


        [HttpGet("getClienteSpById/{id:int}")]
        public async Task<IActionResult> GetClienteSpById(int id)
        {
            var data = await _customerTacamaManager.GetClienteSpByIdAsync(id);
            if (data == null) {
                return NotFound("Cliente no encontrado");
            }
            return Ok(data);
        }

        #region process-client

        [HttpGet("getclientes/{idEmpresa:int}/{RazonSocial}/{NroDocumento}/{activo}/{inactivo}/{CanalVenta:int}/{idVendedor:int}/{Zona:int}")]
        public async Task<IActionResult> GetListClienteAsync(int idEmpresa, string RazonSocial, string NroDocumento, bool activo, bool inactivo, int CanalVenta, int idVendedor, int Zona)
        {
            RazonSocial = RazonSocial ?? string.Empty;
            NroDocumento = NroDocumento ?? string.Empty;

            var data = await _customerTacamaManager.GetListClientesParametrosAsync(idEmpresa, RazonSocial, NroDocumento, activo, inactivo, CanalVenta, idVendedor, Zona);
            if (data == null)
            {
                return NotFound("Cliente no encontrado");
            }
            return Ok(data);

        }

        [HttpGet("getClienteById/{idCliente:int}")]
        public async Task<IActionResult> GetClienteByIdAsync(int idCliente)
        {

            var data = await _customerTacamaManager.GetClienteByIdAsync(idCliente);
            if (data == null)
            {
                return NotFound("Cliente no encontrado");
            }
            return Ok(data);
        }
        #endregion
    }
}
