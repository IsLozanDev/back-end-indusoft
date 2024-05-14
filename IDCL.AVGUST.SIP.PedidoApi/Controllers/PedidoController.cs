using IDCL.AVGUST.SIP.Manager.Pedido;
using IDCL.AVGUST.SIP.ManagerDto.Pedido;
using Microsoft.AspNetCore.Mvc;
using MINEDU.IEST.Estudiante.Inf_Utils.Helpers;

namespace IDCL.AVGUST.SIP.PedidoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly ILogger<PedidoController> _logger;
        private readonly IPedidoManager _pedidoManager;


        //Camoens
        public PedidoController(ILogger<PedidoController> logger, IPedidoManager pedidoManager)
        {
            _logger = logger;
            _pedidoManager = pedidoManager;
        }

        [HttpGet("GetListCostoArticulo/{idEmpresa:int}/{idMoneda}/{codArticulo?}/{fechaStock?}")]
        public async Task<IActionResult> GetArticulos(int idEmpresa, string idMoneda, string? codArticulo = null, string? fechaStock = null)
        {
            return Ok(await _pedidoManager.getListArticulos(idEmpresa, idMoneda, codArticulo, fechaStock));
        }

        [HttpGet("GetListarZonaVendedor/{idEmpresa:int}/{Anio}/{Mes}/{idZona}")]
        public async Task<IActionResult> GetListarZonaVendedor(int idEmpresa, string Anio, string Mes, int idZona)
        {
            return Ok(await _pedidoManager.ListarZonaVendedor(idEmpresa, Anio, Mes, idZona));
        }

        [HttpGet("GetListarSegmentoZona/{idEmpresa:int}/{Anio}/{Mes}/{idZona}/{Tipo}")]
        public async Task<IActionResult> GetListarSegmentoZona(int idEmpresa, string Anio, string Mes, int idZona, string Tipo)
        {
            return Ok(await _pedidoManager.ListarSegmentoZona(idEmpresa, Anio, Mes, idZona, Tipo));
        }

        [HttpGet("GetListarTopCliente/{idEmpresa:int}/{Anio}/{Mes}/{idZona}/{Tipo}")]
        public async Task<IActionResult> GetListarTopCliente(int idEmpresa, string Anio, string Mes, int idZona, string Tipo)
        {
            return Ok(await _pedidoManager.ListarTopCliente(idEmpresa, Anio, Mes, idZona, Tipo));
        }

        [HttpGet("GetListarVentaProducto/{idEmpresa:int}/{Anio}/{Mes}/{idZona}/{Tipo}/{Formato}")]
        public async Task<IActionResult> GetListarVentaProducto(int idEmpresa, string Anio, string Mes, int idZona, string Tipo, string Formato)
        {
            return Ok(await _pedidoManager.ListarVentaProducto(idEmpresa, Anio, Mes, idZona, Tipo, Formato));
        }

        [HttpGet("GetListarVentaClienteProducto/{idEmpresa:int}/{Anio}/{Mes}/{idZona}/{idCliente}/{Tipo}")]
        public async Task<IActionResult> GetListarVentaClienteProducto(int idEmpresa, string Anio, string Mes, int idZona, int idCliente, string Tipo)
        {
            return Ok(await _pedidoManager.ListarVentaClienteProducto(idEmpresa, Anio, Mes, idZona, idCliente, Tipo));
        }


        #region Linea - Credido

        [HttpGet("GetListarLineaCreditoDisponibleZonaCliente/{idEmpresa:int}/{idZona}")]
        public async Task<IActionResult> GetListarLineaCreditoDisponibleZonaCliente(int idEmpresa, int idZona)
        {
            return Ok(await _pedidoManager.ListarLineaCreditoDisponibleZonaCliente(idEmpresa, idZona));
        }

        [HttpGet("GetListarClientesAprobadosLCPorZona/{idEmpresa:int}/{idZona}")]
        public async Task<IActionResult> GetListarClientesAprobadosLCPorZona(int idEmpresa, int idZona)
        {
            return Ok(await _pedidoManager.ListarClientesAprobadosLCPorZona(idEmpresa, idZona));
        }

        [HttpGet("GetListarClientesAtendidosLCPorZona/{idEmpresa:int}/{idZona}")]
        public async Task<IActionResult> GetListarClientesAtendidosLCPorZona(int idEmpresa, int idZona)
        {
            return Ok(await _pedidoManager.ListarClientesAtendidosLCPorZona(idEmpresa, idZona));
        }

        [HttpGet("GetListarClientesAtendidosSinLC/{idEmpresa:int}/{idZona}")]
        public async Task<IActionResult> GetListarClientesAtendidosSinLC(int idEmpresa, int idZona)
        {
            return Ok(await _pedidoManager.ListarClientesAtendidosSinLC(idEmpresa, idZona));
        }

        [HttpGet("GetListarAvanceCobranzaZonaVendedor/{idEmpresa:int}/{fechaInicio}/{fechaFin}")]
        public async Task<IActionResult> GetListarAvanceCobranzaZonaVendedor(int idEmpresa, string fechaInicio, string fechaFin)
        {
            return Ok(await _pedidoManager.ListarAvanceCobranzaZonaVendedor(idEmpresa, fechaInicio, fechaFin));
        }

        [HttpGet("GetListarCtaCteAtrazadaPorZona/{idEmpresa:int}/{idZona}/{fechaFiltro}")]
        public async Task<IActionResult> GetListarCtaCteAtrazadaPorZona(int idEmpresa, int idZona, string fechaFiltro)
        {
            return Ok(await _pedidoManager.ListarCtaCteAtrazadaPorZona(idEmpresa, idZona, fechaFiltro));
        }

        [HttpGet("GetListarLetraPorAceptarZona/{idEmpresa:int}/{idZona}")]
        public async Task<IActionResult> GetListarLetraPorAceptarZona(int idEmpresa, int idZona)
        {
            return Ok(await _pedidoManager.ListarLetraPorAceptarZona(idEmpresa, idZona));
        }


        #endregion


        [HttpPost("AddPedido")]
        public async Task<IActionResult> AddPedido(AddPedidoDto model)
        {
            try
            {
                var response = await _pedidoManager.AddPedido(model);
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


        #region Adicionales

        [HttpGet("ListarVentasPresupuestoZonaVendedor/{idEmpresa:int}/{anio}/{mes}/{idZona:int}/{Tipo}")]
        public async Task<IActionResult> ListarVentasPresupuestoZonaVendedor(int idEmpresa, string anio, string mes, int idZona, string Tipo)
        {
            return Ok(await _pedidoManager.ListarVentasPresupuestoZonaVendedor(idEmpresa, anio, mes, idZona, Tipo));
        }

        [HttpGet("ListarCobranzaPresupuestoZonaVendedor/{idEmpresa:int}/{anio}/{mes}/{idZona:int}")]
        public async Task<IActionResult> ListarCobranzaPresupuestoZonaVendedor(int idEmpresa, string anio, string mes, int idZona)
        {
            return Ok(await _pedidoManager.ListarCobranzaPresupuestoZonaVendedor(idEmpresa, anio, mes, idZona));
        }

        [HttpGet("ListarCreditoZonaClienteVf/{idEmpresa:int}/{idZona:int}")]
        public async Task<IActionResult> ListarCreditoZonaClienteVf(int idEmpresa, int idZona)
        {
            return Ok(await _pedidoManager.ListarCreditoZonaClienteVf(idEmpresa, idZona));
        }

        #endregion
    }
}
