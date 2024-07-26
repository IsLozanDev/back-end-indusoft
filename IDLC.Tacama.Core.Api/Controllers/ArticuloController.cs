using IDCL.AVGUST.SIP.Manager.Tacama;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IDLC.Tacama.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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
        
        [HttpGet("getListArticulos/{filter?}")]
        public async Task<IActionResult> GetListArticulosTacamaFiltersAsync(string? filter = "")
        {
            filter = filter ?? string.Empty;
            var data = await _tacamaManager.GetListArticulosTacamaFiltersAsync(filter);
            return Ok(data);
        }

        [HttpGet("getArticulosDetailsSearch/{Anio}/{Mes}/{codArticulo}/{nomArticulo}/{idListaPrecio:int}/{FechaStock:DateTime}/{idCanalVenta:int}")]
        public async Task<IActionResult> GetArticulosDetailsPedidoAsync(          
            string Anio,
            string Mes,
            string codArticulo,
            string nomArticulo,
            int idListaPrecio,            
            DateTime FechaStock,
            int idCanalVenta = 0)
        {
            try
            {
                int idEmpresa = 10;
                int idAlmacen = 185;
                int idTipoArticulo = 333002;
                bool conLote = true;
                //10, 185, 333002, '2023', '08', '', 'GRAN DEMONIO', 1016, 1 ,'20230810', 106001
                codArticulo = codArticulo ?? string.Empty;
                nomArticulo = nomArticulo ?? string.Empty;

                var data = await _tacamaManager.GetArticulosDetailsPedidoAsync(idEmpresa, idAlmacen, idTipoArticulo, Anio, Mes, codArticulo, nomArticulo, idListaPrecio, conLote, FechaStock, idCanalVenta);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return NotFound(new {code = HttpStatusCode.InternalServerError, message = ex.Message});
                throw;
            }           
        }

    }
}
