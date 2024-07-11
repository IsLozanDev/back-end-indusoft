using IDCL.AVGUST.SIP.Manager.Tacama;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IDLC.Tacama.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly ITacamaManager _tacamaManager;

        public ClienteController(ILogger<ClienteController> logger, ITacamaManager tacamaManager)
        {
            _logger = logger;
            _tacamaManager = tacamaManager;
        }

        [HttpGet("GetClientesFilterAsync/{filter?}")]
        public async Task<IActionResult> GetClientesFilterAsync(string? filter = "")
        {
            var data = await _tacamaManager.GetClientesFilterAsync(filter);
            return Ok(data);
        }
        
        [HttpGet("getListClients/{filter?}")]
        public async Task<IActionResult> GetListClientesFilterAsync(string? filter = "")
        {
            var data = await _tacamaManager.GetListClientesFilterAsync(filter);
            return Ok(data);
        }
    }
}
