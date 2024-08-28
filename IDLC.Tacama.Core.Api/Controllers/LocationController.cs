using IDCL.AVGUST.SIP.Manager.Tacama;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IDLC.Tacama.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LocationController : ControllerBase
    {
        private readonly ILogger<LocationController> _logger;
        private readonly ILocationTacamaManager _locationTacamaManager;

        public LocationController(ILogger<LocationController> logger, ILocationTacamaManager locationTacamaManager)
        {
            _logger = logger;
            _locationTacamaManager = locationTacamaManager;
        }

        [HttpGet("getDptos")]
        public async Task<IActionResult> GetDpto() => Ok(await _locationTacamaManager.GetDpto());

        [HttpGet("getProvincias/{id}")]
        public async Task<IActionResult> GetProv(string id) => Ok(await _locationTacamaManager.GetProvinciaByDpto(id));

        [HttpGet("getDistrito/{id}")]
        public async Task<IActionResult> GetDistrio(string id) => Ok(await _locationTacamaManager.GetDistritoByProv(id));
    }
}
