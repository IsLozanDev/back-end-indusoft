using IDCL.AVGUST.SIP.Manager.Tacama;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IDLC.Tacama.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MasterController : ControllerBase
    {
        private readonly ILogger<MasterController> _logger;
        private readonly IMasterTacamaManager _masterTacamaManager;

        public MasterController(ILogger<MasterController> logger, IMasterTacamaManager masterTacamaManager)
        {
            _logger = logger;
            _masterTacamaManager = masterTacamaManager;
        }

        #region condicion-venta


        [HttpGet("getListCondicion/{filter?}")]
        public async Task<IActionResult> getListCondicion(string? filter = "")
        {
            var data = await _masterTacamaManager.GetListCondicionesFilterAsync(filter);
            if (data == null)
            {
                return NotFound("Cliente no encontrado");
            }
            return Ok(data);
        }

        #endregion

        #region Vendedores

        [HttpGet("getVendedorById/{idPersona:int}")]
        public async Task<IActionResult> GetVendedorById(int idPersona)
        {
            int idEmpresa = 10;
            var data = await _masterTacamaManager.GetSpVendedorById(idEmpresa, idPersona);
            if (data == null)
            {
                return NotFound("Vendedor no encontrado");
            }
            return Ok(data);
        }
        #endregion
    }
}
