using IDCL.AVGUST.SIP.Entity.Pedido.SpEntity;
using IDCL.AVGUST.SIP.ManagerDto.Pedido;
using IDCL.AVGUST.SIP.ManagerDto.StoreProcedure;
using IDCL.AVGUST.SIP.ManagerDto.StoreProcedure.LineaCuentas;

namespace IDCL.AVGUST.SIP.Manager.Pedido
{
    public interface IPedidoManager
    {
        Task<AddPedidoDto> AddPedido(AddPedidoDto model);
        Task<List<GetCostoArticuloDto>> getListArticulos(int idArticulo, string idMoneda, string codigo, string fechaStock);
        Task<List<GetAvanceCobranzaZVDto>> ListarAvanceCobranzaZonaVendedor(int idEmpresa, string fechaInicio, string fechaFin);
        Task<List<GetClientesAprobadoDto>> ListarClientesAprobadosLCPorZona(int idEmpresa,int idZona);
        Task<List<GetClientesAtendidosDto>> ListarClientesAtendidosLCPorZona(int idEmpresa, int idZona);
        Task<List<GetClientesAtentidosSinLCDto>> ListarClientesAtendidosSinLC(int idEmpresa, int idZona);
        Task<List<ListarCobranzaPresupuestoZonaVendedor>> ListarCobranzaPresupuestoZonaVendedor(int idEmpresa, string anio, string mes, int idZona);
        Task<List<ListarCreditoZonaClienteVf>> ListarCreditoZonaClienteVf(int idEmpresa, int idZona);
        Task<List<GetCtaCteAtrazadaZonaDto>> ListarCtaCteAtrazadaPorZona(int idEmpresa, int idZona, string fechaFiltro);
        Task<List<GetLetraPorAceptarZonaDto>> ListarLetraPorAceptarZona(int idEmpresa, int idZona);
        Task<List<GetLineaCreditoDisponibleDto>> ListarLineaCreditoDisponibleZonaCliente(int idEmpresa, int idZona);
        Task<List<GetListaSegmentoZonaDto>> ListarSegmentoZona(int idEmpresa, string Anio, string Mes, int idZona, string Tipo);
        Task<List<GetListarTopClienteDto>> ListarTopCliente(int idEmpresa, string Anio, string Mes, int idZona, string Tipo );
        Task<List<GetListaVentaClienteProductoDto>> ListarVentaClienteProducto(int idEmpresa, string Anio, string Mes, int idZona, int idCliente, string Tipo);
        Task<List<GetListaVentaProdutoDto>> ListarVentaProducto(int idEmpresa, string Anio, string Mes, int idZona, string Tipo, string Formato);
        Task<List<ListaPptoVentaZonaVendedor>> ListarVentasPresupuestoZonaVendedor(int idEmpresa, string anio, string mes, int idZona, string Tipo);
        Task<List<GetListaZonaVendedorDto>> ListarZonaVendedor(int idEmpresa, string Anio, string Mes, int idZona);
    }
}