using IDCL.AVGUST.SIP.Manager.Pedido;
using IDCL.AVGUST.SIP.ManagerDto.Pedido;
using Microsoft.AspNetCore.Mvc;
using MINEDU.IEST.Estudiante.Inf_Utils.Helpers;
using System.Net.Http.Headers;
using System.Text;

namespace IDCL.AVGUST.SIP.PedidoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoAbController : ControllerBase
    {
        private readonly ILogger<PedidoAbController> _logger;
        private readonly IPedidoManager _pedidoManager;


        //Api para generar JWT
        public PedidoAbController(ILogger<PedidoAbController> logger, IPedidoManager pedidoManager)
        {
            _logger = logger;
            _pedidoManager = pedidoManager;
        }

        private bool IsRequestAuthenticated()
        {
            try
            {
                if (AuthenticationHeaderValue.TryParse(Request.Headers.Authorization,
                                                       out var basicAuthCredential))
                {
                    if (basicAuthCredential.Scheme == "Basic" &&
                        !string.IsNullOrWhiteSpace(basicAuthCredential.Parameter))
                    {
                        var usernamePassword =
                            Encoding.UTF8.GetString(Convert.FromBase64String(basicAuthCredential.Parameter));
                        if (!string.IsNullOrWhiteSpace(usernamePassword))
                        {
                            var separatorIndex = usernamePassword.IndexOf(':');

                            var username = usernamePassword[..separatorIndex];
                            var password = usernamePassword[(separatorIndex + 1)..];

                            if (username == "indusoft" &&
                                password == "123456")
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch
            {
                //logic for catching exceptions here
            }

            return false;
        }

        [HttpGet("GetListCostoArticulo/{idEmpresa:int}/{idMoneda}/{codArticulo?}/{fechaStock?}")]
        public async Task<IActionResult> GetArticulos(int idEmpresa, string idMoneda, string? codArticulo = null, string? fechaStock = null)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.getListArticulos(idEmpresa, idMoneda, codArticulo, fechaStock));
            }
            return Unauthorized();
        }


        [HttpGet("GetListarZonaVendedor/{idEmpresa:int}/{Anio}/{Mes}/{idZona}")]
        public async Task<IActionResult> GetListarZonaVendedor(int idEmpresa, string Anio, string Mes, int idZona)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarZonaVendedor(idEmpresa, Anio, Mes, idZona));
            }
            return Unauthorized();
        }


        [HttpGet("GetListarSegmentoZona/{idEmpresa:int}/{Anio}/{Mes}/{idZona}/{Tipo}")]
        public async Task<IActionResult> GetListarSegmentoZona(int idEmpresa, string Anio, string Mes, int idZona, string Tipo)
        {
            if (IsRequestAuthenticated())
            {

            }
            return Unauthorized();

            return Ok(await _pedidoManager.ListarSegmentoZona(idEmpresa, Anio, Mes, idZona, Tipo));
        }


        [HttpGet("GetListarTopCliente/{idEmpresa:int}/{Anio}/{Mes}/{idZona}/{Tipo}")]
        public async Task<IActionResult> GetListarTopCliente(int idEmpresa, string Anio, string Mes, int idZona, string Tipo)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarTopCliente(idEmpresa, Anio, Mes, idZona, Tipo));
            }
            return Unauthorized();
            
        }


        [HttpGet("GetListarVentaProducto/{idEmpresa:int}/{Anio}/{Mes}/{idZona}/{Tipo}/{Formato}")]
        public async Task<IActionResult> GetListarVentaProducto(int idEmpresa, string Anio, string Mes, int idZona, string Tipo, string Formato)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarVentaProducto(idEmpresa, Anio, Mes, idZona, Tipo, Formato));
            }
            return Unauthorized();
            
        }


        [HttpGet("GetListarVentaClienteProducto/{idEmpresa:int}/{Anio}/{Mes}/{idZona}/{idCliente}/{Tipo}")]
        public async Task<IActionResult> GetListarVentaClienteProducto(int idEmpresa, string Anio, string Mes, int idZona, int idCliente, string Tipo)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarVentaClienteProducto(idEmpresa, Anio, Mes, idZona, idCliente, Tipo));
            }
            return Unauthorized();
            
        }


        #region Linea - Credido


        [HttpGet("GetListarLineaCreditoDisponibleZonaCliente/{idEmpresa:int}/{idZona}")]
        public async Task<IActionResult> GetListarLineaCreditoDisponibleZonaCliente(int idEmpresa, int idZona)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarLineaCreditoDisponibleZonaCliente(idEmpresa, idZona));
            }
            return Unauthorized();
            
        }


        [HttpGet("GetListarClientesAprobadosLCPorZona/{idEmpresa:int}/{idZona}")]
        public async Task<IActionResult> GetListarClientesAprobadosLCPorZona(int idEmpresa, int idZona)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarClientesAprobadosLCPorZona(idEmpresa, idZona));
            }
            return Unauthorized();
            
        }


        [HttpGet("GetListarClientesAtendidosLCPorZona/{idEmpresa:int}/{idZona}")]
        public async Task<IActionResult> GetListarClientesAtendidosLCPorZona(int idEmpresa, int idZona)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarClientesAtendidosLCPorZona(idEmpresa, idZona));
            }
            return Unauthorized();
            
        }


        [HttpGet("GetListarClientesAtendidosSinLC/{idEmpresa:int}/{idZona}")]
        public async Task<IActionResult> GetListarClientesAtendidosSinLC(int idEmpresa, int idZona)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarClientesAtendidosSinLC(idEmpresa, idZona));
            }
            return Unauthorized();
            
        }


        [HttpGet("GetListarAvanceCobranzaZonaVendedor/{idEmpresa:int}/{fechaInicio}/{fechaFin}")]
        public async Task<IActionResult> GetListarAvanceCobranzaZonaVendedor(int idEmpresa, string fechaInicio, string fechaFin)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarAvanceCobranzaZonaVendedor(idEmpresa, fechaInicio, fechaFin));
            }
            return Unauthorized();
            
        }


        [HttpGet("GetListarCtaCteAtrazadaPorZona/{idEmpresa:int}/{idZona}/{fechaFiltro}")]
        public async Task<IActionResult> GetListarCtaCteAtrazadaPorZona(int idEmpresa, int idZona, string fechaFiltro)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarCtaCteAtrazadaPorZona(idEmpresa, idZona, fechaFiltro));
            }
            return Unauthorized();
            
        }


        [HttpGet("GetListarLetraPorAceptarZona/{idEmpresa:int}/{idZona}")]
        public async Task<IActionResult> GetListarLetraPorAceptarZona(int idEmpresa, int idZona)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarLetraPorAceptarZona(idEmpresa, idZona));
            }
            return Unauthorized();
            
        }


        #endregion


        [HttpPost("AddPedido")]
        public async Task<IActionResult> AddPedido(AddPedidoDto model)
        {
            if (IsRequestAuthenticated())
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
            return Unauthorized();
        }


        #region Adicionales


        [HttpGet("ListarVentasPresupuestoZonaVendedor/{idEmpresa:int}/{anio}/{mes}/{idZona:int}/{Tipo}")]
        public async Task<IActionResult> ListarVentasPresupuestoZonaVendedor(int idEmpresa, string anio, string mes, int idZona, string Tipo)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarVentasPresupuestoZonaVendedor(idEmpresa, anio, mes, idZona, Tipo));
            }
            return Unauthorized();
            
        }


        [HttpGet("ListarCobranzaPresupuestoZonaVendedor/{idEmpresa:int}/{anio}/{mes}/{idZona:int}")]
        public async Task<IActionResult> ListarCobranzaPresupuestoZonaVendedor(int idEmpresa, string anio, string mes, int idZona)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarCobranzaPresupuestoZonaVendedor(idEmpresa, anio, mes, idZona));
            }
            return Unauthorized();
            
        }


        [HttpGet("ListarCreditoZonaClienteVf/{idEmpresa:int}/{idZona:int}")]
        public async Task<IActionResult> ListarCreditoZonaClienteVf(int idEmpresa, int idZona)
        {
            if (IsRequestAuthenticated())
            {
                return Ok(await _pedidoManager.ListarCreditoZonaClienteVf(idEmpresa, idZona));
            }
            return Unauthorized();
            
        }

        #endregion
    }
}
