using IDCL.AVGUST.SIP.Manager.Tacama;
using Microsoft.AspNetCore.Mvc;

namespace IDLC.Tacama.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticuloController : ControllerBase
    {
        private readonly ILogger<ArticuloController> _logger;
        private readonly ITacamaManager _tacamaManager;

        public ArticuloController(ILogger<ArticuloController> logger, ITacamaManager tacamaManager)
        {
            _logger = logger;
            _tacamaManager = tacamaManager;
        }


        [HttpGet("GetArticulosByFilter/{filter?}")]
        public async Task<IActionResult> GetArticulosByFilter(string? filter = "")
        {
            filter = filter ?? string.Empty;
            var data = await _tacamaManager.GetArticulosTacamaAsync(filter);
            return Ok(data);
        }
    }
}
