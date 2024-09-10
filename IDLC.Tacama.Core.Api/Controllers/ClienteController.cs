using IDCL.AVGUST.SIP.Manager.Tacama;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
    }
}
